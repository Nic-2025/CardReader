namespace IdCard.Hanel_obj.components.forms
{
    partial class MonitorForm
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
            pnNav = new Panel();
            label1 = new Label();
            btnAbout = new Button();
            btnLicense = new Button();
            btnChangePwd = new Button();
            btnFormInfo = new Button();
            btnAddressBook = new Button();
            btnReports = new Button();
            btnDailyLog = new Button();
            pnContent = new Panel();
            pnAuth = new Panel();
            sqliteCommand1 = new Microsoft.Data.Sqlite.SqliteCommand();
            pnNav.SuspendLayout();
            SuspendLayout();
            // 
            // pnNav
            // 
            pnNav.BackColor = SystemColors.ActiveCaption;
            pnNav.Controls.Add(label1);
            pnNav.Controls.Add(btnAbout);
            pnNav.Controls.Add(btnLicense);
            pnNav.Controls.Add(btnChangePwd);
            pnNav.Controls.Add(btnFormInfo);
            pnNav.Controls.Add(btnAddressBook);
            pnNav.Controls.Add(btnReports);
            pnNav.Controls.Add(btnDailyLog);
            pnNav.Dock = DockStyle.Left;
            pnNav.Location = new Point(0, 0);
            pnNav.Margin = new Padding(2, 2, 2, 2);
            pnNav.Name = "pnNav";
            pnNav.Size = new Size(196, 887);
            pnNav.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(2, 245);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(73, 25);
            label1.TabIndex = 1;
            label1.Text = "Setting";
            // 
            // btnAbout
            // 
            btnAbout.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAbout.Location = new Point(-2, 442);
            btnAbout.Margin = new Padding(2, 2, 2, 2);
            btnAbout.Name = "btnAbout";
            btnAbout.Size = new Size(196, 32);
            btnAbout.TabIndex = 0;
            btnAbout.Text = "About";
            btnAbout.UseVisualStyleBackColor = true;
            btnAbout.Click += BtnAbout_Click;
            // 
            // btnLicense
            // 
            btnLicense.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLicense.Location = new Point(-2, 390);
            btnLicense.Margin = new Padding(2, 2, 2, 2);
            btnLicense.Name = "btnLicense";
            btnLicense.Size = new Size(196, 32);
            btnLicense.TabIndex = 0;
            btnLicense.Text = "License";
            btnLicense.UseVisualStyleBackColor = true;
            btnLicense.Click += BtnLicense_Click;
            // 
            // btnChangePwd
            // 
            btnChangePwd.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnChangePwd.Location = new Point(2, 333);
            btnChangePwd.Margin = new Padding(2, 2, 2, 2);
            btnChangePwd.Name = "btnChangePwd";
            btnChangePwd.Size = new Size(196, 32);
            btnChangePwd.TabIndex = 0;
            btnChangePwd.Text = "Đổi mật khẩu";
            btnChangePwd.UseVisualStyleBackColor = true;
            btnChangePwd.Click += BtnChangePwd_Click;
            // 
            // btnFormInfo
            // 
            btnFormInfo.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFormInfo.Location = new Point(2, 281);
            btnFormInfo.Margin = new Padding(2, 2, 2, 2);
            btnFormInfo.Name = "btnFormInfo";
            btnFormInfo.Size = new Size(196, 32);
            btnFormInfo.TabIndex = 0;
            btnFormInfo.Text = "Form thông tin";
            btnFormInfo.UseVisualStyleBackColor = true;
            btnFormInfo.Click += BtnFormInfo_Click;
            // 
            // btnAddressBook
            // 
            btnAddressBook.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddressBook.Location = new Point(0, 173);
            btnAddressBook.Margin = new Padding(2, 2, 2, 2);
            btnAddressBook.Name = "btnAddressBook";
            btnAddressBook.Size = new Size(196, 32);
            btnAddressBook.TabIndex = 0;
            btnAddressBook.Text = "Address Book";
            btnAddressBook.UseVisualStyleBackColor = true;
            btnAddressBook.Click += BtnAddressBook_Click;
            // 
            // btnReports
            // 
            btnReports.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReports.Location = new Point(0, 127);
            btnReports.Margin = new Padding(2, 2, 2, 2);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(196, 32);
            btnReports.TabIndex = 0;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = true;
            btnReports.Click += BtnReports_Click;
            // 
            // btnDailyLog
            // 
            btnDailyLog.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDailyLog.Location = new Point(-2, 84);
            btnDailyLog.Margin = new Padding(2, 2, 2, 2);
            btnDailyLog.Name = "btnDailyLog";
            btnDailyLog.Size = new Size(196, 32);
            btnDailyLog.TabIndex = 0;
            btnDailyLog.Text = "Daily Logbook";
            btnDailyLog.UseVisualStyleBackColor = true;
            btnDailyLog.Click += BtnDailyLog_Click;
            // 
            // pnContent
            // 
            pnContent.BackColor = SystemColors.ButtonFace;
            pnContent.Dock = DockStyle.Fill;
            pnContent.Location = new Point(196, 0);
            pnContent.Margin = new Padding(2, 2, 2, 2);
            pnContent.Name = "pnContent";
            pnContent.Padding = new Padding(17, 14, 17, 14);
            pnContent.Size = new Size(1690, 887);
            pnContent.TabIndex = 1;
            // 
            // pnAuth
            // 
            pnAuth.AutoScroll = true;
            pnAuth.BackColor = SystemColors.ActiveCaption;
            pnAuth.Dock = DockStyle.Right;
            pnAuth.Location = new Point(1414, 0);
            pnAuth.Margin = new Padding(2, 2, 2, 2);
            pnAuth.Name = "pnAuth";
            pnAuth.Size = new Size(472, 887);
            pnAuth.TabIndex = 2;
            // 
            // sqliteCommand1
            // 
            sqliteCommand1.CommandTimeout = 30;
            sqliteCommand1.Connection = null;
            sqliteCommand1.Transaction = null;
            sqliteCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // MonitorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1886, 887);
            Controls.Add(pnAuth);
            Controls.Add(pnContent);
            Controls.Add(pnNav);
            Margin = new Padding(2, 2, 2, 2);
            Name = "MonitorForm";
            Text = "MonitorForm";
            pnNav.ResumeLayout(false);
            pnNav.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnNav;
        private Panel pnContent;
        private Panel pnAuth;
        private Microsoft.Data.Sqlite.SqliteCommand sqliteCommand1;
        private Button btnDailyLog;
        private Button btnAddressBook;
        private Button btnReports;
        private Label label1;
        private Button btnAbout;
        private Button btnLicense;
        private Button btnChangePwd;
        private Button btnFormInfo;
    }
}