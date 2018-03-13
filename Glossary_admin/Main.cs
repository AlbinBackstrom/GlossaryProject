using Glossary_Admin.Testforms;
using Glossary_Admin.Userforms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core;
using System.Drawing;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Glossary_Admin
{
    public partial class Main : Form
    {
        //New instance of the service.
        FileLogic.Main myFileMover = new FileLogic.Main();

        public Main()
        {
            InitializeComponent();
            getNumbers();
            myFileMover.Start();
        }

        //Populates the main window with data from the database.
        private void getNumbers()
        {
            try
            {
                using (GlossaryAdminModel dbConnection = new GlossaryAdminModel())
                {
                    // Get number of users here
                    int countUsers = (from u in dbConnection.User
                                      select u).Count();
                    lblNumberOfUserstxt.Text = countUsers.ToString();

                    //Get numbers of admins
                    int countAdmins = (from u in dbConnection.User
                                       where u.RoleId == 1
                                       select u).Count();
                    lblNumberOfAdminstxt.Text = countAdmins.ToString();

                    //Get number of tests
                    int countTests = (from u in dbConnection.Test
                                      select u).Count();
                    lblNumberOfTeststxt.Text = countTests.ToString();
                }
            }
            catch (EntityException ex)
            {
                MessageBox.Show("Could not load data from database." + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error when loading from Database." + ex.Message + ex.InnerException);
            }
        }

        //When pressing menuItem System
        private void SystemExit_Click(object sender, EventArgs e)
        {
            LoggedInUser.UserId = 0;
            Application.Exit();     
        }

        private void SystemLogout_Click(object sender, EventArgs e)
        {
            LoggedInUser.UserId = 0;
            Application.Restart();
        }

        //When pressing menuItem Users
        //Delete button not enabled in the program. 
        private void addUser_Click(object sender, EventArgs e)
        {
            AddUser newuser = new AddUser();

            newuser.ShowDialog();
        }

        private void editUser_Click(object sender, EventArgs e)
        {
            EditUser edituser = new EditUser();

            edituser.ShowDialog();
        }

        private void deleteUser_Click(object sender, EventArgs e)
        {
            //BUTTON NOT ENABLED
            DeleteUser deleteuser = new DeleteUser();
            deleteuser.ShowDialog();
        }

        private void showAllUsers_Click(object sender, EventArgs e)
        {
            AllUsers allusers = new AllUsers();
            allusers.ShowDialog();
        }

        //When pressing menuItem Tests
        //Delete button not enabled in the program. 
        private void deleteTest_Click(object sender, EventArgs e)
        {
           //BUTTON NOT ENABLED
            DeleteTest deletetest = new DeleteTest();
            deletetest.ShowDialog();
        }

        private void editTest_Click(object sender, EventArgs e)
        {
            EditTest edittest = new EditTest();

            edittest.ShowDialog();
        }

        private void newTest_Click(object sender, EventArgs e)
        {
            CreateTest createtest = new CreateTest();

            createtest.ShowDialog();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            myFileMover.Stop();
        }   
    }
}
