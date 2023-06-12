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
            this.SuspendLayout();
            // 
            // sqlLoginLable
            // 
            this.sqlLoginLable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sqlLoginLable.AutoSize = true;
            this.sqlLoginLable.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sqlLoginLable.Location = new System.Drawing.Point(38, 47);
            this.sqlLoginLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sqlLoginLable.Name = "sqlLoginLable";
            this.sqlLoginLable.Size = new System.Drawing.Size(57, 28);
            this.sqlLoginLable.TabIndex = 0;
            this.sqlLoginLable.Text = "Login";
            this.sqlLoginLable.UseMnemonic = false;
            // 
            // sqlPasswordLable
            // 
            this.sqlPasswordLable.AutoSize = true;
            this.sqlPasswordLable.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sqlPasswordLable.Location = new System.Drawing.Point(38, 84);
            this.sqlPasswordLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sqlPasswordLable.Name = "sqlPasswordLable";
            this.sqlPasswordLable.Size = new System.Drawing.Size(93, 28);
            this.sqlPasswordLable.TabIndex = 1;
            this.sqlPasswordLable.Text = "Password";
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(158, 47);
            this.userNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(190, 24);
            this.userNameTextBox.TabIndex = 2;
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Location = new System.Drawing.Point(158, 84);
            this.passwordTextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.PasswordChar = '*';
            this.passwordTextbox.Size = new System.Drawing.Size(190, 24);
            this.passwordTextbox.TabIndex = 3;
            // 
            // sqlTestButton
            // 
            this.sqlTestButton.AutoSize = true;
            this.sqlTestButton.BackColor = System.Drawing.Color.SkyBlue;
            this.sqlTestButton.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sqlTestButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sqlTestButton.Location = new System.Drawing.Point(368, 59);
            this.sqlTestButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sqlTestButton.Name = "sqlTestButton";
            this.sqlTestButton.Size = new System.Drawing.Size(105, 38);
            this.sqlTestButton.TabIndex = 4;
            this.sqlTestButton.Text = "Test";
            this.sqlTestButton.UseVisualStyleBackColor = false;
            this.sqlTestButton.Click += new System.EventHandler(this.sqlTestButton_Click);
            // 
            // srcFolderButton
            // 
            this.srcFolderButton.BackColor = System.Drawing.Color.SkyBlue;
            this.srcFolderButton.Location = new System.Drawing.Point(78, 170);
            this.srcFolderButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.srcFolderButton.Name = "srcFolderButton";
            this.srcFolderButton.Size = new System.Drawing.Size(190, 34);
            this.srcFolderButton.TabIndex = 5;
            this.srcFolderButton.Text = "Source Path";
            this.srcFolderButton.UseVisualStyleBackColor = false;
            this.srcFolderButton.Click += new System.EventHandler(this.srcFolderButton_Click);
            // 
            // arcFolderButton
            // 
            this.arcFolderButton.BackColor = System.Drawing.Color.SkyBlue;
            this.arcFolderButton.Location = new System.Drawing.Point(78, 212);
            this.arcFolderButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.arcFolderButton.Name = "arcFolderButton";
            this.arcFolderButton.Size = new System.Drawing.Size(190, 34);
            this.arcFolderButton.TabIndex = 6;
            this.arcFolderButton.Text = "Archive Path";
            this.arcFolderButton.UseVisualStyleBackColor = false;
            this.arcFolderButton.Click += new System.EventHandler(this.arcFolderButton_Click);
            // 
            // srcPath
            // 
            this.srcPath.AutoSize = true;
            this.srcPath.Location = new System.Drawing.Point(292, 177);
            this.srcPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.srcPath.Name = "srcPath";
            this.srcPath.Size = new System.Drawing.Size(102, 19);
            this.srcPath.TabIndex = 7;
            this.srcPath.Text = "No Path Selected";
            // 
            // arcPath
            // 
            this.arcPath.AutoSize = true;
            this.arcPath.Location = new System.Drawing.Point(292, 220);
            this.arcPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.arcPath.Name = "arcPath";
            this.arcPath.Size = new System.Drawing.Size(102, 19);
            this.arcPath.TabIndex = 8;
            this.arcPath.Text = "No Path Selected";
            // 
            // successLable
            // 
            this.successLable.AutoSize = true;
            this.successLable.BackColor = System.Drawing.Color.PaleGreen;
            this.successLable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.successLable.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.successLable.Location = new System.Drawing.Point(198, 122);
            this.successLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.successLable.Name = "successLable";
            this.successLable.Size = new System.Drawing.Size(110, 30);
            this.successLable.TabIndex = 9;
            this.successLable.Text = "Successfull";
            this.successLable.Visible = false;
            // 
            // failedLable
            // 
            this.failedLable.AutoSize = true;
            this.failedLable.BackColor = System.Drawing.Color.Red;
            this.failedLable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.failedLable.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.failedLable.Location = new System.Drawing.Point(220, 122);
            this.failedLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.failedLable.Name = "failedLable";
            this.failedLable.Size = new System.Drawing.Size(65, 30);
            this.failedLable.TabIndex = 10;
            this.failedLable.Text = "Failed";
            this.failedLable.Visible = false;
            // 
            // Setup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(499, 276);
            this.Controls.Add(this.failedLable);
            this.Controls.Add(this.successLable);
            this.Controls.Add(this.arcPath);
            this.Controls.Add(this.srcPath);
            this.Controls.Add(this.arcFolderButton);
            this.Controls.Add(this.srcFolderButton);
            this.Controls.Add(this.sqlTestButton);
            this.Controls.Add(this.passwordTextbox);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.sqlPasswordLable);
            this.Controls.Add(this.sqlLoginLable);
            this.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Setup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setup";
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
    }
}

