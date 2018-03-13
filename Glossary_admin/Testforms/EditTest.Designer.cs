namespace Glossary_Admin.Testforms
{
    partial class EditTest
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
            this.btnLoadTest = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTestIdAndName = new System.Windows.Forms.ComboBox();
            this.testBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblPanel = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.testBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoadTest
            // 
            this.btnLoadTest.Location = new System.Drawing.Point(17, 120);
            this.btnLoadTest.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLoadTest.Name = "btnLoadTest";
            this.btnLoadTest.Size = new System.Drawing.Size(84, 29);
            this.btnLoadTest.TabIndex = 0;
            this.btnLoadTest.Text = "Load test";
            this.btnLoadTest.UseVisualStyleBackColor = true;
            this.btnLoadTest.Click += new System.EventHandler(this.btnLoadTest_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose test: ";
            // 
            // cbTestIdAndName
            // 
            this.cbTestIdAndName.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.testBindingSource, "Id", true));
            this.cbTestIdAndName.DataSource = this.testBindingSource;
            this.cbTestIdAndName.DisplayMember = "Id";
            this.cbTestIdAndName.FormattingEnabled = true;
            this.cbTestIdAndName.Location = new System.Drawing.Point(159, 36);
            this.cbTestIdAndName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbTestIdAndName.Name = "cbTestIdAndName";
            this.cbTestIdAndName.Size = new System.Drawing.Size(213, 28);
            this.cbTestIdAndName.TabIndex = 2;
            this.cbTestIdAndName.ValueMember = "Id";
            this.cbTestIdAndName.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.IdAndNameFormat);
            // 
            // testBindingSource
            // 
            this.testBindingSource.DataSource = typeof(Glossary_Admin.Test);
            // 
            // tblPanel
            // 
            this.tblPanel.ColumnCount = 2;
            this.tblPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblPanel.Location = new System.Drawing.Point(0, 0);
            this.tblPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tblPanel.Name = "tblPanel";
            this.tblPanel.RowCount = 2;
            this.tblPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPanel.Size = new System.Drawing.Size(413, 969);
            this.tblPanel.TabIndex = 2;
            this.tblPanel.Visible = false;
            // 
            // EditTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 969);
            this.Controls.Add(this.tblPanel);
            this.Controls.Add(this.cbTestIdAndName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLoadTest);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "EditTest";
            this.Text = "Edit a test";
            ((System.ComponentModel.ISupportInitialize)(this.testBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadTest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTestIdAndName;
        private System.Windows.Forms.BindingSource testBindingSource;
        private System.Windows.Forms.TableLayoutPanel tblPanel;
    }
}