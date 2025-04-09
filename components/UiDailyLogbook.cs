using IdCard.Hanel.Models;

namespace IdCard.Hanel_obj.components
{
    public partial class UiDailyLogbook : UserControl
    {

        public UiDailyLogbook()
        {
            InitializeComponent();
            uiioLogTable1.From = DateTime.Now.Date;
            lbDate.Text = DateTime.Now.Date.ToString("dd/MM/yyyyy");
            this.Dock = DockStyle.Fill;
        }

        public void Reload()
        {
            uiioLogTable1.LoadData(uiioLogTable1.CurrentPage);
        }

        private void CbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbStatus.SelectedIndex)
            {
                case 0:
                    uiioLogTable1.Status = null;
                    break;
                case 1:
                    uiioLogTable1.Status = IOStatus.SignIn;
                    break;
                case 2:
                    uiioLogTable1.Status = IOStatus.SignOut;
                    break;
                default:
                    break;
            }
        }
    }
}
