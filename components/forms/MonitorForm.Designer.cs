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
            horizo = new Panel();
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
            pnContentWrapper = new Panel();
            sqliteCommand1 = new Microsoft.Data.Sqlite.SqliteCommand();
            pnNav.SuspendLayout();
            pnContent.SuspendLayout();
            SuspendLayout();
            // 
            // pnNav
            // 
            pnNav.BackColor = Color.FromArgb(243, 243, 243);
            pnNav.Controls.Add(horizo);
            pnNav.Controls.Add(label1);
            pnNav.Controls.Add(btnAbout);
            pnNav.Controls.Add(btnLicense);
            pnNav.Controls.Add(btnChangePwd);
            pnNav.Controls.Add(btnFormInfo);
            pnNav.Controls.Add(btnAddressBook);
            pnNav.Controls.Add(btnReports);
            pnNav.Controls.Add(btnDailyLog);
            pnNav.Location = new Point(0, 0);
            pnNav.Margin = new Padding(4);
            pnNav.Name = "pnNav";
            pnNav.Size = new Size(280, 664);
            pnNav.TabIndex = 0;
            // 
            // horizo
            // 
            horizo.BackColor = Color.FromArgb(20, 0, 0, 0);
            horizo.Location = new Point(8, 151);
            horizo.Name = "horizo";
            horizo.Size = new Size(264, 2);
            horizo.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(11, 167);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(63, 21);
            label1.TabIndex = 1;
            label1.Text = "Setting";
            // 
            // btnAbout
            // 
            btnAbout.BackColor = Color.FromArgb(233, 233, 233);
            btnAbout.FlatAppearance.BorderSize = 0;
            btnAbout.FlatStyle = FlatStyle.Flat;
            btnAbout.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAbout.ImageAlign = ContentAlignment.MiddleLeft;
            btnAbout.Location = new Point(8, 322);
            btnAbout.Margin = new Padding(2);
            btnAbout.Name = "btnAbout";
            btnAbout.Size = new Size(75, 23);
            btnAbout.TabIndex = 0;
            btnAbout.Text = "About";
            btnAbout.TextAlign = ContentAlignment.MiddleLeft;
            btnAbout.UseVisualStyleBackColor = false;
            btnAbout.Click += BtnAbout_Click;
            // 
            // btnLicense
            // 
            btnLicense.BackColor = Color.FromArgb(233, 233, 233);
            btnLicense.FlatAppearance.BorderSize = 0;
            btnLicense.FlatStyle = FlatStyle.Flat;
            btnLicense.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLicense.Location = new Point(8, 278);
            btnLicense.Margin = new Padding(2);
            btnLicense.Name = "btnLicense";
            btnLicense.Size = new Size(75, 23);
            btnLicense.TabIndex = 0;
            btnLicense.Text = "License";
            btnLicense.TextAlign = ContentAlignment.MiddleLeft;
            btnLicense.UseVisualStyleBackColor = false;
            btnLicense.Click += BtnLicense_Click;
            // 
            // btnChangePwd
            // 
            btnChangePwd.BackColor = Color.FromArgb(233, 233, 233);
            btnChangePwd.FlatAppearance.BorderSize = 0;
            btnChangePwd.FlatStyle = FlatStyle.Flat;
            btnChangePwd.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnChangePwd.Location = new Point(8, 234);
            btnChangePwd.Margin = new Padding(2);
            btnChangePwd.Name = "btnChangePwd";
            btnChangePwd.Size = new Size(75, 23);
            btnChangePwd.TabIndex = 0;
            btnChangePwd.Text = "Đổi mật khẩu";
            btnChangePwd.TextAlign = ContentAlignment.MiddleLeft;
            btnChangePwd.UseVisualStyleBackColor = false;
            btnChangePwd.Click += BtnChangePwd_Click;
            // 
            // btnFormInfo
            // 
            btnFormInfo.BackColor = Color.FromArgb(233, 233, 233);
            btnFormInfo.FlatAppearance.BorderSize = 0;
            btnFormInfo.FlatStyle = FlatStyle.Flat;
            btnFormInfo.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFormInfo.ImageAlign = ContentAlignment.MiddleLeft;
            btnFormInfo.Location = new Point(8, 190);
            btnFormInfo.Margin = new Padding(2);
            btnFormInfo.Name = "btnFormInfo";
            btnFormInfo.Size = new Size(75, 23);
            btnFormInfo.TabIndex = 0;
            btnFormInfo.Text = "Form thông tin";
            btnFormInfo.TextAlign = ContentAlignment.MiddleLeft;
            btnFormInfo.UseVisualStyleBackColor = false;
            btnFormInfo.Click += BtnFormInfo_Click;
            // 
            // btnAddressBook
            // 
            btnAddressBook.BackColor = Color.FromArgb(233, 233, 233);
            btnAddressBook.FlatAppearance.BorderSize = 0;
            btnAddressBook.FlatStyle = FlatStyle.Flat;
            btnAddressBook.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddressBook.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddressBook.Location = new Point(8, 99);
            btnAddressBook.Margin = new Padding(2);
            btnAddressBook.Name = "btnAddressBook";
            btnAddressBook.Size = new Size(75, 23);
            btnAddressBook.TabIndex = 0;
            btnAddressBook.Text = "Address Book";
            btnAddressBook.TextAlign = ContentAlignment.MiddleLeft;
            btnAddressBook.UseVisualStyleBackColor = false;
            btnAddressBook.Click += BtnAddressBook_Click;
            // 
            // btnReports
            // 
            btnReports.BackColor = Color.FromArgb(233, 233, 233);
            btnReports.FlatAppearance.BorderSize = 0;
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReports.Location = new Point(8, 55);
            btnReports.Margin = new Padding(2);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(75, 23);
            btnReports.TabIndex = 0;
            btnReports.Text = "Reports";
            btnReports.TextAlign = ContentAlignment.MiddleLeft;
            btnReports.UseVisualStyleBackColor = false;
            btnReports.Click += BtnReports_Click;
            // 
            // btnDailyLog
            // 
            btnDailyLog.BackColor = Color.FromArgb(233, 233, 233);
            btnDailyLog.FlatAppearance.BorderSize = 0;
            btnDailyLog.FlatStyle = FlatStyle.Flat;
            btnDailyLog.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDailyLog.Location = new Point(8, 11);
            btnDailyLog.Margin = new Padding(2);
            btnDailyLog.Name = "btnDailyLog";
            btnDailyLog.Size = new Size(75, 23);
            btnDailyLog.TabIndex = 0;
            btnDailyLog.Text = "Daily Logbook";
            btnDailyLog.TextAlign = ContentAlignment.MiddleLeft;
            btnDailyLog.UseVisualStyleBackColor = false;
            btnDailyLog.Click += BtnDailyLog_Click;
            // 
            // pnContent
            // 
            pnContent.BackColor = Color.FromArgb(250, 250, 250);
            pnContent.Controls.Add(pnAuth);
            pnContent.Controls.Add(pnContentWrapper);
            pnContent.Location = new Point(280, 0);
            pnContent.Margin = new Padding(0);
            pnContent.Name = "pnContent";
            pnContent.Padding = new Padding(16);
            pnContent.Size = new Size(1115, 664);
            pnContent.TabIndex = 1;
            // 
            // pnAuth
            // 
            pnAuth.AutoScroll = true;
            pnAuth.BackColor = Color.FromArgb(128, 255, 255);
            pnAuth.Location = new Point(431, 0);
            pnAuth.Margin = new Padding(2);
            pnAuth.Name = "pnAuth";
            pnAuth.Size = new Size(244, 632);
            pnAuth.TabIndex = 1;
            pnAuth.Visible = true;
            // 
            // pnContentWrapper
            // 
            pnContentWrapper.Location = new Point(27, 99);
            pnContentWrapper.Name = "pnContentWrapper";
            pnContentWrapper.Size = new Size(737, 303);
            pnContentWrapper.TabIndex = 0;
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
            ClientSize = new Size(1347, 637);
            Controls.Add(pnContent);
            Controls.Add(pnNav);
            Margin = new Padding(2);
            Name = "MonitorForm";
            Text = "MonitorForm";
            Resize += MonitorForm_Resize;
            pnNav.ResumeLayout(false);
            pnNav.PerformLayout();
            pnContent.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnNav;
        private Panel pnContent;
        private Microsoft.Data.Sqlite.SqliteCommand sqliteCommand1;
        private Button btnDailyLog;
        private Button btnAddressBook;
        private Button btnReports;
        private Label label1;
        private Button btnAbout;
        private Button btnLicense;
        private Button btnChangePwd;
        private Button btnFormInfo;
        private Panel horizo;
        private Panel pnContentWrapper;
        private Panel pnAuth;
    }
}