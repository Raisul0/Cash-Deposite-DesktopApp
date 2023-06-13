namespace DailyCashDeposite.Screens
{
    partial class Setup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setup));
            this.sqlLoginLable = new System.Windows.Forms.Label();
            this.sqlPasswordLable = new System.Windows.Forms.Label();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.sqlTestButton = new System.Windows.Forms.Button();
            this.srcFolderButton = new System.Windows.Forms.Button();
            this.arcFolderButton = new System.Windows.Forms.Button();
            this.srcPath = new System.Windows.Forms.Label();
            this.arcPath = new System.Windows.Forms.Label();
            this.srcFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.arcFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.successLable = new System.Windows.Forms.Label();
            this.failedLable = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.setupLabel = new System.Windows.Forms.Label();
            this.mainPanal = new System.Windows.Forms.Panel();
            this.dataBaseTextBox = new System.Windows.Forms.TextBox();
            this.serverTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.mainPanal.SuspendLayout();
            this.SuspendLayout();
            // 
            // sqlLoginLable
            // 
            this.sqlLoginLable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sqlLoginLable.AutoSize = true;
            this.sqlLoginLable.BackColor = System.Drawing.SystemColors.Window;
            this.sqlLoginLable.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sqlLoginLable.Location = new System.Drawing.Point(400, 31);
            this.sqlLoginLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sqlLoginLable.Name = "sqlLoginLable";
            this.sqlLoginLable.Size = new System.Drawing.Size(57, 28);
            this.sqlLoginLable.TabIndex = 0;
            this.sqlLoginLable.Text = "Login";
            this.sqlLoginLable.UseMnemonic = false;
            // 
            // sqlPasswordLable
            // 
            this.sqlPasswordLable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sqlPasswordLable.AutoSize = true;
            this.sqlPasswordLable.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sqlPasswordLable.Location = new System.Drawing.Point(400, 68);
            this.sqlPasswordLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sqlPasswordLable.Name = "sqlPasswordLable";
            this.sqlPasswordLable.Size = new System.Drawing.Size(93, 28);
            this.sqlPasswordLable.TabIndex = 1;
            this.sqlPasswordLable.Text = "Password";
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userNameTextBox.Location = new System.Drawing.Point(520, 31);
            this.userNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(190, 24);
            this.userNameTextBox.TabIndex = 3;
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordTextbox.Location = new System.Drawing.Point(520, 68);
            this.passwordTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.PasswordChar = '*';
            this.passwordTextbox.Size = new System.Drawing.Size(190, 24);
            this.passwordTextbox.TabIndex = 4;
            this.passwordTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passwordTextbox_KeyPress);
            // 
            // sqlTestButton
            // 
            this.sqlTestButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sqlTestButton.AutoSize = true;
            this.sqlTestButton.BackColor = System.Drawing.Color.SkyBlue;
            this.sqlTestButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sqlTestButton.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sqlTestButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sqlTestButton.Location = new System.Drawing.Point(339, 109);
            this.sqlTestButton.Margin = new System.Windows.Forms.Padding(4);
            this.sqlTestButton.Name = "sqlTestButton";
            this.sqlTestButton.Size = new System.Drawing.Size(110, 38);
            this.sqlTestButton.TabIndex = 5;
            this.sqlTestButton.Text = "Test";
            this.sqlTestButton.UseVisualStyleBackColor = false;
            this.sqlTestButton.Click += new System.EventHandler(this.sqlTestButton_Click);
            // 
            // srcFolderButton
            // 
            this.srcFolderButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.srcFolderButton.BackColor = System.Drawing.Color.SkyBlue;
            this.srcFolderButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.srcFolderButton.Location = new System.Drawing.Point(74, 205);
            this.srcFolderButton.Margin = new System.Windows.Forms.Padding(4);
            this.srcFolderButton.Name = "srcFolderButton";
            this.srcFolderButton.Size = new System.Drawing.Size(190, 34);
            this.srcFolderButton.TabIndex = 6;
            this.srcFolderButton.Text = "Source Path";
            this.srcFolderButton.UseVisualStyleBackColor = false;
            this.srcFolderButton.Click += new System.EventHandler(this.srcFolderButton_Click);
            // 
            // arcFolderButton
            // 
            this.arcFolderButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.arcFolderButton.BackColor = System.Drawing.Color.SkyBlue;
            this.arcFolderButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.arcFolderButton.Location = new System.Drawing.Point(74, 247);
            this.arcFolderButton.Margin = new System.Windows.Forms.Padding(4);
            this.arcFolderButton.Name = "arcFolderButton";
            this.arcFolderButton.Size = new System.Drawing.Size(190, 34);
            this.arcFolderButton.TabIndex = 7;
            this.arcFolderButton.Text = "Archive Path";
            this.arcFolderButton.UseVisualStyleBackColor = false;
            this.arcFolderButton.Click += new System.EventHandler(this.arcFolderButton_Click);
            // 
            // srcPath
            // 
            this.srcPath.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.srcPath.AutoEllipsis = true;
            this.srcPath.AutoSize = true;
            this.srcPath.Location = new System.Drawing.Point(288, 212);
            this.srcPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.srcPath.MaximumSize = new System.Drawing.Size(500, 19);
            this.srcPath.Name = "srcPath";
            this.srcPath.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.srcPath.Size = new System.Drawing.Size(0, 19);
            this.srcPath.TabIndex = 7;
            // 
            // arcPath
            // 
            this.arcPath.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.arcPath.AutoEllipsis = true;
            this.arcPath.AutoSize = true;
            this.arcPath.Location = new System.Drawing.Point(288, 255);
            this.arcPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.arcPath.MaximumSize = new System.Drawing.Size(500, 19);
            this.arcPath.Name = "arcPath";
            this.arcPath.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.arcPath.Size = new System.Drawing.Size(0, 19);
            this.arcPath.TabIndex = 8;
            // 
            // successLable
            // 
            this.successLable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.successLable.AutoSize = true;
            this.successLable.BackColor = System.Drawing.Color.PaleGreen;
            this.successLable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.successLable.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.successLable.Location = new System.Drawing.Point(339, 161);
            this.successLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.successLable.Name = "successLable";
            this.successLable.Size = new System.Drawing.Size(110, 30);
            this.successLable.TabIndex = 9;
            this.successLable.Text = "Successfull";
            this.successLable.Visible = false;
            // 
            // failedLable
            // 
            this.failedLable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.failedLable.AutoSize = true;
            this.failedLable.BackColor = System.Drawing.Color.Red;
            this.failedLable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.failedLable.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.failedLable.Location = new System.Drawing.Point(361, 161);
            this.failedLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.failedLable.Name = "failedLable";
            this.failedLable.Size = new System.Drawing.Size(65, 30);
            this.failedLable.TabIndex = 10;
            this.failedLable.Text = "Failed";
            this.failedLable.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.PowderBlue;
            this.panel1.Controls.Add(this.setupLabel);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 50);
            this.panel1.TabIndex = 11;
            // 
            // setupLabel
            // 
            this.setupLabel.AutoSize = true;
            this.setupLabel.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setupLabel.Location = new System.Drawing.Point(12, 12);
            this.setupLabel.Name = "setupLabel";
            this.setupLabel.Size = new System.Drawing.Size(58, 28);
            this.setupLabel.TabIndex = 0;
            this.setupLabel.Text = "Setup";
            // 
            // mainPanal
            // 
            this.mainPanal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mainPanal.AutoSize = true;
            this.mainPanal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainPanal.Controls.Add(this.dataBaseTextBox);
            this.mainPanal.Controls.Add(this.sqlTestButton);
            this.mainPanal.Controls.Add(this.srcPath);
            this.mainPanal.Controls.Add(this.passwordTextbox);
            this.mainPanal.Controls.Add(this.serverTextBox);
            this.mainPanal.Controls.Add(this.userNameTextBox);
            this.mainPanal.Controls.Add(this.sqlPasswordLable);
            this.mainPanal.Controls.Add(this.label1);
            this.mainPanal.Controls.Add(this.sqlLoginLable);
            this.mainPanal.Controls.Add(this.failedLable);
            this.mainPanal.Controls.Add(this.label2);
            this.mainPanal.Controls.Add(this.successLable);
            this.mainPanal.Controls.Add(this.srcFolderButton);
            this.mainPanal.Controls.Add(this.arcFolderButton);
            this.mainPanal.Controls.Add(this.arcPath);
            this.mainPanal.Location = new System.Drawing.Point(12, 69);
            this.mainPanal.Name = "mainPanal";
            this.mainPanal.Size = new System.Drawing.Size(794, 347);
            this.mainPanal.TabIndex = 12;
            // 
            // dataBaseTextBox
            // 
            this.dataBaseTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataBaseTextBox.Location = new System.Drawing.Point(189, 68);
            this.dataBaseTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.dataBaseTextBox.Name = "dataBaseTextBox";
            this.dataBaseTextBox.Size = new System.Drawing.Size(190, 24);
            this.dataBaseTextBox.TabIndex = 2;
            // 
            // serverTextBox
            // 
            this.serverTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.serverTextBox.Location = new System.Drawing.Point(189, 31);
            this.serverTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.serverTextBox.Name = "serverTextBox";
            this.serverTextBox.Size = new System.Drawing.Size(190, 24);
            this.serverTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 28);
            this.label1.TabIndex = 14;
            this.label1.Text = "Database";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 28);
            this.label2.TabIndex = 13;
            this.label2.Text = "Server";
            this.label2.UseMnemonic = false;
            // 
            // Setup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(819, 425);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mainPanal);
            this.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Setup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setup";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Setup_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.mainPanal.ResumeLayout(false);
            this.mainPanal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sqlLoginLable;
        private System.Windows.Forms.Label sqlPasswordLable;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.TextBox passwordTextbox;
        private System.Windows.Forms.Button sqlTestButton;
        private System.Windows.Forms.Button srcFolderButton;
        private System.Windows.Forms.Button arcFolderButton;
        private System.Windows.Forms.Label srcPath;
        private System.Windows.Forms.Label arcPath;
        private System.Windows.Forms.FolderBrowserDialog srcFolderDialog;
        private System.Windows.Forms.FolderBrowserDialog arcFolderDialog;
        private System.Windows.Forms.Label successLable;
        private System.Windows.Forms.Label failedLable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label setupLabel;
        private System.Windows.Forms.Panel mainPanal;
        private System.Windows.Forms.TextBox dataBaseTextBox;
        private System.Windows.Forms.TextBox serverTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

