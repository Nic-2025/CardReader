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
    public partial class UiSignIOStatus : UserControl
    {
        bool _isSignIn = false;
        bool _isManual = false;

        public bool IsSignIn { set => SetSignIn(value); get => _isSignIn; }
        public bool IsManual { set => SetManual(value); get => _isManual; }


        public UiSignIOStatus()
        {
            InitializeComponent();
        }


        private void SetManual(bool val)
        {
            _isManual = val;
            SetSignIn(_isSignIn);
        }


        private void SetSignIn(bool val)
        {
            _isSignIn = val;
            if (_isSignIn)
            {
                lbStatus.Text = "SignIn";
                lbStatus.ForeColor = ColorTranslator.FromHtml("#FFF4ED");
                lbStatus.BackColor = ColorTranslator.FromHtml("#D92D20");
                BackColor = ColorTranslator.FromHtml("#D92D20");
                return;
            }

            if (_isManual)
            {
                lbStatus.Text = "Manual SignOut";
                lbStatus.ForeColor = ColorTranslator.FromHtml("#F79009");
                lbStatus.BackColor = ColorTranslator.FromHtml("#FFF7DF");
                this.BackColor = ColorTranslator.FromHtml("#FFF7DF");
            }
            else
            {
                lbStatus.Text = "SignOut";
                lbStatus.ForeColor = ColorTranslator.FromHtml("#ECFDF3");
                lbStatus.BackColor = ColorTranslator.FromHtml("#079455");
                this.BackColor = ColorTranslator.FromHtml("#079455");
            }
        }
    }
}
