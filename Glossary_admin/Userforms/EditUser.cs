using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Glossary_Admin
{
    public partial class EditUser : Form
    {
        int UserId;
        public EditUser()
        {
            InitializeComponent();
        }
        public void btnSearch_Click(object sender, EventArgs e)
        {

            try
            {
                using (GlossaryAdminModel dbConnection = new GlossaryAdminModel())
                {
                    var usernameSearch = (from u in dbConnection.User
                                          where u.Username.Equals(txtSearchUsername.Text.ToString())
                                          select u).FirstOrDefault();

                    if (usernameSearch != null)
                    {
                        UserId = usernameSearch.Id;
                        txtUsername.Text = usernameSearch.Username;
                        txtFirstname.Text = usernameSearch.Firstname;
                        txtLastname.Text = usernameSearch.Lastname;
                        txtEmail.Text = usernameSearch.Email;
                        cbRole.SelectedIndex = usernameSearch.RoleId;

                        lblNoSuchUsername.Visible = false;
                        panel1.Visible = true;
                    }

                    if (usernameSearch == null)
                    {
                        lblNoSuchUsername.Visible = true;
                        txtSearchUsername.Text = "";
                    }
                }
            }

            catch (EntityException ex)
            {
                MessageBox.Show("Could not search the database for the requested username." + ex.Message);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error when searching database." + ex.Message + ex.InnerException);
            }
        }
        public void btnSave_Click(object sender, EventArgs e)
        {
           try
            {
                using (GlossaryAdminModel dbConnection = new GlossaryAdminModel())
                {
                    var selectedUser = (from u in dbConnection.User
                                        where u.Id == UserId
                                        select u).FirstOrDefault();

                    if (selectedUser != null)
                    {
                        selectedUser.Username = txtUsername.Text;
                        selectedUser.Firstname = txtFirstname.Text;
                        selectedUser.Lastname = txtLastname.Text;
                        selectedUser.Email = txtEmail.Text;
                        selectedUser.RoleId = cbRole.SelectedIndex;

                        dbConnection.SaveChanges();
                    }
                }
            }
            catch (EntityException ex)
            {
                MessageBox.Show("Could not save the user to database." + ex.Message);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error when saving to Database." + ex.Message + ex.InnerException);
            }

            finally
            {
                showFirstPage();
            }   
}
        private void btnNewSearch_Click(object sender, EventArgs e)
        {
            showFirstPage();
        }
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            showFirstPage();
        }
        private void btnCancelSearch_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void showFirstPage()
        {
            panel1.Visible = false;
            txtSearchUsername.Text = "";

        }
    }
}
