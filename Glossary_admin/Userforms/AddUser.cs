using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Glossary_Admin
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
           Close();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Save things to DB and give a success message!   
            var hashedPassword = Hash.sha256(txtPassword.Text);

            try
            {
                using (GlossaryAdminModel dbConnection = new GlossaryAdminModel())
                {
                    var newUser = new User();
                    newUser.Username = txtUsername.Text.ToString();
                    newUser.Password = hashedPassword;
                    newUser.RoleId = cmbRole.SelectedIndex;
                    newUser.Firstname = txtFirstname.Text.ToString();
                    newUser.Lastname = txtLastname.Text.ToString();
                    newUser.Email = txtEmail.Text.ToString();

                    dbConnection.User.Add(newUser);
                    dbConnection.SaveChanges();
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

            finally
            {
                Close();

            }
        }
    }
}

