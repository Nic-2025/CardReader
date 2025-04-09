using IdCard.Hanel_obj.components.forms;

namespace IdCard.Hanel_obj.components
{
    public partial class UiLicense : UserControl
    {
        auxi.License? _license;

        public delegate void EventLicenseActive(auxi.License license);

        public event EventLicenseActive? OnActive;

        public UiLicense()
        {
            InitializeComponent();
            UpdateContent();
        }

        private void UpdateContent()
        {
            if (_license?.Status == auxi.LicenseState.Valid)
            {
                _lbTitle.Text = "Sản phẩm đã được kích hoạt";
                _lbLicenseMessage.Text = $"Ngày hết hạn: {_license.Expired:dd/MM/yyyy}";
            }
            else
            {
                _lbTitle.Text = "Sản phẩm chưa được kích hoạt";
                _lbLicenseMessage.Text = "Nhấn “ Kích hoạt ngay” để kích hoạt và sử dụng sản phẩm";
            }
        }

        private void BtnActive_Click(object sender, EventArgs e)
        {
            DialogLicense dialog = new();
            dialog.ShowDialog(this);
            if (dialog.License != null)
            {
                _license = dialog.License;
                OnActive?.Invoke(dialog.License);
                this.Hide();
            }
            this.UpdateContent();
        }
    }
}
