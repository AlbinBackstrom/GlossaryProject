namespace Glossary_Admin.Testforms
{
    partial class CreateTest
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
            this.components = new System.ComponentModel.Container();
            this.lblNameOfTest = new System.Windows.Forms.Label();
            this.txtNameOfTest = new System.Windows.Forms.TextBox();
            this.numNumberOfWords = new System.Windows.Forms.NumericUpDown();
            this.lblNumberOfWords = new System.Windows.Forms.Label();
            this.btnCreateFields = new System.Windows.Forms.Button();
            this.lblLanguage1 = new System.Windows.Forms.Label();
            this.lblLanguage2 = new System.Windows.Forms.Label();
            this.cBMainLang = new System.Windows.Forms.ComboBox();
            this.languagesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cBSecLang = new System.Windows.Forms.ComboBox();
            this.panel = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.numNumberOfWords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.languagesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNameOfTest
            // 
            this.lblNameOfTest.AutoSize = true;
            this.lblNameOfTest.Location = new System.Drawing.Point(9, 7);
            this.lblNameOfTest.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNameOfTest.Name = "lblNameOfTest";
            this.lblNameOfTest.Size = new System.Drawing.Size(41, 13);
            this.lblNameOfTest.TabIndex = 1;
            this.lblNameOfTest.Text = "Name: ";
            // 
            // txtNameOfTest
            // 
            this.txtNameOfTest.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNameOfTest.Location = new System.Drawing.Point(56, 5);
            this.txtNameOfTest.Margin = new System.Windows.Forms.Padding(2);
            this.txtNameOfTest.Name = "txtNameOfTest";
            this.txtNameOfTest.Size = new System.Drawing.Size(162, 20);
            this.txtNameOfTest.TabIndex = 2;
            // 
            // numNumberOfWords
            // 
            this.numNumberOfWords.Location = new System.Drawing.Point(125, 36);
            this.numNumberOfWords.Margin = new System.Windows.Forms.Padding(2);
            this.numNumberOfWords.Name = "numNumberOfWords";
            this.numNumberOfWords.Size = new System.Drawing.Size(91, 20);
            this.numNumberOfWords.TabIndex = 3;
            this.numNumberOfWords.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numNumberOfWords.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // lblNumberOfWords
            // 
            this.lblNumberOfWords.AutoSize = true;
            this.lblNumberOfWords.Location = new System.Drawing.Point(9, 36);
            this.lblNumberOfWords.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumberOfWords.Name = "lblNumberOfWords";
            this.lblNumberOfWords.Size = new System.Drawing.Size(93, 13);
            this.lblNumberOfWords.TabIndex = 4;
            this.lblNumberOfWords.Text = "Number of words: ";
            // 
            // btnCreateFields
            // 
            this.btnCreateFields.Location = new System.Drawing.Point(67, 188);
            this.btnCreateFields.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateFields.Name = "btnCreateFields";
            this.btnCreateFields.Size = new System.Drawing.Size(106, 19);
            this.btnCreateFields.TabIndex = 5;
            this.btnCreateFields.Text = "Create fields";
            this.btnCreateFields.UseVisualStyleBackColor = true;
            this.btnCreateFields.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lblLanguage1
            // 
            this.lblLanguage1.AutoSize = true;
            this.lblLanguage1.Location = new System.Drawing.Point(9, 70);
            this.lblLanguage1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLanguage1.Name = "lblLanguage1";
            this.lblLanguage1.Size = new System.Drawing.Size(84, 13);
            this.lblLanguage1.TabIndex = 0;
            this.lblLanguage1.Text = "Main Language:";
            // 
            // lblLanguage2
            // 
            this.lblLanguage2.AutoSize = true;
            this.lblLanguage2.Location = new System.Drawing.Point(9, 100);
            this.lblLanguage2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLanguage2.Name = "lblLanguage2";
            this.lblLanguage2.Size = new System.Drawing.Size(112, 13);
            this.lblLanguage2.TabIndex = 1;
            this.lblLanguage2.Text = "Secondary Language:";
            // 
            // cBMainLang
            // 
            this.cBMainLang.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.languagesBindingSource, "Language", true));
            this.cBMainLang.DataSource = this.languagesBindingSource;
            this.cBMainLang.DisplayMember = "Language";
            this.cBMainLang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBMainLang.FormattingEnabled = true;
            this.cBMainLang.Location = new System.Drawing.Point(125, 67);
            this.cBMainLang.Margin = new System.Windows.Forms.Padding(2);
            this.cBMainLang.Name = "cBMainLang";
            this.cBMainLang.Size = new System.Drawing.Size(92, 21);
            this.cBMainLang.TabIndex = 6;
            this.cBMainLang.ValueMember = "Id";
            // 
            // languagesBindingSource
            // 
            this.languagesBindingSource.DataSource = typeof(Glossary_Admin.Languages);
            // 
            // cBSecLang
            // 
            this.cBSecLang.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.languagesBindingSource, "Id", true));
            this.cBSecLang.DataSource = this.languagesBindingSource;
            this.cBSecLang.DisplayMember = "Language";
            this.cBSecLang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBSecLang.FormattingEnabled = true;
            this.cBSecLang.Location = new System.Drawing.Point(125, 97);
            this.cBSecLang.Margin = new System.Windows.Forms.Padding(2);
            this.cBSecLang.Name = "cBSecLang";
            this.cBSecLang.Size = new System.Drawing.Size(92, 21);
            this.cBSecLang.TabIndex = 7;
            this.cBSecLang.ValueMember = "Id";
            // 
            // panel
            // 
            this.panel.AutoScroll = true;
            this.panel.AutoSize = true;
            this.panel.ColumnCount = 2;
            this.panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Margin = new System.Windows.Forms.Padding(2);
            this.panel.Name = "panel";
            this.panel.RowCount = 2;
            this.panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panel.Size = new System.Drawing.Size(334, 566);
            this.panel.TabIndex = 8;
            this.panel.Visible = false;
            // 
            // CreateTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(334, 566);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.cBSecLang);
            this.Controls.Add(this.cBMainLang);
            this.Controls.Add(this.lblLanguage2);
            this.Controls.Add(this.btnCreateFields);
            this.Controls.Add(this.lblLanguage1);
            this.Controls.Add(this.lblNumberOfWords);
            this.Controls.Add(this.numNumberOfWords);
            this.Controls.Add(this.txtNameOfTest);
            this.Controls.Add(this.lblNameOfTest);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CreateTest";
            this.Text = "Create a new test";
            ((System.ComponentModel.ISupportInitialize)(this.numNumberOfWords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.languagesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNameOfTest;
        private System.Windows.Forms.TextBox txtNameOfTest;
        private System.Windows.Forms.NumericUpDown numNumberOfWords;
        private System.Windows.Forms.Label lblNumberOfWords;
        private System.Windows.Forms.Button btnCreateFields;
        private System.Windows.Forms.Label lblLanguage1;
        private System.Windows.Forms.Label lblLanguage2;
        private System.Windows.Forms.ComboBox cBMainLang;
        private System.Windows.Forms.ComboBox cBSecLang;
        private System.Windows.Forms.BindingSource languagesBindingSource;
        private System.Windows.Forms.TableLayoutPanel panel;
    }
}