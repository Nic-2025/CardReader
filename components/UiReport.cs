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

        private void UpdateTimeFilter()
        {
            var from = dateTimePicker1.Value.Date;
            var to = dateTimePicker1.Value.Date.AddDays(1).AddTicks(-1);
            //from = from.AddHours(-from.Hour);
            uiioLogTable1.From = from;
            uiioLogTable1.To = to;
        }
    }
}
