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

        private void UpdateTimeFilter()
        {
            var from = dateTimePicker1.Value.Date;
            var to = dateTimePicker1.Value.Date.AddDays(1).AddTicks(-1);
            //from = from.AddHours(-from.Hour);
            uiioLogTable1.From = from;
            uiioLogTable1.To = to;
        }

        private void BtnExportExcel_Click(object sender, EventArgs e)
        {
            try
            {
                uiioLogTable1.WriteToExcel(@".\public\card_reader_export_excel.xlsx");
            }
            catch (Exception ex)
            {
                var x = $"{ex}";
                MessageBox.Show($"Export excel error: {ex}");
            }
        }
    }
}
