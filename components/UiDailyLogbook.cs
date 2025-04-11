using IdCard.Hanel.Models;

namespace IdCard.Hanel_obj.components
{
    public partial class UiDailyLogbook : UserControl
    {

        public UiDailyLogbook()
        {
            InitializeComponent();
            DateTime now = DateTime.Now;
            uiioLogTable1.From = now.Date;
            lbDate.Text = $"{now:dd/MM/yyyy}";
            string[] weekdays = { "Chủ nhật", "Thứ 2", "Thứ 3", "Thứ 4", "Thứ 5", "Thứ 6", "Thứ 7" };
            string formatted = $"{weekdays[(int)now.DayOfWeek]}, {now:dd/MM/yyyy}";
            date.Text = formatted;
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

        private void uiioLogTable1_Load(object sender, EventArgs e)
        {

        }
    }
}
