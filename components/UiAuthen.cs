using AuthenCard.reader;
using RAR.IdCard.Sdk.Reader;
using IdCard.Hanel.Models;
using IdCard.Hanel_obj.components.common;
using Accessibility;

namespace IdCard.Hanel_obj.forms
{
    public partial class UiAuthen : UserControl
    {
        private Customer? _customer = null;
        private InOutLog? _currentLog = null;

        private readonly AuthReader _reader = new();
        private readonly InOutLogRepository _ioRepo = new(AuthenCardDbContext.Instance);
        private readonly CustomerRepository _ctmRepo = new(AuthenCardDbContext.Instance);

        private readonly AdditionFieldRepository _fielsRepo = new(AuthenCardDbContext.Instance);

        public delegate void HandleDoneEvent(InOutLog newLog);

        public event HandleDoneEvent? OnDone;

        public string ImagePath { set; get; } = "./data/images";

        public UiAuthen()
        {
            InitializeComponent();

            SetupReader();
            EnsureFolderPathExists(ImagePath);

            ResetState();
            this.Hide();
        }

        public void Close()
        {
            _reader.VideoReader.StopCapture();
            _reader.Close();
        }

        private void SetupReader()
        {
            _reader.CardReader.OnCardIn += OnCardIn;
            _reader.CardReader.OnReadCardDone += OnReadDone;

            _reader.VideoReader.OnUpdateFrameEvent += OnUpdateFrame;
            _reader.VideoReader.OnResultEvent += OnResultCamera;
        }

        private void OnResultCamera(CaptureResult ev)
        {
            _reader.VideoReader.StopCapture();

            Invoke(new Action(() =>
            {
                if (ev != CaptureResult.SUCCESS)
                {
                    MessageBox.Show("Verify camera error. Try again");
                    _reader.VideoReader.StartCapture();
                }
                else
                    _verifyImage.IsVerified = true;
            }));
        }

        private void OnUpdateFrame(Image? newImg)
        {
            pImage.SizeMode = PictureBoxSizeMode.Zoom; // Ensure the image fits the PictureBox
            pImage.Image = newImg;
        }

        private void OnReadDone(Customer? customer)
        {
            this.Invoke(new Action(() =>
            {
                if (customer == null)
                {
                    MessageBox.Show("Read card eror. Try again");
                    return;
                }

                SetCustomer(customer);
                DetectLatestCheckIn(customer.Id);

                _reader.VideoReader.StartCapture();
            }));
        }

        private void OnCardIn(StatusEventCardArgs ev)
        {
            this.Invoke(new Action(() =>
            {
                ResetState();
                CreateFormComponent(_fielsRepo.GetList());
                Show();
            }));
        }

        private void SetCustomer(Customer customer)
        {
            _customer = customer;
            _customer.CreatedAt = DateTime.Now;
            _verifyCard.IsVerified = true;
            _cbManual.Visible = true;

            _customer = _ctmRepo.FirstOrDefault(customer.Id, customer);

            lbHoTenVal.Text = customer.HoTen;
            lbCCCDVal.Text = customer.Id;
        }

        private void SaveImageToFile(string filePath)
        {
            if (pImage.Image != null)
            {
                try
                {
                    // Ensure the directory exists
                    var directory = Path.GetDirectoryName(filePath);
                    if (!string.IsNullOrEmpty(directory) && !Directory.Exists(directory))
                    {
                        Directory.CreateDirectory(directory);
                    }

                    // Save the image to a new Bitmap to avoid issues with the PictureBox
                    using var bitmap = new Bitmap(pImage.Image);
                    bitmap.Save(filePath, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error saving image: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("No image to save.");
            }
        }

        private void ResetState()
        {
            this._reader.VideoReader.StopCapture();

            _verifyCard.IsVerified = false;
            _verifyImage.IsVerified = false;
            _cbManual.SelectedIndex = 0;
            _cbManual.Visible = true;


            lbHoTenVal.Text = "";
            lbCCCDVal.Text = "";
            _customer = null;
            _currentLog = null;

            _signIoStatus.IsSignIn = false;
            lbSignInValue.Text = "--:--";
            lbSignOutValue.Text = "--:--";

            ClearFormComponents();
            this.Hide();
        }

        private void DetectLatestCheckIn(string cccd)
        {
            var manualSignOut = _cbManual.SelectedIndex != 0;
            var latest = _ioRepo.DetectLatestCheckIn(cccd, manualSignOut);
            if (latest == null)
            {
                if (manualSignOut)
                {
                    MessageBox.Show("Không tìm thấy thông tin checkin nào. Vui lòng kiểm tra lại");
                    _cbManual.SelectedIndex = 0;
                }

                latest = new InOutLog
                {
                    AdditionFields = { },
                    CheckInTime = DateTime.Now,
                    CheckOutTime = null,
                    CustomerId = cccd,
                };
            }
            else
            {
                latest.CheckOutTime = DateTime.Now;
                latest.ManualSignOut = _cbManual.SelectedIndex;
            }
            _currentLog = latest;
            UpdateLogState();

        }

        private void UpdateLogState()
        {
            _signIoStatus.IsSignIn = _currentLog?.CheckOutTime == null;
            lbSignInValue.Text = _currentLog?.CheckInTime.ToString("HH:mm") ?? "--:--";
            lbSignOutValue.Text = _currentLog?.CheckOutTime?.ToString("HH:mm") ?? "--:--";

            UpdateForm();
        }


        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (_currentLog == null)
                return;

            if (!_verifyImage.IsVerified)
            {
                MessageBox.Show("Chưa xác minh mặt");
                return;
            }

            if (_currentLog.Id == "")
            {
                var filled = GetFormValues();
                if (filled == null)
                    return;

                _currentLog.AdditionFields = filled;

                var now = DateTime.Now;
                var imgFolder = $"{ImagePath}/{now.Year}/{now.Month}";
                var imgPath = $"{imgFolder}/{Guid.NewGuid()}.jpg";

                EnsureFolderPathExists(imgFolder);
                SaveImageToFile(imgPath);
                _currentLog.InImg = imgPath;

                _ioRepo.Insert(_currentLog);
            }
            else
            {
                _ioRepo.UpdateCheckOutTime(_currentLog.Id, DateTime.Now, _cbManual.SelectedIndex);
            }

            this.OnDone?.Invoke(_currentLog);
            this.ResetState();
            this.Hide();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            ResetState();
            this.Hide();
        }

        private Dictionary<string, string>? GetFormValues()
        {
            var values = new Dictionary<string, string>();
            foreach (Control control in pnFormField.Controls)
            {
                if (control is UiAdditionField uiField)
                {
                    var fieldName = uiField.Field.Label; // Assuming input control is the second child
                    var val = uiField.GetValue();
                    if (val == "" && uiField.Field.Require)
                    {
                        MessageBox.Show($"Trường dữ liệu {uiField.Field.Label} bắt buộc phải điền");
                        return null;
                    }
                    values[fieldName] = val;
                }
            }

            return values;
        }

        private void CreateFormComponent(List<AdditionField> fields)
        {
            pnFormField.Controls.Clear();
            foreach (var field in fields)
            {
                var uiField = new UiAdditionField(field);
                //{
                //    Dock = DockStyle.Top
                //};
                pnFormField.Controls.Add(uiField);
            }
        }

        private void ClearFormComponents()
        {
            foreach (Control control in pnFormField.Controls)
            {
                if (control is UiAdditionField uiField)
                {
                    uiField.ClearField();
                }
            }
        }

        private void UpdateForm()
        {
            if (_currentLog == null || _currentLog.AdditionFields == null || _currentLog.AdditionFields?.Count == 0)
                return;

            foreach (Control control in pnFormField.Controls)
            {
                if (control is UiAdditionField uiField)
                {
                    if (uiField.Field.Label != null &&
                        _currentLog.AdditionFields != null &&
                        _currentLog.AdditionFields.ContainsKey(uiField.Field.Label)
                        )
                    {
                        uiField.SetValue(_currentLog.AdditionFields[uiField.Field.Label]);
                    }
                }
            }
        }

        private static void EnsureFolderPathExists(string folderPath)
        {
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
        }

        private void CbManual_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_customer == null)
                return;

            // Automatic
            _signIoStatus.IsManual = _cbManual.SelectedIndex == 0 ? false : true;
            DetectLatestCheckIn(_customer.Id);

        }
    }
}
