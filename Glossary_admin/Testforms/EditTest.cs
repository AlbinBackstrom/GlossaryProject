using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Glossary_Admin.Testforms
{
    
    public partial class EditTest : Form
    {
        int numberOfWords;
        int currentTestId;
        string mainLang;
        string secLang;
        string[] mainLangArr;
        string[] secLangArr;
        public EditTest()
        {
            InitializeComponent();
            onLoad();
        }
        public void onLoad()
        {
            try
            {
                using (GlossaryAdminModel dbConnection = new GlossaryAdminModel())
                {
                    cbTestIdAndName.DataSource = dbConnection.Test.ToList();
                    cbTestIdAndName.DisplayMember = "TestId";
                    cbTestIdAndName.Invalidate();
                }
            }
            catch (EntityException ex)
            {
                MessageBox.Show("Could not populate the dropdown list." + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("General error when populating the dropdown list." + ex.Message + ex.InnerException);
            }
           
        }
        //Changes the format of the combobox, instead of only showing one memeber it shows two.
        private void IdAndNameFormat(object sender, ListControlConvertEventArgs e)
        {
            string id = ((Test)e.ListItem).Id.ToString();
            string name = ((Test)e.ListItem).Name;

            e.Value = id + "    " + name;
        }
        private void btnLoadTest_Click(object sender, EventArgs e)
        {
            int cb;
            int.TryParse(cbTestIdAndName.SelectedValue.ToString(), out cb);

            using (GlossaryAdminModel dbConnection = new GlossaryAdminModel())
            {
                var selectedTest = (from t in dbConnection.Test
                                    where t.Id == cb
                                    select new {
                                        t.Id,
                                        t.Name,
                                        t.MainLang,
                                        t.SecLang
                                    }).FirstOrDefault();

                //Gets the id of the recently saved test to be able to perform LINQ-questions below.
                currentTestId = selectedTest.Id;

                 mainLang = (from l in dbConnection.Languages
                                   where l.Id == selectedTest.MainLang
                                   select l.Language).FirstOrDefault();


                secLang = (from l in dbConnection.Languages
                                  where l.Id == selectedTest.SecLang
                                  select l.Language).FirstOrDefault();

                var word = (from w in dbConnection.Word
                            where w.TestId == currentTestId
                            select new
                            {
                                 w.Id,
                                 w.TestId,
                                 w.Word1,
                                 w.Word2
                             });

                if (selectedTest != null && word != null)
                {
                    numberOfWords = word.Count();

                    int a = 0;
                    mainLangArr = new string[numberOfWords];
                    secLangArr = new string[numberOfWords];

                    //Debug.WriteLine(numberOfWords.ToString(), mainLangArr.Count(), secLangArr.Count());
                    //Debug.WriteLine(selectedTest.Name.ToString(), cb.ToString());
                    foreach (var item in word)
                    {
                        mainLangArr[a] = item.Word1;
                        secLangArr[a] = item.Word2;
                        a++;
                        //Debug.WriteLine(item.TestId.ToString() + item.Word1 + item.Word2);    
                    }

                    loadPanel();
                }
            }
        }
        private void loadPanel()
        {
            tblPanel.Visible = true;
            Label quantity = new Label();
            
            //Creates a new button and creates a new eventhandler.
            Button btnSave = new Button();
            btnSave.Text = "Save";
            btnSave.Click += new EventHandler(btnSave_Click);

            tblPanel.ColumnCount = 3;
            tblPanel.RowCount = 1;

            tblPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
            tblPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
            tblPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40));
            tblPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 30));

            tblPanel.Controls.Add(btnSave, 0, 0);

            tblPanel.Controls.Add(new Label() { Text = mainLang }, 1, 0);
            tblPanel.Controls.Add(new Label() { Text = secLang }, 2, 0);

            //Fills the textboxes with words from database.
            for (int i = 0; i < numberOfWords; i++)
            {
                TextBox txtMainLang = new TextBox();
                TextBox txtSecLang = new TextBox();

                txtMainLang.Name = "txtMainLang " + i.ToString();
                txtSecLang.Name = "txtSecLang " + i.ToString();

                txtMainLang.Text = mainLangArr[i].ToString();
                txtSecLang.Text = secLangArr[i].ToString();

                tblPanel.RowCount = tblPanel.RowCount + 1;
                tblPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize, 30));
                tblPanel.Controls.Add(new Label() { Text = "Word " + (i + 1) }, 0, tblPanel.RowCount - 1);

                tblPanel.Controls.Add(txtMainLang, 1, tblPanel.RowCount - 1);
                tblPanel.Controls.Add(txtSecLang, 2, tblPanel.RowCount - 1);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            int x = 0;
            int y = 0;
            string[] mainLangArrToDb = new string[numberOfWords];
            string[] secLangArrToDb = new string[numberOfWords];

            //Sorts all textbox objects to a variabel. 
            var sortedTxtBoxes = tblPanel.Controls.OfType<TextBox>().OrderBy(ctrl => ctrl.TabIndex).ToList();

            if (sortedTxtBoxes != null)
            {
                //Loops through all textboxes.
                foreach (var item in sortedTxtBoxes)
                {
                    if (item.Name.Contains("txtMainLang"))
                    {
                        mainLangArrToDb[x] = item.Text;
                        x++;
                    }
                    else if (item.Name.Contains("txtSecLang"))
                    {
                        secLangArrToDb[y] = item.Text;
                        y++;
                    }
                }
            }

            try
            {
                using (GlossaryAdminModel dbConnection = new GlossaryAdminModel())
                {
                    int p = 0;
                    List<Word> wordResult = (from w in dbConnection.Word
                                             where w.TestId == currentTestId
                                             select w).ToList();

                    if (wordResult != null)
                    {
                        foreach (Word item in wordResult)
                        {
                            item.Word1 = mainLangArrToDb[p];
                            item.Word2 = secLangArrToDb[p];
                            p++;
                        }

                        dbConnection.SaveChanges();
                        MessageBox.Show("Successfully saved changes");
                    }          
                }
            }
            catch (EntityException ex)
            {
                MessageBox.Show("Could not save the test to database." + ex.Message);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error when saving to Database." + ex.Message + ex.InnerException);
            }

            finally
            {
                Close();
            }

        }
    }
}
