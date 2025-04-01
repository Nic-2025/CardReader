using RAR.IdCard.Sdk.Reader.HN212;
namespace AuthenCard.reader
{
    public class AuthReader
    {
        public VnHn212Reader Reader = new();
        public CardReader CardReader { get; }


        public VideoReader VideoReader { get; }

        public AuthReader()
        {
            CardReader = new CardReader(Reader);
            VideoReader = new VideoReader(Reader);

            InitReader();
        }


        public void Close()
        {
            this.Reader.StopMonitor();
        }

        private void InitReader()
        {

            //Reader.OnStatusChanged += OnStatusChanged;
            //_reader.OnVideoFrame += OnVideoFrame;


            // var config = new VnPcscsConfig();
            var config = new VnHn212Config
            {
                /* set this to false: input access code or scan & read as required
                 * true: Auto scan card & read data*/
                //AutoReadWhenPresent = true,

                /*Set this flag to process VerifySOD*/
                DoVerifySOD = false,

                /*Set this flag to process AA/CA Authen*/
                CheckAACAAuthen = false,

                /* Capture face, Minimum time have real face*/
                /* Default is 200ms */
                AutoCaptureFaceMinimumMs = 200,

                //HidLibUsed = HN212HidLibrary.HidApi,

                /* Retry count */
                ReadCardRetryCount = 2,

                /* Seq */
                ProcessSequence = HN212ProSeq.CardOnly,

                OcrMode = HN212OcrMode.FAST,

                // config.HidLibUsed = HN212HidLibrary.Auto;

                CaptureFaceUseFirstCamAvaiable = true,

                MonitorQRReaderDevice = true,

            };

            /*Start reader monitoring ...*/
            Reader.StartMonitor(config);
        }

    }
}
