using IdCard.Hanel_obj.auxi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IdCard.Hanel_obj.components.forms
{
    public partial class DialogLicense : Form
    {

        public auxi.License? License { get; private set; } = null;

        public DialogLicense()
        {
            InitializeComponent();
            txtActive.PlaceholderText = "Nhập mã kích hoạt đã được gửi về Email";
        }

        private void BtnActive_Click(object sender, EventArgs e)
        {
            if (reader.AuthReader.Instance.CardReader.SerialNumber == "")
            {
                MessageBox.Show(
                    "Không thể tìm thấy thiết bị đọc thẻ. Vui lòng kiểm tra kết nối",
                    "Error",
                     MessageBoxButtons.OK, MessageBoxIcon.Error
                      );
                return;
            }

            var serial = new reader.ReaderSerial(reader.AuthReader.Instance.CardReader.SerialNumber);
            var licenseKey = txtActive.Text.Trim();
            if (string.IsNullOrEmpty(licenseKey))
            {
                MessageBox.Show("Vui lòng nhập mã kích hoạt!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var license = new auxi.License(licenseKey, serial.Company, serial.Device);
            // Validate the license key
            if (license.Status == LicenseState.Valid)
            {
                License = license;
                MessageBox.Show($"Kích hoạt thành công! Thời gian sử dụng đến {license.Expired:dd/MM/yyyy}",
                "Thông báo",
                 MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                return;
            }

            if (license.Status == LicenseState.Invalid)
            {
                MessageBox.Show("Mã kích hoạt không hợp lệ!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error
                    );
                return;

            }

            if (license.Status == LicenseState.Expired)
            {
                MessageBox.Show("Mã kích hoạt đã hết hạn!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error
                    );
                return;
            }
            if (license.Status == LicenseState.InvalidDevice)
            {
                MessageBox.Show("Mã kích hoạt không hợp lệ với thiết bị này!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error
                    );
                return;
            }
        }
    }
}
