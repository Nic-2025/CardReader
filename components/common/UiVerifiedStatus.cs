using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IdCard.Hanel_obj.forms
{
    public partial class UiVerifiedStatus : UserControl
    {
        bool _verified = false;
        public bool IsVerified { set => SetVerify(value); get => _verified; }

        public UiVerifiedStatus()
        {
            InitializeComponent();
        }

        private void SetVerify(bool val)
        {

            _verified = val;
            if (val)
            {
                lbStatus.Text = "Đã xác minh";
                lbStatus.ForeColor = ColorTranslator.FromHtml("#ECFDF3");
                lbStatus.BackColor = ColorTranslator.FromHtml("#079455");

                //lbStatus.BorderStyle = BorderStyle.Parse;
                //lbStatus.BorderStyle
            }
            else
            {
                lbStatus.Text = "Chưa xác minh";
                lbStatus.ForeColor = ColorTranslator.FromHtml("#FFF4ED");
                lbStatus.BackColor = ColorTranslator.FromHtml("#D92D20");
            }
        }

        private void lbStatus_Click(object sender, EventArgs e)
        {

        }
    }
}
