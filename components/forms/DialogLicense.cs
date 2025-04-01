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
            var licenseKey = txtActive.Text.Trim();
            if (string.IsNullOrEmpty(licenseKey))
            {
                MessageBox.Show("Vui lòng nhập mã kích hoạt!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var license = new auxi.License(licenseKey);
            // Validate the license key
            if (license.IsValid)
            {
                License = license;
                MessageBox.Show($"Kích hoạt thành công! Thời gian sử dụng đến {license.Expired:dd/MM/yyyy}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Mã kích hoạt không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
