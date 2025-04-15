using IdCard.Hanel_obj.components.common;

namespace IdCard.Hanel_obj.components
{
    public partial class UiReport : UserControl
    {
        public UiReport()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;

            UpdateTimeFilter();
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            UpdateTimeFilter();
        }

        private void endDate_ValueChanged(object sender, EventArgs e)
        {
            UpdateTimeFilter();
        }


        private void UpdateTimeFilter()
        {
            if (endDate.Value.Date < startDate.Value.Date)
            {
                MessageBox.Show("Ngày kết thúc không được nhỏ hơn ngày bắt đầu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var from = startDate.Value.Date;
            var to = endDate.Value.Date.AddDays(1).AddTicks(-1);
            //from = from.AddHours(-from.Hour);
            uiioLogTable1.From = from;
            uiioLogTable1.To = to;
        }
       
    }
}
