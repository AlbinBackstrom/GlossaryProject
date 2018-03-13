namespace Glossary_Admin
{
    partial class Main
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.SystemLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.SystemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gBStatistics = new System.Windows.Forms.GroupBox();
            this.lblNumberOfAdminstxt = new System.Windows.Forms.Label();
            this.lblNumberOfAdmins = new System.Windows.Forms.Label();
            this.lblNumberOfTeststxt = new System.Windows.Forms.Label();
            this.lblNumberOfTests = new System.Windows.Forms.Label();
            this.lblNumberOfUserstxt = new System.Windows.Forms.Label();
            this.lblNumberOfUsers = new System.Windows.Forms.Label();
            this.gBThread = new System.Windows.Forms.GroupBox();
            this.menuStrip2.SuspendLayout();
            this.gBStatistics.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.usersToolStripMenuItem,
            this.toolStripMenuItem2});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(918, 24);
            this.menuStrip2.TabIndex = 0;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SystemLogout,
            this.SystemExit});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(57, 20);
            this.toolStripMenuItem1.Text = "System";
            // 
            // SystemLogout
            // 
            this.SystemLogout.Name = "SystemLogout";
            this.SystemLogout.Size = new System.Drawing.Size(152, 22);
            this.SystemLogout.Text = "Logout";
            this.SystemLogout.Click += new System.EventHandler(this.SystemLogout_Click);
            // 
            // SystemExit
            // 
            this.SystemExit.Name = "SystemExit";
            this.SystemExit.Size = new System.Drawing.Size(152, 22);
            this.SystemExit.Text = "Exit";
            this.SystemExit.Click += new System.EventHandler(this.SystemExit_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.editToolStripMenuItem,
            this.showAllToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.usersToolStripMenuItem.Text = "Users";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.addUser_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editUser_Click);
            // 
            // showAllToolStripMenuItem
            // 
            this.showAllToolStripMenuItem.Enabled = false;
            this.showAllToolStripMenuItem.Name = "showAllToolStripMenuItem";
            this.showAllToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.showAllToolStripMenuItem.Text = "Show all";
            this.showAllToolStripMenuItem.Click += new System.EventHandler(this.showAllUsers_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Enabled = false;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteUser_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem1,
            this.editToolStripMenuItem1,
            this.deleteToolStripMenuItem1});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(45, 20);
            this.toolStripMenuItem2.Text = "Tests";
            // 
            // newToolStripMenuItem1
            // 
            this.newToolStripMenuItem1.Name = "newToolStripMenuItem1";
            this.newToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem1.Text = "New";
            this.newToolStripMenuItem1.Click += new System.EventHandler(this.newTest_Click);
            // 
            // editToolStripMenuItem1
            // 
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            this.editToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.editToolStripMenuItem1.Text = "Edit";
            this.editToolStripMenuItem1.Click += new System.EventHandler(this.editTest_Click);
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.Enabled = false;
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.deleteToolStripMenuItem1.Text = "Delete";
            this.deleteToolStripMenuItem1.Click += new System.EventHandler(this.deleteTest_Click);
            // 
            // gBStatistics
            // 
            this.gBStatistics.Controls.Add(this.lblNumberOfAdminstxt);
            this.gBStatistics.Controls.Add(this.lblNumberOfAdmins);
            this.gBStatistics.Controls.Add(this.lblNumberOfTeststxt);
            this.gBStatistics.Controls.Add(this.lblNumberOfTests);
            this.gBStatistics.Controls.Add(this.lblNumberOfUserstxt);
            this.gBStatistics.Controls.Add(this.lblNumberOfUsers);
            this.gBStatistics.Location = new System.Drawing.Point(585, 27);
            this.gBStatistics.Name = "gBStatistics";
            this.gBStatistics.Size = new System.Drawing.Size(321, 137);
            this.gBStatistics.TabIndex = 2;
            this.gBStatistics.TabStop = false;
            this.gBStatistics.Text = "Statistics";
            // 
            // lblNumberOfAdminstxt
            // 
            this.lblNumberOfAdminstxt.AutoSize = true;
            this.lblNumberOfAdminstxt.Location = new System.Drawing.Point(187, 66);
            this.lblNumberOfAdminstxt.Name = "lblNumberOfAdminstxt";
            this.lblNumberOfAdminstxt.Size = new System.Drawing.Size(73, 13);
            this.lblNumberOfAdminstxt.TabIndex = 7;
            this.lblNumberOfAdminstxt.Text = "Numbers here";
            // 
            // lblNumberOfAdmins
            // 
            this.lblNumberOfAdmins.AutoSize = true;
            this.lblNumberOfAdmins.Location = new System.Drawing.Point(6, 66);
            this.lblNumberOfAdmins.Name = "lblNumberOfAdmins";
            this.lblNumberOfAdmins.Size = new System.Drawing.Size(95, 13);
            this.lblNumberOfAdmins.TabIndex = 6;
            this.lblNumberOfAdmins.Text = "Number of admins:";
            // 
            // lblNumberOfTeststxt
            // 
            this.lblNumberOfTeststxt.AutoSize = true;
            this.lblNumberOfTeststxt.Location = new System.Drawing.Point(187, 104);
            this.lblNumberOfTeststxt.Name = "lblNumberOfTeststxt";
            this.lblNumberOfTeststxt.Size = new System.Drawing.Size(73, 13);
            this.lblNumberOfTeststxt.TabIndex = 5;
            this.lblNumberOfTeststxt.Text = "Numbers here";
            // 
            // lblNumberOfTests
            // 
            this.lblNumberOfTests.AutoSize = true;
            this.lblNumberOfTests.Location = new System.Drawing.Point(6, 104);
            this.lblNumberOfTests.Name = "lblNumberOfTests";
            this.lblNumberOfTests.Size = new System.Drawing.Size(84, 13);
            this.lblNumberOfTests.TabIndex = 4;
            this.lblNumberOfTests.Text = "Number of tests:";
            // 
            // lblNumberOfUserstxt
            // 
            this.lblNumberOfUserstxt.AutoSize = true;
            this.lblNumberOfUserstxt.Location = new System.Drawing.Point(187, 33);
            this.lblNumberOfUserstxt.Name = "lblNumberOfUserstxt";
            this.lblNumberOfUserstxt.Size = new System.Drawing.Size(73, 13);
            this.lblNumberOfUserstxt.TabIndex = 1;
            this.lblNumberOfUserstxt.Text = "Numbers here";
            // 
            // lblNumberOfUsers
            // 
            this.lblNumberOfUsers.AutoSize = true;
            this.lblNumberOfUsers.Location = new System.Drawing.Point(6, 33);
            this.lblNumberOfUsers.Name = "lblNumberOfUsers";
            this.lblNumberOfUsers.Size = new System.Drawing.Size(87, 13);
            this.lblNumberOfUsers.TabIndex = 0;
            this.lblNumberOfUsers.Text = "Number of users:";
            // 
            // gBThread
            // 
            this.gBThread.Location = new System.Drawing.Point(585, 195);
            this.gBThread.Name = "gBThread";
            this.gBThread.Size = new System.Drawing.Size(321, 149);
            this.gBThread.TabIndex = 3;
            this.gBThread.TabStop = false;
            this.gBThread.Text = "Service";
            // 
            // Main
            // 
            this.ClientSize = new System.Drawing.Size(918, 566);
            this.Controls.Add(this.gBThread);
            this.Controls.Add(this.gBStatistics);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip2;
            this.Name = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.gBStatistics.ResumeLayout(false);
            this.gBStatistics.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem SystemExit;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
        private System.Windows.Forms.GroupBox gBStatistics;
        private System.Windows.Forms.Label lblNumberOfAdminstxt;
        private System.Windows.Forms.Label lblNumberOfAdmins;
        private System.Windows.Forms.Label lblNumberOfTeststxt;
        private System.Windows.Forms.Label lblNumberOfTests;
        private System.Windows.Forms.Label lblNumberOfUserstxt;
        private System.Windows.Forms.Label lblNumberOfUsers;
        private System.Windows.Forms.ToolStripMenuItem showAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SystemLogout;
        private System.Windows.Forms.GroupBox gBThread;
    }
}

