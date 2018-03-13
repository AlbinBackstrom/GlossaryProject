using System;
using System.Data;
using System.Data.Entity.Core;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Glossary_Admin
{
    public partial class Login : Form
    {  
        public Login()
        {
            InitializeComponent();        
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Disables the login button to prevent several requests.
            btnLogin.Enabled = false;
            var hashedPassword = Hash.sha256(txtPassword.Text);

            try
            {
                using (GlossaryAdminModel dbConnection = new GlossaryAdminModel())
                {
                    //Selecting the user with the given credentials.
                    var user = (from u in dbConnection.User
                                where u.Username == txtUsername.Text.ToString() &&
                                u.RoleId.Equals(1) &&
                                u.Password == hashedPassword
                                select u).FirstOrDefault();

                    //If the user is an Admin (Role no. 1) and the right credentials are given.
                    //Saves the users Id for usage further more. 
                    if (user != null)
                    {
                        DialogResult = DialogResult.OK;
                        LoggedInUser.UserId = user.Id;
                    }

                    //If the user is a regular user (Role no. 0) and the right credentials are given.
                    if (user != null && user.RoleId.Equals(0))
                    {
                        lblNotAdmin.Visible = true;
                        lblWrongCredentials.Visible = false;
                        clearAllFields();
                    }

                    //If there's not an user with the given credentials.
                    else
                    {
                        lblNotAdmin.Visible = false;
                        lblWrongCredentials.Visible = true;
                        clearAllFields();
                    }
                }
            }

            catch (EntityException ex)
            {
                MessageBox.Show("Could not load userinfo from database." + ex.Message);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error when loading from database." + ex.Message + ex.InnerException);
            }
        }
 
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clearAllFields()
        {
            //Enables the login button, empties the txtboxes.
            btnLogin.Enabled = true;
            txtUsername.Text = "";
            txtPassword.Text = "";
        }
    }
}
