using IdCard.Hanel.Models;
using System.Reflection;

namespace IdCard.Hanel_obj.components
{
    public partial class UiDailyLogbook : UserControl
    {

        public UiDailyLogbook()
        {
            InitializeComponent();
            banner.BackgroundImage = Image.FromFile(Path.Combine(Application.StartupPath, "public", "banner.png"));
            DateTime now = DateTime.Now;
            uiioLogTable2.From = now.Date;
            string[] weekdays = { "Chủ nhật", "Thứ 2", "Thứ 3", "Thứ 4", "Thứ 5", "Thứ 6", "Thứ 7" };
            string formatted = $"{weekdays[(int)now.DayOfWeek]}, {now:dd/MM/yyyy}";
            lbDate.Text = formatted;
            cbStatus.SelectedIndex = 0;
            this.Dock = DockStyle.Fill;
        }

        public void Reload()
        {
            uiioLogTable2.LoadData(uiioLogTable2.CurrentPage);
        }

        private void CbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (cbStatus.SelectedIndex)
            {
                case 0:
                    uiioLogTable2.Status = null;
                    break;
                case 1:
                    uiioLogTable2.Status = IOStatus.SignIn;
                    break;
                case 2:
                    uiioLogTable2.Status = IOStatus.SignOut;
                    break;
                default:
                    break;
            }
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            uiioLogTable2.Search = txtSearch.Text;
        }
    }
}
