
using IdCard.Hanel.Models;
using IdCard.Hanel_obj.forms;
using System.ComponentModel;

namespace IdCard.Hanel_obj.components.forms
{
    enum ContentType
    {
        None = 0,
        DailyLogbook = 1,
        Reports = 2,
        AddressBook = 3,
        FormThongTin = 4,
        ChangePwd = 5,
        License = 6,
        About = 7,
    }

    public partial class MonitorForm : Form
    {
        readonly UiAuthen _authComponent = new();
        ContentType _currentContentType = ContentType.None;
        User? _user;
        UserControl? _userControl;

        //public auxi.License _license = new();

        public MonitorForm()
        {
            InitializeComponent();


            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;

            //pnAuth.Controls.Add(_authComponent);
            _authComponent.OnDone += HandleAuthDone;


            OnChangeContentType(ContentType.None);

            // Attach the Load event
            Load += MonitorForm_Load;

            // Attach the FormClosing event
            FormClosing += MonitorForm_FormClosing;
        }


        private async void MonitorForm_Load(object? sender, EventArgs e)
        {
            // Ensure the form is fully displayed
            await Task.Delay(200); // Small delay to ensure the form is rendered

            this.WindowState = FormWindowState.Maximized;
            this.Load += (s, e) => MonitorForm_Resize(null, null);

            var formLogin = new FormLogin();
            formLogin.ShowDialog();
            _user = formLogin.User;

            //if (!_license.IsValid)
            //{
            //    MessageBox.Show("License is not valid. Please activate your license.", "License Error");
            //    OnChangeContentType(ContentType.License);
            //    return;
            //}

            OnChangeContentType(ContentType.DailyLogbook);

        }

        private void MonitorForm_FormClosing(object? sender, FormClosingEventArgs e)
        {
            // Handle form closing logic here
            // For example, releasing resources or confirming exit
            var result = MessageBox.Show("Are you sure you want to close the application?",
                                         "Confirm Exit",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true; // Cancel the close operation
            }
            else
            {
                _authComponent.Close();
            }
        }

        private void OnChangeContentType(ContentType newType)
        {
            //if (!_license.IsValid)
            //{
            //    newType = ContentType.License;
            //}

            _currentContentType = newType;
            switch (newType)
            {
                case ContentType.None:
                    HandleChange(null);
                    break;
                case ContentType.DailyLogbook:
                    HandleChange(new UiDailyLogbook());
                    break;
                case ContentType.Reports:
                    HandleChange(new UiReport());
                    break;
                case ContentType.AddressBook:
                    HandleChange(new UiAddressBook());
                    break;
                case ContentType.FormThongTin:
                    HandleChange(new UiFormThongTin());
                    break;
                case ContentType.ChangePwd:
                    var newCtrl = new UiChangePwd();
                    newCtrl.CurrentUser = _user;
                    HandleChange(newCtrl);
                    break;
                //case ContentType.License:
                //    var newCtrlLicense = new UiLicense();
                //    //newCtrlLicense.OnActive += HandleLicenseActive;
                //    HandleChange(newCtrlLicense);
                //    break;
                case ContentType.About:
                    HandleChange(new UiAbout());
                    break;
            }

        }

        private void HandleChange(UserControl? newControl)
        {
            // Clear the current content of pnContent
            //pnContent.Controls.Clear();
            pnContentWrapper.Controls.Clear();
            pnContent.AutoScroll = true;

            pnContentWrapper.Size = new Size(pnContent.Width -16 , 1500);
            pnContentWrapper.Location = new Point(0, 0);
            pnContentWrapper.Padding = new Padding(16);


            _userControl = newControl;

            // Add the new control to pnContent
            if (newControl != null)
            {
                //pnContent.Controls.Add(newControl);
                pnContentWrapper.Controls.Add(newControl);

            }
            //pnAuth.Visible = _currentContentType == ContentType.DailyLogbook;
            //pnAuth.Visible = true;
        }

        private void BtnDailyLog_Click(object sender, EventArgs e)
        {
            OnChangeContentType(ContentType.DailyLogbook);
        }

        private void BtnReports_Click(object sender, EventArgs e)
        {
            OnChangeContentType(ContentType.Reports);
        }

        private void BtnAddressBook_Click(object sender, EventArgs e)
        {
            OnChangeContentType(ContentType.AddressBook);
        }

        private void BtnFormInfo_Click(object sender, EventArgs e)
        {
            OnChangeContentType(ContentType.FormThongTin);
        }

        private void BtnChangePwd_Click(object sender, EventArgs e)
        {
            OnChangeContentType(ContentType.ChangePwd);
        }

        private void BtnLicense_Click(object sender, EventArgs e)
        {
            OnChangeContentType(ContentType.License);
        }

        private void BtnAbout_Click(object sender, EventArgs e)
        {
            OnChangeContentType(ContentType.About);
        }

        private void HandleAuthDone(InOutLog newLog)
        {
            if (_userControl != null && _userControl is UiDailyLogbook dlb)
            {
                dlb.Reload();
            }
        }


        private void HandleLicenseActive(auxi.License license)
        {
            //_license = license;
            if (license.IsValid)
            {
                OnChangeContentType(ContentType.DailyLogbook);
            }
            else
            {
                OnChangeContentType(ContentType.License);
            }

        }

        private void pnNav_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void MonitorForm_Resize(object? sender, EventArgs e)
        {
            int totalWidth = this.ClientSize.Width;
            int navWidth = totalWidth * 2 / 12;
            int contentWidth = totalWidth - navWidth;

            pnNav.Width = navWidth;
            pnNav.Height = this.ClientSize.Height;
            pnNav.Location = new Point(0, 0);

            pnContent.Width = contentWidth;
            pnContent.Height = this.ClientSize.Height;
            pnContent.Location = new Point(navWidth, 0);



            int padding = 8; // hoặc 0 nếu không cần khoảng cách hai bên
            int btnWidth = pnNav.ClientSize.Width - padding * 2;

            btnAbout.Width = btnWidth;
            btnAbout.Height = 40;

            btnLicense.Width = btnWidth;
            btnLicense.Height = 40;

            btnReports.Width = btnWidth;
            btnReports.Height = 40;

            btnAddressBook.Width = btnWidth;
            btnAddressBook.Height = 40;

            btnFormInfo.Width = btnWidth;
            btnFormInfo.Height = 40;

            btnChangePwd.Width = btnWidth;
            btnChangePwd.Height = 40;

            btnDailyLog.Width = btnWidth;
            btnDailyLog.Height = 40;


        }

  
    }
}
