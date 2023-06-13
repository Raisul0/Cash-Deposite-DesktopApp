namespace DailyCashDeposite.Screens
{
    partial class CompanySetting
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompanySetting));
            this.deleteGrid = new System.Windows.Forms.Button();
            this.updateGridButton = new System.Windows.Forms.Button();
            this.companySettingGrid = new System.Windows.Forms.DataGridView();
            this.comspnySettingLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.companySettingGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // deleteGrid
            // 
            this.deleteGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.deleteGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteGrid.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteGrid.Location = new System.Drawing.Point(941, 566);
            this.deleteGrid.Margin = new System.Windows.Forms.Padding(4);
            this.deleteGrid.Name = "deleteGrid";
            this.deleteGrid.Size = new System.Drawing.Size(141, 48);
            this.deleteGrid.TabIndex = 10;
            this.deleteGrid.Text = "Delete ";
            this.deleteGrid.UseVisualStyleBackColor = false;
            this.deleteGrid.Click += new System.EventHandler(this.deleteGridButton_Click);
            // 
            // updateGridButton
            // 
            this.updateGridButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.updateGridButton.BackColor = System.Drawing.Color.SkyBlue;
            this.updateGridButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateGridButton.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateGridButton.Location = new System.Drawing.Point(792, 566);
            this.updateGridButton.Margin = new System.Windows.Forms.Padding(4);
            this.updateGridButton.Name = "updateGridButton";
            this.updateGridButton.Size = new System.Drawing.Size(141, 48);
            this.updateGridButton.TabIndex = 9;
            this.updateGridButton.Text = "Update";
            this.updateGridButton.UseVisualStyleBackColor = false;
            this.updateGridButton.Click += new System.EventHandler(this.updateGridButton_Click);
            // 
            // companySettingGrid
            // 
            this.companySettingGrid.AllowUserToDeleteRows = false;
            this.companySettingGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.companySettingGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.companySettingGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Poppins SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.companySettingGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.companySettingGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.companySettingGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.companySettingGrid.Location = new System.Drawing.Point(13, 70);
            this.companySettingGrid.Margin = new System.Windows.Forms.Padding(4);
            this.companySettingGrid.Name = "companySettingGrid";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.companySettingGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.companySettingGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.companySettingGrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companySettingGrid.Size = new System.Drawing.Size(1068, 488);
            this.companySettingGrid.TabIndex = 7;
            this.companySettingGrid.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.companySettingGrid_EditingControlShowing);
            this.companySettingGrid.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.companySettingGrid_RowLeave);
            this.companySettingGrid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.companySettingGrid_KeyPress);
            // 
            // comspnySettingLabel
            // 
            this.comspnySettingLabel.AutoSize = true;
            this.comspnySettingLabel.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comspnySettingLabel.Location = new System.Drawing.Point(4, 8);
            this.comspnySettingLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.comspnySettingLabel.Name = "comspnySettingLabel";
            this.comspnySettingLabel.Size = new System.Drawing.Size(211, 37);
            this.comspnySettingLabel.TabIndex = 8;
            this.comspnySettingLabel.Text = "Company Settings";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.PowderBlue;
            this.panel1.Controls.Add(this.comspnySettingLabel);
            this.panel1.Location = new System.Drawing.Point(13, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1070, 51);
            this.panel1.TabIndex = 11;
            // 
            // CompanySetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1094, 626);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.deleteGrid);
            this.Controls.Add(this.updateGridButton);
            this.Controls.Add(this.companySettingGrid);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CompanySetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Company Setting";
            this.Load += new System.EventHandler(this.CompanySetting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.companySettingGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button deleteGrid;
        private System.Windows.Forms.Button updateGridButton;
        private System.Windows.Forms.DataGridView companySettingGrid;
        private System.Windows.Forms.Label comspnySettingLabel;
        private System.Windows.Forms.Panel panel1;
    }
}