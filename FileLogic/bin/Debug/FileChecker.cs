using System;
using System.Data.Entity.Core;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FileLogic
{
    class FileChecker
    {
        string _path = "";
        string _MovePath = "";
        int currentTestId;

        public FileChecker(string path)
        {
            try
            {
                _path = path;
                _MovePath = _path + @"\addedTests\";
                if (Directory.Exists(_path) == false)
                {
                    Directory.CreateDirectory(_path);
                    Debug.WriteLine("Created the folder");
                }

                if (Directory.Exists(_MovePath) == false)
                {
                    Directory.CreateDirectory(_MovePath);
                    Debug.WriteLine("Created the movefolder");
                }
            }
            catch (Exception ex)
            {
                //ToDo: Logga till loggfil eller eventlog
                Console.WriteLine(ex.Message);
            }
        }

        public void readXmlFiles()
        {
            //Gets all files from the directory, but populates only the list of files with .xml-files.
            DirectoryInfo myFileList = new DirectoryInfo(_path);
            FileInfo[] files = myFileList.GetFiles("*.xml");

            if (files.Length == 0)
            {
                Debug.WriteLine("No files found");
            }

            foreach (FileInfo item in files)
            {
                string nameOfFile = item.Name.ToString();
                var document = XDocument.Load(nameOfFile.ToString());

                var test = (from t in document.Descendants("TestData")
                            select new
                            {
                                name = t.Element("Name").Value.ToString(),
                                mainLang = t.Element("MainLang").Value.ToString(),
                                secLang = t.Element("SecLang").Value.ToString()
                            }).FirstOrDefault();

                var words = (from w in document.Descendants("Word")
                             select new
                             {
                                 MainWord = w.Element("MainWord").Value.ToString(),
                                 SecWord = w.Element("SecWord").Value.ToString()
                             });

                if (test != null && words != null)
                {

                    try
                    {
                        using (GlossaryServiceModel dbConnection = new GlossaryServiceModel())
                        {

                            //Get's the id of languages where the name of mainlang and seclang equals a row in table Languages.
                            int main = (from l in dbConnection.Languages
                                        where test.mainLang == l.Language.ToString()
                                        select l.Id).FirstOrDefault();

                            int sec = (from l in dbConnection.Languages
                                       where test.secLang == l.Language.ToString()
                                       select l.Id).FirstOrDefault();

                            Test newTest = new Test();
                            newTest.Name = test.name;
                            newTest.Date = DateTime.Now;
                            newTest.StatusId = 0;
                            newTest.MainLang = main;
                            newTest.SecLang = sec;
                            newTest.UserId = 77;

                            dbConnection.Test.Add(newTest);
                            dbConnection.SaveChanges();

                            currentTestId = newTest.Id;

                            foreach (var word in words)
                            {
                                Word newWord = new Word();
                                newWord.TestId = currentTestId;
                                newWord.Word1 = word.MainWord;
                                newWord.Word2 = word.SecWord;

                                dbConnection.Word.Add(newWord);
                                dbConnection.SaveChanges();
                            }
                        }

                        MoveFilesFromFolder(nameOfFile);
                    }

                    catch (EntityException ex)
                    {
                        MessageBox.Show("Could not save the XML-file to database." + ex.Message);

                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Error when saving to Database." + ex.Message + ex.InnerException);
                    }
                }

                else
                {
                    MessageBox.Show("Error loading XML-file. Are you sure it is in the right format?");
                }
            }
        }

        
        public void MoveFilesFromFolder(string _nameOfFile)
        {
            DirectoryInfo myFileList = new DirectoryInfo(_path);
            FileInfo[] filer = myFileList.GetFiles(_nameOfFile);

            if (filer.Length == 0)
                Debug.WriteLine("No files to move found");

            foreach (FileInfo item in filer)
            {
                item.MoveTo(_MovePath + item.Name);
                Debug.WriteLine(item.Name + " moved to: " + _MovePath);
            }
        }
    }
}
