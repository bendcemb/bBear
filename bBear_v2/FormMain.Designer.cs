namespace bBear_v2
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.TitleBarpanel = new System.Windows.Forms.Panel();
            this.lblUser = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.LeftMenuPanel = new System.Windows.Forms.Panel();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnRecords = new System.Windows.Forms.Button();
            this.btnFiles = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.usctrRecord1 = new bBear_v2.usctrRecordBy();
            this.usctrFile1 = new bBear_v2.usctrFile();
            this.ustrDashboard1 = new bBear_v2.usctrDashboard();
            this.TitleBarpanel.SuspendLayout();
            this.LeftMenuPanel.SuspendLayout();
            this.panelContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleBarpanel
            // 
            this.TitleBarpanel.Controls.Add(this.lblUser);
            this.TitleBarpanel.Controls.Add(this.btnMinimize);
            this.TitleBarpanel.Controls.Add(this.btnClose);
            this.TitleBarpanel.Controls.Add(this.btnMaximize);
            this.TitleBarpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleBarpanel.Location = new System.Drawing.Point(0, 0);
            this.TitleBarpanel.Name = "TitleBarpanel";
            this.TitleBarpanel.Size = new System.Drawing.Size(850, 45);
            this.TitleBarpanel.TabIndex = 0;
            this.TitleBarpanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBarpanel_MouseDown);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.ForeColor = System.Drawing.Color.Red;
            this.lblUser.Location = new System.Drawing.Point(12, 17);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(0, 13);
            this.lblUser.TabIndex = 4;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnMinimize.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMinimize.Location = new System.Drawing.Point(733, 12);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(31, 23);
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.Text = "-";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            this.btnMinimize.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            this.btnMinimize.MouseHover += new System.EventHandler(this.Button_MouseHover);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnClose.Location = new System.Drawing.Point(807, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(31, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "X";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            this.btnClose.MouseHover += new System.EventHandler(this.Button_MouseHover);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnMaximize.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMaximize.Location = new System.Drawing.Point(770, 12);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(31, 23);
            this.btnMaximize.TabIndex = 1;
            this.btnMaximize.Text = "□";
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            this.btnMaximize.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            this.btnMaximize.MouseHover += new System.EventHandler(this.Button_MouseHover);
            // 
            // LeftMenuPanel
            // 
            this.LeftMenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.LeftMenuPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LeftMenuPanel.Controls.Add(this.btnSetting);
            this.LeftMenuPanel.Controls.Add(this.btnReport);
            this.LeftMenuPanel.Controls.Add(this.btnRecords);
            this.LeftMenuPanel.Controls.Add(this.btnFiles);
            this.LeftMenuPanel.Controls.Add(this.btnDashboard);
            this.LeftMenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftMenuPanel.ForeColor = System.Drawing.Color.White;
            this.LeftMenuPanel.Location = new System.Drawing.Point(0, 45);
            this.LeftMenuPanel.Margin = new System.Windows.Forms.Padding(10, 20, 0, 0);
            this.LeftMenuPanel.Name = "LeftMenuPanel";
            this.LeftMenuPanel.Padding = new System.Windows.Forms.Padding(10, 20, 0, 0);
            this.LeftMenuPanel.Size = new System.Drawing.Size(114, 605);
            this.LeftMenuPanel.TabIndex = 1;
            // 
            // btnSetting
            // 
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Image = global::bBear_v2.Properties.Resources.process32;
            this.btnSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.Location = new System.Drawing.Point(0, 246);
            this.btnSetting.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnSetting.Size = new System.Drawing.Size(111, 54);
            this.btnSetting.TabIndex = 4;
            this.btnSetting.Text = "ตั้งค่า";
            this.btnSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSetting.UseVisualStyleBackColor = true;
            // 
            // btnReport
            // 
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Image = global::bBear_v2.Properties.Resources.frequency32;
            this.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.Location = new System.Drawing.Point(3, 186);
            this.btnReport.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.btnReport.Name = "btnReport";
            this.btnReport.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnReport.Size = new System.Drawing.Size(111, 54);
            this.btnReport.TabIndex = 3;
            this.btnReport.Text = "รายงาน";
            this.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReport.UseVisualStyleBackColor = true;
            // 
            // btnRecords
            // 
            this.btnRecords.FlatAppearance.BorderSize = 0;
            this.btnRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecords.Image = global::bBear_v2.Properties.Resources.notes32;
            this.btnRecords.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecords.Location = new System.Drawing.Point(3, 126);
            this.btnRecords.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.btnRecords.Name = "btnRecords";
            this.btnRecords.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnRecords.Size = new System.Drawing.Size(111, 54);
            this.btnRecords.TabIndex = 2;
            this.btnRecords.Text = "บันทึก";
            this.btnRecords.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecords.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRecords.UseVisualStyleBackColor = true;
            this.btnRecords.Click += new System.EventHandler(this.btnRecords_Click);
            // 
            // btnFiles
            // 
            this.btnFiles.FlatAppearance.BorderSize = 0;
            this.btnFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiles.Image = global::bBear_v2.Properties.Resources.folder32;
            this.btnFiles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFiles.Location = new System.Drawing.Point(3, 66);
            this.btnFiles.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.btnFiles.Name = "btnFiles";
            this.btnFiles.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnFiles.Size = new System.Drawing.Size(111, 54);
            this.btnFiles.TabIndex = 1;
            this.btnFiles.Text = "ทะเบียน";
            this.btnFiles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFiles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFiles.UseVisualStyleBackColor = true;
            this.btnFiles.Click += new System.EventHandler(this.btnFiles_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Image = global::bBear_v2.Properties.Resources.Report32;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(0, 6);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnDashboard.Size = new System.Drawing.Size(111, 54);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "หน้าแรก";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContainer.Controls.Add(this.usctrRecord1);
            this.panelContainer.Controls.Add(this.usctrFile1);
            this.panelContainer.Controls.Add(this.ustrDashboard1);
            this.panelContainer.Location = new System.Drawing.Point(120, 45);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(727, 605);
            this.panelContainer.TabIndex = 2;
            // 
            // usctrRecord1
            // 
            this.usctrRecord1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usctrRecord1.BackColor = System.Drawing.Color.Black;
            this.usctrRecord1.Location = new System.Drawing.Point(1, 3);
            this.usctrRecord1.Name = "usctrRecord1";
            this.usctrRecord1.Size = new System.Drawing.Size(724, 599);
            this.usctrRecord1.TabIndex = 2;
            // 
            // usctrFile1
            // 
            this.usctrFile1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usctrFile1.BackColor = System.Drawing.Color.Black;
            this.usctrFile1.ForeColor = System.Drawing.Color.White;
            this.usctrFile1.Location = new System.Drawing.Point(3, 6);
            this.usctrFile1.Name = "usctrFile1";
            this.usctrFile1.Size = new System.Drawing.Size(718, 587);
            this.usctrFile1.TabIndex = 1;
            // 
            // ustrDashboard1
            // 
            this.ustrDashboard1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ustrDashboard1.BackColor = System.Drawing.Color.Black;
            this.ustrDashboard1.Location = new System.Drawing.Point(3, 3);
            this.ustrDashboard1.Name = "ustrDashboard1";
            this.ustrDashboard1.Size = new System.Drawing.Size(721, 599);
            this.ustrDashboard1.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(850, 650);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.LeftMenuPanel);
            this.Controls.Add(this.TitleBarpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "bBear";
            this.TitleBarpanel.ResumeLayout(false);
            this.TitleBarpanel.PerformLayout();
            this.LeftMenuPanel.ResumeLayout(false);
            this.panelContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TitleBarpanel;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Panel LeftMenuPanel;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnRecords;
        private System.Windows.Forms.Button btnFiles;
        private System.Windows.Forms.Panel panelContainer;
        private usctrDashboard ustrDashboard1;
        private usctrFile usctrFile1;
        private usctrRecordBy usctrRecord1;
        private System.Windows.Forms.Label lblUser;
    }
}

