using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Glossary_Admin
{
    public partial class DeleteUser : Form
    {
        int UserId;

        public DeleteUser()
        {
            InitializeComponent();


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            using (GlossaryAdminModel dbConnection = new GlossaryAdminModel())
            {

                var usernameSearch = (from u in dbConnection.User
                                      where u.Username.Equals(txtUserID.Text.ToString())
                                      select u).FirstOrDefault();


                if (usernameSearch != null)
                {
                    UserId = usernameSearch.Id;

                    lblUsernametxt.Text = usernameSearch.Username;
                    lblFirstnametxt.Text = usernameSearch.Firstname;
                    lblLastnametxt.Text = usernameSearch.Lastname;
                    lblEmailtxt.Text = usernameSearch.Email;

                    lblNoSuchUser.Visible = false;
                    panel1.Visible = true;
                }

                else
                {
                    lblNoSuchUser.Visible = true;
                }
            }
        }

        private void cbDeleteUser_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDeleteUser.Checked)
            {
                btnDelete.Enabled = true;
            }

            else
            {
                btnDelete.Enabled = false;
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            cbDeleteUser.Checked = false;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (GlossaryAdminModel dbConnection = new GlossaryAdminModel())
            {
                var selectedUser = (from u in dbConnection.User
                                    where u.Id == UserId
                                    select u).FirstOrDefault();

                if (selectedUser!= null)
                {
                    dbConnection.User.Remove(selectedUser);
                    dbConnection.SaveChanges();
                }
            }

            panel1.Visible = false;
        }
    }
}
