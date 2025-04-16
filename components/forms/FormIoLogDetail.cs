
using IdCard.Hanel.Models;


namespace IdCard.Hanel_obj.components.forms
{
    public partial class FormIoLogDetail : Form
    {
        private readonly InOutLogRepository ioRepo = new(AuthenCardDbContext.Instance);
        private string _logId = "";

        public string LogId { get => _logId; set => SetLogId(value); }

        public FormIoLogDetail(string id)
        {
            _logId = id;
            InitializeComponent();
            LoadInfo();
        }

        private void SetLogId(string id)
        {
            _logId = id;
            LoadInfo();
        }

        private void LoadInfo()
        {
            if (LogId == "")
                return;

            var log = ioRepo.GetById(LogId);
            if (log == null)
            {
                //MessageBox.Show("Log not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (File.Exists(log.InImg))
            {
                var image = Image.FromFile(log.InImg);
                pImage.Image = image;

                // Adjust PictureBox size mode to fit the image
                pImage.SizeMode = PictureBoxSizeMode.Zoom;

                // Ensure the PictureBox fits within the form
                pImage.Dock = DockStyle.Fill;
            }

            lbHoTenVal.Text = log.Customer?.HoTen ?? "";
            lbCCCDVal.Text = log.CustomerId ?? "";
            lbSignInValue.Text = log?.CheckInTime.ToString("HH:mm") ?? "--:--";
            lbSignOutValue.Text = log?.CheckOutTime?.ToString("HH:mm") ?? "--:--";

            manuaSignOut.Visible = !log.CheckOutTime.HasValue;

            CreateFormComponent(log.AdditionFields);
        }

        private void CreateFormComponent(Dictionary<string, string> dict)
        {
            pnFormField.Controls.Clear();
            foreach (var field in dict)
            {
                var label = new Label
                {
                    AutoSize = true,
                    Text = $"{field.Key}: {field.Value}",
                    Margin = new Padding(8),
                };

                pnFormField.Controls.Add(label);
            }
        }
    }
}
