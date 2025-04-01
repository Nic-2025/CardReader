using RAR.IdCard.Sdk.Reader;
using RAR.IdCard.Sdk.Reader.HN212;

namespace IdCard.Hanel
{
    public partial class CaptureFace : Form
    {
        public FACE_CAPTURE_STATAUS Status { get; set; } = FACE_CAPTURE_STATAUS.UNKNOWN;
        public FACE_DETECT_TYPES FaceType { get; set; } = FACE_DETECT_TYPES.UNKNOWN;
        public String Message { get; set; } = "";
        public byte[]? FaceImage { get; set; } = null;
        private VnHn212Reader _reader;
        public CaptureFace(VnHn212Reader reader)
        {
            _reader = reader;
            InitializeComponent();
        }

        private void CaptureFace_Shown(object sender, EventArgs e)
        {
            if (_reader == null)
                return;

            string selectedCamId = _reader.ReaderConfig.CaptureFaceCameraPath;
            if (string.IsNullOrEmpty(selectedCamId))
            {
                MessageBox.Show("Không tìm thấy Camera để chụp ảnh khuôn mặt!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            //Add event handle
            _reader.OnVideoFrame += reader_OnVideoFrame;

            if (_reader != null)
                _reader.StartFaceCapture();
        }

        private void reader_OnVideoFrame(object sender, StatusEventArgs e)
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
        private void OnEvent(object sender, StatusEventArgs e)
        {
            CaptureEventArgs? vd = e as CaptureEventArgs;
            if (vd == null)
            {
                return;
            }

            this.FaceType = vd.FaceType;
            this.FaceImage = vd.FaceData;

            switch (vd.Status)
            {
                case FACE_CAPTURE_STATAUS.CAPTURING:
                    {
                        try
                        {
                            //Display video on form
                            using (var ms = new MemoryStream(vd.FrameData))
                            {
                                picFromCamera.Image = Image.FromStream(ms);
                            }
                        }
                        catch (Exception) { }
                    }
                    break;
                case FACE_CAPTURE_STATAUS.FAILURE:
                    {
                        Status = FACE_CAPTURE_STATAUS.FAILURE;
                        Message = $"Error: " + vd.Message;
                        //Close this form
                        this.Close();
                    }
                    break;
                case FACE_CAPTURE_STATAUS.SUCCESS:
                    {
                        Status = FACE_CAPTURE_STATAUS.SUCCESS;
                        Message = $"FaceCapture success";
                        //Close this form
                        this.Close();
                    }
                    break;
                case FACE_CAPTURE_STATAUS.IGNORE:
                    {
                        Status = FACE_CAPTURE_STATAUS.IGNORE;
                        Message = vd.Message;
                        //Close this form
                        this.Close();
                    }
                    break;
                default:
                    break;
            }
        }

        private void CaptureFace_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void CaptureFace_Load(object sender, EventArgs e)
        {
            btnCapture.Enabled = !_reader.ReaderConfig.AutoCaptureFaceEnabled;
        }

        private void btnCapture_Click(object sender, EventArgs e)
        {
            // _reader.ManualTakeFace();
        }

        private void CaptureFace_FormClosed(object sender, FormClosedEventArgs e)
        {
            // remove event handle
            _reader.OnVideoFrame -= reader_OnVideoFrame;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _reader.StopFaceCapture();
        }
    }
}
