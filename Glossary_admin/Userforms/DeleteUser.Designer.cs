namespace Glossary_Admin
{
    partial class DeleteUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblUserID = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblNoSuchUser = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbDeleteUser = new System.Windows.Forms.CheckBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblEmailtxt = new System.Windows.Forms.Label();
            this.lblLastnametxt = new System.Windows.Forms.Label();
            this.lblFirstnametxt = new System.Windows.Forms.Label();
            this.lblUsernametxt = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblLastname = new System.Windows.Forms.Label();
            this.lblFirstname = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Location = new System.Drawing.Point(13, 33);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(73, 17);
            this.lblUserID.TabIndex = 0;
            this.lblUserID.Text = "Username";
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(92, 30);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(100, 22);
            this.txtUserID.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(169, 202);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(16, 202);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblNoSuchUser
            // 
            this.lblNoSuchUser.AutoSize = true;
            this.lblNoSuchUser.Location = new System.Drawing.Point(92, 111);
            this.lblNoSuchUser.Name = "lblNoSuchUser";
            this.lblNoSuchUser.Size = new System.Drawing.Size(92, 17);
            this.lblNoSuchUser.TabIndex = 4;
            this.lblNoSuchUser.Text = "No such user";
            this.lblNoSuchUser.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbDeleteUser);
            this.panel1.Controls.Add(this.btnPrevious);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.lblEmailtxt);
            this.panel1.Controls.Add(this.lblLastnametxt);
            this.panel1.Controls.Add(this.lblFirstnametxt);
            this.panel1.Controls.Add(this.lblUsernametxt);
            this.panel1.Controls.Add(this.lblEmail);
            this.panel1.Controls.Add(this.lblLastname);
            this.panel1.Controls.Add(this.lblFirstname);
            this.panel1.Controls.Add(this.lblUsername);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 295);
            this.panel1.TabIndex = 5;
            this.panel1.Visible = false;
            // 
            // cbDeleteUser
            // 
            this.cbDeleteUser.AutoSize = true;
            this.cbDeleteUser.Location = new System.Drawing.Point(16, 175);
            this.cbDeleteUser.Name = "cbDeleteUser";
            this.cbDeleteUser.Size = new System.Drawing.Size(233, 21);
            this.cbDeleteUser.TabIndex = 10;
            this.cbDeleteUser.Text = "Do you want to delete this user?";
            this.cbDeleteUser.UseVisualStyleBackColor = true;
            this.cbDeleteUser.CheckedChanged += new System.EventHandler(this.cbDeleteUser_CheckedChanged);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(19, 231);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 9;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(169, 231);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblEmailtxt
            // 
            this.lblEmailtxt.AutoSize = true;
            this.lblEmailtxt.Location = new System.Drawing.Point(92, 128);
            this.lblEmailtxt.Name = "lblEmailtxt";
            this.lblEmailtxt.Size = new System.Drawing.Size(0, 17);
            this.lblEmailtxt.TabIndex = 7;
            // 
            // lblLastnametxt
            // 
            this.lblLastnametxt.AutoSize = true;
            this.lblLastnametxt.Location = new System.Drawing.Point(92, 94);
            this.lblLastnametxt.Name = "lblLastnametxt";
            this.lblLastnametxt.Size = new System.Drawing.Size(0, 17);
            this.lblLastnametxt.TabIndex = 6;
            // 
            // lblFirstnametxt
            // 
            this.lblFirstnametxt.AutoSize = true;
            this.lblFirstnametxt.Location = new System.Drawing.Point(92, 60);
            this.lblFirstnametxt.Name = "lblFirstnametxt";
            this.lblFirstnametxt.Size = new System.Drawing.Size(0, 17);
            this.lblFirstnametxt.TabIndex = 5;
            // 
            // lblUsernametxt
            // 
            this.lblUsernametxt.AutoSize = true;
            this.lblUsernametxt.Location = new System.Drawing.Point(92, 33);
            this.lblUsernametxt.Name = "lblUsernametxt";
            this.lblUsernametxt.Size = new System.Drawing.Size(0, 17);
            this.lblUsernametxt.TabIndex = 4;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(16, 125);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(46, 17);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email:";
            // 
            // lblLastname
            // 
            this.lblLastname.AutoSize = true;
            this.lblLastname.Location = new System.Drawing.Point(16, 94);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(74, 17);
            this.lblLastname.TabIndex = 2;
            this.lblLastname.Text = "Lastname:";
            // 
            // lblFirstname
            // 
            this.lblFirstname.AutoSize = true;
            this.lblFirstname.Location = new System.Drawing.Point(16, 60);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(74, 17);
            this.lblFirstname.TabIndex = 1;
            this.lblFirstname.Text = "Firstname:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(16, 33);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(77, 17);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username:";
            // 
            // DeleteUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 295);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblNoSuchUser);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.lblUserID);
            this.Name = "DeleteUser";
            this.Text = "Delete user";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblNoSuchUser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox cbDeleteUser;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblEmailtxt;
        private System.Windows.Forms.Label lblLastnametxt;
        private System.Windows.Forms.Label lblFirstnametxt;
        private System.Windows.Forms.Label lblUsernametxt;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblLastname;
        private System.Windows.Forms.Label lblFirstname;
        private System.Windows.Forms.Label lblUsername;
    }
}