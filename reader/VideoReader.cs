using RAR.IdCard.Sdk.Reader;
using RAR.IdCard.Sdk.Reader.HN212;

namespace IdCard.Hanel_obj.reader
{
    public enum CaptureResult
    {
        UNKNOWN = 0,
        SUCCESS = 2,
        FAILURE = 3,
        IGNORE = 4
    };


    public class VideoReader
    {

        VnHn212Reader _reader;

        public FACE_CAPTURE_STATAUS Status { get; set; } = FACE_CAPTURE_STATAUS.UNKNOWN;
        public FACE_DETECT_TYPES FaceType { get; set; } = FACE_DETECT_TYPES.UNKNOWN;

        public byte[]? FaceImage { get; set; } = null;

        public string Message { get; set; } = "";

        public delegate void OnFrame(byte[] newImg);
        public delegate void OnResult(CaptureResult ev);


        public event OnFrame? OnUpdateFrameEvent;

        public event OnResult? OnResultEvent;

        // dotnet add package System.Drawing.Common
        public Image? Image { get; set; }

        public VideoReader(VnHn212Reader reader)
        {
            _reader = reader;
            _reader.OnVideoFrame += OnEvent;
            _reader.FaceCaptureCamId = GetCamPath();
        }

        ~VideoReader()
        {
            // Unsubscribe from the event to avoid memory leaks
            if (_reader != null)
            {
                StopCapture();

                _reader.StopFaceCapture();
                _reader.OnVideoFrame -= OnEvent;
            }
        }

        private void OnEvent(object sender, StatusEventArgs e)
        {
            if (e is not CaptureEventArgs vd)
                return;
            FaceType = vd.FaceType;
            FaceImage = vd.FaceData;


            switch (vd.Status)
            {
                case FACE_CAPTURE_STATAUS.CAPTURING:
                    {
                        try
                        {
                            //Display video on form
                            // using var ms = new MemoryStream(vd.FrameData);
                            // Image = Image.FromStream(ms);
                            // OnUpdateFrameEvent?.Invoke(Image);

                            OnUpdateFrameEvent?.Invoke(vd.FrameData);
                        }
                        catch (Exception) { }
                    }
                    break;
                case FACE_CAPTURE_STATAUS.FAILURE:
                    {
                        Status = FACE_CAPTURE_STATAUS.FAILURE;
                        Message = $"Error: " + vd.Message;

                        OnResultEvent?.Invoke(CaptureResult.FAILURE);
                        //Close this form
                        // this.Close();
                    }
                    break;
                case FACE_CAPTURE_STATAUS.SUCCESS:
                    {
                        Status = FACE_CAPTURE_STATAUS.SUCCESS;
                        Message = $"FaceCapture success";
                        OnResultEvent?.Invoke(CaptureResult.SUCCESS);
                        //Close this form
                        // this.Close();
                    }
                    break;
                case FACE_CAPTURE_STATAUS.IGNORE:
                    {
                        Status = FACE_CAPTURE_STATAUS.IGNORE;
                        Message = vd.Message;
                        OnResultEvent?.Invoke(CaptureResult.IGNORE);
                        //Close this form
                        // this.Close();
                    }
                    break;
                default:
                    break;
            }
        }


        public void StartCapture(string camPath = "")
        {
            if (camPath == "")
            {
                var cams = _reader.GetCameraList(false);
                if (cams == null || cams.Count == 0)
                {
                    return;
                }
                camPath = cams[0].Id;
            }

            _reader.ReaderConfig.AutoCaptureFaceEnabled = true;
            _reader.ReaderConfig.AutoCaptureFaceMinimumMs = 200;
            _reader.ReaderConfig.CaptureFaceCameraPath = camPath;
            _reader.ReaderConfig.CaptureFaceTimeout = 10000;
            _reader.FaceCaptureCamId = camPath;


            _reader.OnVideoFrame += OnEvent;
            _reader.StartFaceCapture();
        }

        public void StopCapture()
        {
            _reader.StopFaceCapture();
        }

        public string GetCamPath()
        {
            var cams = _reader.GetCameraList(false);
            if (cams == null || cams.Count == 0)
            {
                return "";
            }
            return cams[0].Id;
        }

    }
}
