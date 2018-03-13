using Glossary_Admin;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace Glossary_Admin.Testforms
{
    public partial class CreateTest : Form
    {
        int n;
        int currentTestId;
        List<string> MainList = new List<string>();
        List<string> SecList = new List<string>();

        public CreateTest()
        {
            InitializeComponent();
            CreateTest_OnLoad();
        }

        private void CreateTest_OnLoad()
        {
            try
            {
                using (GlossaryAdminModel dbConnection = new GlossaryAdminModel())
                {
                    cBMainLang.DataSource = dbConnection.Languages.ToList();
                    cBMainLang.DisplayMember = "MainLang";
                    cBSecLang.DataSource = dbConnection.Languages.ToList();
                    cBSecLang.DisplayMember = "SecLang";
                    cBMainLang.Invalidate();
                    cBSecLang.Invalidate();
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

        public void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
               using (GlossaryAdminModel dbConnection = new GlossaryAdminModel())
                {
                    var newTest = new Test();
                    newTest.Name = txtNameOfTest.Text;
                    newTest.Date = DateTime.Now;
                    newTest.MainLang = cBMainLang.SelectedIndex + 1;
                    newTest.SecLang = cBSecLang.SelectedIndex + 1;
                    newTest.UserId = LoggedInUser.UserId;
                    newTest.StatusId = 0;

                    dbConnection.Test.Add(newTest);
                    dbConnection.SaveChanges();

                    currentTestId = newTest.Id;
                }
                loadPanel();
            }
            catch (EntityException ex)
            {
                MessageBox.Show("Could not add the test to database." + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error when adding to Database." + ex.Message + ex.InnerException);
            }
        }

        private void loadPanel()
        {
            //Converts the value from the numericbox to an int.
            n = Convert.ToInt32(Math.Round(numNumberOfWords.Value, 0));
            panel.Visible = true;

            Label quantity = new Label();

            Button btnSave = new Button();
            btnSave.Text = "Save";
            btnSave.Click += new EventHandler(btnSave_Click);

            panel.ColumnCount = 3;
            panel.RowCount = 1;

            panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
            panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
            panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40));
            panel.RowStyles.Add(new RowStyle(SizeType.Percent, 30));

            panel.Controls.Add(btnSave, 0, 0);
            panel.Controls.Add(new Label() { Text = cBMainLang.GetItemText(cBMainLang.SelectedItem) }, 1, 0);
            panel.Controls.Add(new Label() { Text = cBSecLang.GetItemText(cBSecLang.SelectedItem) }, 2, 0);

            for (int i = 0; i < n; i++)
            {
                TextBox txtMainLang = new TextBox();
                TextBox txtSecLang = new TextBox();

                txtMainLang.Name = "txtMainLang " + i.ToString();
                txtSecLang.Name = "txtSecLang " + i.ToString();

                panel.RowCount = panel.RowCount + 1;
                panel.RowStyles.Add(new RowStyle(SizeType.AutoSize, 30));
                panel.Controls.Add(new Label() { Text = "Word " + (i + 1) }, 0, panel.RowCount - 1);

                panel.Controls.Add(txtMainLang, 1, panel.RowCount - 1);
                panel.Controls.Add(txtSecLang, 2, panel.RowCount - 1);
            }
        }

         void btnSave_Click(object sender, EventArgs e)
        {
            int a = 0;
            int b = 0;
            string[] mainLangArr = new string[n];
            string[] secLangArr = new string[n];
            var sortedTxtBoxes = panel.Controls.OfType<TextBox>().OrderBy(ctrl => ctrl.TabIndex).ToList();

            foreach (var item in sortedTxtBoxes)
            {
                if (item.Name.Contains("txtMainLang"))
                {
                    mainLangArr[a] = item.Text;
                    //Debug.WriteLine("First ",a.ToString());
                    a++;
                }

                else if (item.Name.Contains("txtSecLang"))
                {
                    secLangArr[b] = item.Text;
                   // Debug.WriteLine("Second ", b.ToString());                
                    b++;
                }
            }

            try
            {
                using (GlossaryAdminModel dbConnection = new GlossaryAdminModel())
                {
                    for (int i = 0; i < n; i++)
                    {
                        var newWord = new Word();
                        newWord.TestId = currentTestId;
                        newWord.Word1 = mainLangArr[i];
                        newWord.Word2 = secLangArr[i];
                        dbConnection.Word.Add(newWord);
                    }
                    dbConnection.SaveChanges();
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
