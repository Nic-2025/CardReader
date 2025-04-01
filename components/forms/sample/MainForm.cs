using RAR.IdCard.Sdk.Reader;
using RAR.IdCard.Sdk.Reader.HN212;
using System.Diagnostics;
using Timer = System.Windows.Forms.Timer;

namespace IdCard.Hanel
{
    public partial class MainForm : Form
    {
        // VnPcscReader _reader = new VnPcscReader();
        VnHn212Reader _reader = new VnHn212Reader();
        Timer _timer = new Timer();
        Stopwatch _stw = new Stopwatch();
        byte[]? _ChipFaceBts = null;
        byte[]? _CamFaceBts = null;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            cbOcrMode.SelectedIndex = 0;
            cbReaderTypes.SelectedIndex = 0;
            cbAntiSpoofing.SelectedIndex = 0;
            cbProcessStep.SelectedIndex = 0;
            _timer.Tick += _timer_Tick;
            _timer.Interval = 5;
            ResetFormInfo();
            InitReader();
            // Load camera list
            // btnRefreshCamera_Click(new object(), new EventArgs());
        }

        private void _timer_Tick(object? sender, EventArgs e)
        {
            lbTime.Text = $"{_stw.Elapsed.ToString(@"ss\.fff")} s";
            LoadExternalCameras();
        }

        private void ResetFormInfo()
        {
            _timer.Stop();
            _stw.Stop();
            lbTime.Text = "00.000 s";


            //Personal infor
            txtDocumentNumber.Text = "Số CCCD: ";
            txtDateOfBirth.Text = "Ngày sinh: ";
            txtIssueDate.Text = "Ngày cấp: ";
            txtPreviousNumber.Text = "Số CMND cũ: ";
            txtName.Text = "Họ tên: ";
            txtSex.Text = "Giới tính: ";
            txtNationality.Text = "Quốc tịch: ";
            txtNation.Text = "Dân tộc: ";
            txtReligion.Text = "Tôn giáo: ";
            txtHometown.Text = "Quê quán: ";
            txtAddress.Text = "Địa chỉ: ";
            txtCharacter.Text = "Đặc điểm ND: ";
            txtExpiredDate.Text = "Ngày hết hạn: ";
            txtFatherName.Text = "Bố: ";
            txtMotherName.Text = "Mẹ: ";
            txtPartnerName.Text = "Vợ/Chồng: ";
            txtMRZ.Text = "MRZ: ";
            txtDSCert.Text = "";

            //Chip image
            picChipImage.Image = null;
            picIdcardFront.Image = null;
            pictureIdcardBack.Image = null;
            _ChipFaceBts = null;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void OnEvent(object sender, StatusEventArgs e)
        {
            switch (e.EventName)
            {
                case EVENT_NAMES.READER:
                    ProcessReaderEvent(e as StatusEventReaderArgs);
                    break;
                case EVENT_NAMES.CARD:
                    ProcessCardEvent(e as StatusEventCardArgs);
                    break;
                case EVENT_NAMES.READ:
                    ProcessReadEvent(e as StatusEventReadArgs);
                    break;
                case EVENT_NAMES.SCAN:
                    ProcessScanEvent(e as ScanEventArgs);
                    break;
                case EVENT_NAMES.READER_CAMERA:
                    ProcessCameraEvent(e as StatusEventCameraArgs);
                    break;
            }
        }
        private void InitReader()
        {
            /*Register all reader status event*/
            _reader.OnStatusChanged += Reader_OnStatusChanged;

            // var config = new VnPcscsConfig();
            var config = new VnHn212Config
            {
                /* set this to false: input access code or scan & read as required
                    * true: Auto scan card & read data*/
                // config.AutoReadWhenPresent = false;

                /*Set this flag to process VerifySOD*/
                DoVerifySOD = !txtFastRead.Checked,

                /*Set this flag to process AA/CA Authen*/
                CheckAACAAuthen = !txtFastRead.Checked,

                /* Capture face, Minimum time have real face*/
                /* Default is 200ms */
                AutoCaptureFaceMinimumMs = 200,

                /* Retry count */
                ReadCardRetryCount = 2,

                /* Seq */
                ProcessSequence = (cbProcessStep.SelectedIndex == 0) ? HN212ProSeq.CardOnly : HN212ProSeq.CardThenFace,

                OcrMode = (HN212OcrMode)(cbOcrMode.SelectedIndex + 1),

                // config.HidLibUsed = HN212HidLibrary.Auto;

                CaptureFaceUseFirstCamAvaiable = true,

                MonitorQRReaderDevice = true
            };

            /*Start reader monitoring ...*/
            _reader.StartMonitor(config);
        }


        private void WriteLog(string log)
        {
            System.Diagnostics.Debug.WriteLine(log);
        }


        private void ProcessReaderEvent(StatusEventReaderArgs? ev)
        {
            if (ev == null)
                return;
            WriteLog($"----> [{DateTime.Now.ToString("HH:mm:ss")}] Device {ev.ReaderSerialNumber} change stated from: {ev.LastState} to: {ev.NewState}.");
            lbReaderStatus.Text = (ev.NewState == READER_STATUS.ADDED) ? $"{ev.ReaderSerialNumber}" : "Không có";
            lbReaderStatus.ForeColor = (ev.NewState == READER_STATUS.ADDED) ? Color.Blue : Color.Red;
        }

        private void ProcessCameraEvent(StatusEventCameraArgs? ev)
        {
            if (ev == null)
                return;
            WriteLog($"----> [{DateTime.Now.ToString("HH:mm:ss")}] {ev.Message}.");
            btnRefreshCamera_Click(new object(), new EventArgs());
        }

        private void ProcessCardEvent(StatusEventCardArgs? ev)
        {
            if (ev == null)
                return;
            WriteLog($"----> [{DateTime.Now.ToString("HH:mm:ss")}] Card in Device {ev.ReaderSerialNumber} change stated from: {ev.LastState} to: {ev.NewState}.");
            lbCardStatus.Text = (ev.NewState == CARD_STATUS.EMPTY) ? "Không có" : "Có thẻ";
            lbCardStatus.ForeColor = (ev.NewState == CARD_STATUS.EMPTY) ? Color.Red : Color.Green;

            //Have new card, start timer to show time processing
            if (ev.NewState == CARD_STATUS.PRESENT)
            {
                //Clear form
                ResetFormInfo();
                //Start counter if auto read
                if (_reader.ReaderConfig.AutoReadWhenPresent)
                {
                    _stw.Restart();
                    _timer.Start();
                }
                else //Show form input Access code
                {
                    /*
                    InputAccessCode frm = new InputAccessCode();
                    if (frm.ShowDialog() != DialogResult.OK)
                        return;
                    _stw.Restart();
                    _timer.Start();
                    _reader.StartReadCard(frm.AccessCode);
                    */
                }
            }
            if (ev.NewState == CARD_STATUS.EMPTY)
            {
                if (chkDelteForm.Checked)
                    ResetFormInfo();
            }
        }

        private void OnScancardEvent(StatusEventReadArgs ev)
        {
        }

        private void OnReadCardFinish(StatusEventReadArgs ev)
        {
            _stw.Stop();
            _timer.Stop();
            //Check error
            if (ev.Status != READ_CARD_STATUS.SUCCESS)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ev.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Show data
            if (_reader.CardData.Dg2File != null && !string.IsNullOrEmpty(_reader.CardData.Dg2File.FaceImage))
            {
                //Chip image
                var faceStr = _reader.CardData.Dg2File.FaceImage;
                var chipFaceBase64 = faceStr[(faceStr.IndexOf(',') + 1)..];
                _ChipFaceBts = Convert.FromBase64String(chipFaceBase64);
                using (var ms = new MemoryStream(_ChipFaceBts))
                {
                    picChipImage.Image = Image.FromStream(ms);
                }
                //Personal info
                txtDocumentNumber.Text = "Số CCCD: " + _reader.CardData.Dg13File.DocumentNumber;
                txtDateOfBirth.Text = "Ngày sinh: " + _reader.CardData.Dg13File.DateOfBirth;
                txtIssueDate.Text = "Ngày cấp: " + _reader.CardData.Dg13File.IssueDate;
                txtPreviousNumber.Text = "Số CMND cũ: " + _reader.CardData.Dg13File.PreviousNumber;
                txtName.Text = "Họ tên: " + _reader.CardData.Dg13File.Name;
                txtSex.Text = "Giới tính: " + _reader.CardData.Dg13File.Sex;
                txtNationality.Text = "Quốc tịch: " + _reader.CardData.Dg13File.Nationality;
                txtNation.Text = "Dân tộc: " + _reader.CardData.Dg13File.Nation;
                txtReligion.Text = "Tôn giáo: " + _reader.CardData.Dg13File.Religion;
                txtHometown.Text = "Quê quán: " + _reader.CardData.Dg13File.Hometown;
                txtAddress.Text = "Địa chỉ: " + _reader.CardData.Dg13File.Address;
                txtCharacter.Text = "Đặc điểm ND: " + _reader.CardData.Dg13File.Character;
                txtExpiredDate.Text = "Ngày hết hạn: " + _reader.CardData.Dg13File.ExpiredDate;
                txtFatherName.Text = "Bố: " + _reader.CardData.Dg13File.FatherName;
                txtMotherName.Text = "Mẹ: " + _reader.CardData.Dg13File.MotherName;
                txtPartnerName.Text = "Vợ/Chồng: " + _reader.CardData.Dg13File.PartnerName;
                //MRZ
                if (_reader.CardData.Dg1File != null)
                {
                    txtMRZ.Text = "MRZ: " + _reader.CardData.Dg1File.Mrz;
                }
                txtDSCert.Text = "DSCert: " + _reader.CardData.DSCert;
                //VerifySOD
                WriteLog($"Verify SOD: {_reader.CardData.VerifySOD}");

                //Active/Chip Authentication
                WriteLog($"Chip Authen: {_reader.CardData.AaCaAuthen}");

                //Raw DATA
                /*
                _reader.CardData.EfCom
                _reader.CardData.Dg1 ...
                _reader.CardData.Dg15
                _reader.CardData.Sod
                */
            }
        }
        private void ProcessReadEvent(StatusEventReadArgs? ev)
        {
            try
            {
                if (ev == null)
                    return;
                WriteLog($"----> [{DateTime.Now.ToString("HH:mm:ss")}] Device {ev.ReaderSerialNumber} do step: {ev.Step}; status: {ev.Status}; message={ev.Message}.");
                switch (ev.Step)
                {
                    case READ_CARD_STEPS.SCANCARD:
                        OnScancardEvent(ev);
                        break;
                    case READ_CARD_STEPS.START:
                    case READ_CARD_STEPS.CONNECT_CARD:
                    case READ_CARD_STEPS.PACE:
                    case READ_CARD_STEPS.READ_DGS:
                    case READ_CARD_STEPS.VERIFY_SOD:
                    case READ_CARD_STEPS.AACA_AUTHEN:
                        break;
                    case READ_CARD_STEPS.FINISH:
                        OnReadCardFinish(ev);
                        break;
                }
            }
            catch (Exception)
            {

            }
        }
        private void ProcessScanEvent(ScanEventArgs? args)
        {
            //Display Scan image
            try
            {
                if (args == null)
                    return;
                using (var ms = new MemoryStream(args.FrontData))
                {
                    picIdcardFront.Image = Image.FromStream(ms);
                }
                using (var ms = new MemoryStream(args.BackData))
                {
                    pictureIdcardBack.Image = Image.FromStream(ms);
                }
            }
            catch (Exception)
            {

            }
        }
        private void Reader_OnStatusChanged(object sender, StatusEventArgs e)
        {
            //Call from other thread
            if (this.InvokeRequired)
            {
                this.Invoke((MethodInvoker)(() =>
                {
                    OnEvent(sender, e);
                }));
            }
            else
            {
                OnEvent(sender, e);
            }
        }

        private void btnFaceMatching_Click(object sender, EventArgs e)
        {
            picCamera.Image = null;
            _CamFaceBts = null;
            if (cbFaceCameras.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn Camera chụp ảnh khuôn mặt!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Change config
            _reader.ReaderConfig.AutoCaptureFaceEnabled = chkAutocapture.Checked;
            _reader.ReaderConfig.AutoCaptureFaceMinimumMs = (int)numFaceDurationTime.Value;
            _reader.ReaderConfig.CaptureFaceCameraPath = ((CameraDevice)cbFaceCameras.SelectedItem).Id;
            _reader.ReaderConfig.CaptureFaceTimeout = (int)numFaceTimeout.Value;
            _reader.FaceCaptureCamId = _reader.ReaderConfig.CaptureFaceCameraPath;

            var reader = _reader;
            CaptureFace frm = new CaptureFace(_reader);
            frm.ShowDialog();
            //Show Face
            try
            {
                if (frm.FaceImage != null)
                {
                    _CamFaceBts = frm.FaceImage.ToArray();
                    using (var ms = new MemoryStream(frm.FaceImage))
                    {
                        picCamera.Image = Image.FromStream(ms);
                    }
                }
            }
            catch (Exception) { }

            if (frm.Status != FACE_CAPTURE_STATAUS.SUCCESS)
            {
                string reason = "UNKNOWN";
                switch (frm.FaceType)
                {
                    case FACE_DETECT_TYPES.FAIL_SPOOR_FACE:
                        reason = "NO-REAL";
                        break;
                    case FACE_DETECT_TYPES.FAIL_NO_FACE:
                        reason = "NO-FACE";
                        break;
                    case FACE_DETECT_TYPES.FAIL_MULTI_FACE:
                        reason = "MULTI-FACE";
                        break;
                    default:
                        break;
                }

                lbFaceMatching.Text = $"{reason}";
                lbFaceMatching.ForeColor = Color.Red;
                MessageBox.Show(frm.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //if (_reader.ReaderConfig.CaptureFaceCompare)
            //{
            //    lbFaceMatching.Text = frm.CompareScore >= 60 ? $"YES ({frm.CompareScore}%)" : $"NO ({frm.CompareScore}%)";
            //    lbFaceMatching.ForeColor = frm.CompareScore >= 60 ? Color.Blue : Color.Red;
            //}
            //else
            {
                lbFaceMatching.Text = "";
                lbFaceMatching.ForeColor = Color.Blue;
            }
        }

        private void btnClearForm_Click(object sender, EventArgs e)
        {
            ResetFormInfo();
        }

        private void btnReadQR_Click(object sender, EventArgs e)
        {
            // QRForm frm = new QRForm(_reader);
            // frm.ShowDialog();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _reader.StopMonitor();
        }

        private void TxtFastRead_CheckedChanged(object sender, EventArgs e)
        {
            _reader.ReaderConfig.DoVerifySOD = !txtFastRead.Checked;
            _reader.ReaderConfig.CheckAACAAuthen = !txtFastRead.Checked;
        }

        private void chkAutocapture_CheckedChanged(object sender, EventArgs e)
        {
            numFaceDurationTime.Enabled = chkAutocapture.Checked;
        }

        private void LoadExternalCameras()
        {
            if (_reader.Hn212Device == null || _reader.Hn212Device.OcrCam.IsEmpty())
                return;
            if (cbFaceCameras.Items.Count > 0)
                return;
            btnRefreshCamera_Click(new object(), new EventArgs());
        }



        private void btnRefreshCamera_Click(object sender, EventArgs e)
        {
            if (_reader.Hn212Device == null)
                return;
            cbFaceCameras.DataSource = null;
            var cams = _reader.GetCameraList(false);
            cbFaceCameras.DataSource = cams;
            cbFaceCameras.DisplayMember = "Name";
            cbFaceCameras.ValueMember = "Id";
            if (cbFaceCameras.Items.Count > 0)
            {
                cbFaceCameras.SelectedIndex = 0;
                //set facecam id
                _reader.FaceCaptureCamId = (cams[0].Id);
            }
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            if (_ChipFaceBts == null || _CamFaceBts == null)
            {
                MessageBox.Show("Vui lòng chụp ảnh và đọc thẻ chip trước!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                int score = _reader.CompareFace(_ChipFaceBts, _CamFaceBts);
                lbFaceMatching.Text = score >= 60 ? $"YES ({score}%)" : $"NO ({score}%)";
                if (score < 60)
                    lbFaceMatching.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkAutoRead_CheckedChanged(object sender, EventArgs e)
        {
            _reader.ReaderConfig.AutoReadWhenPresent = chkAutoRead.Checked;
        }

        //Change reader type
        private void CbReaderTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            picIdcardFront.Visible = cbReaderTypes.SelectedIndex > 0;
            pictureIdcardBack.Visible = cbReaderTypes.SelectedIndex > 0;
            btnRejectCard.Visible = cbReaderTypes.SelectedIndex > 0;

            _reader.Hn212Device.SetSupportDeviceType(cbReaderTypes.SelectedIndex == 0 ? DeviceTypes.DeviceTypesHN212 : DeviceTypes.DeviceTypesScan);
        }

        private void btnRejectCard_Click(object sender, EventArgs e)
        {
            _reader.RejectCard(true, true);
        }

        private void cbAntiSpoofing_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbAntiSpoofing.SelectedIndex >= 0 && cbAntiSpoofing.SelectedIndex <= (int)HN212SpoofMode.HIGH)
                _reader.FaceAntiSpoofMode = ((HN212SpoofMode)cbAntiSpoofing.SelectedIndex);
        }

        private void cbFaceCameras_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFaceCameras.SelectedValue is string)
                _reader.FaceCaptureCamId = cbFaceCameras.SelectedValue.ToString();
        }

        private void cbProcessStep_SelectedIndexChanged(object sender, EventArgs e)
        {
            _reader.ReaderConfig.ProcessSequence =
                cbProcessStep.SelectedIndex == 0 ? HN212ProSeq.CardOnly : HN212ProSeq.CardThenFace;
        }

        private void chkPaused_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPaused.Checked)
                _reader.Pause();
            else
                _reader.Resume();
        }

        private void numFaceDurationTime_ValueChanged(object sender, EventArgs e)
        {
        }

        private void cbOcrMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            _reader.OcrMode = (HN212OcrMode)(cbOcrMode.SelectedIndex + 1);
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            _reader.Transaction(true);
        }

        private void btnCompareTest_Click(object sender, EventArgs e)
        {
            EKycForm frm = new EKycForm();
            frm.ShowDialog();
        }
    }
}