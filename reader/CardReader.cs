using IdCard.Hanel.Models;
using RAR.IdCard.Sdk.Reader;
using RAR.IdCard.Sdk.Reader.HN212;


namespace IdCard.Hanel_obj.reader
{

    public class ReaderSerial
    {
        public ushort Company { get; set; } = 0;
        public uint Device { get; set; } = 0;

        public ReaderSerial(ushort company, uint device)
        {
            Company = company;
            Device = device;
        }

        public ReaderSerial(string serialNumber)
        {
            try
            {

                if (string.IsNullOrEmpty(serialNumber) || serialNumber.Length < 2)
                    return;

                var part = serialNumber.Split("-");
                var latestPart = part[part.Length - 1];

                if (latestPart.Length < 2)
                    return;

                Company = ushort.Parse(latestPart[..2]);
                Device = uint.Parse(latestPart[2..]);
            }
            catch
            {

            }
        }
    }

    public class CardReader
    {
        //VnHn212Reader _reader = new VnHn212Reader; //Tạo object

        private readonly VnHn212Reader _reader;

        public delegate void CardInEvent(StatusEventCardArgs ev);

        public delegate void ReadCardDoneEvent(Customer? customer);

        public delegate void DetectDeviceEvent(ReaderSerial serial);

        public string SerialNumber { get; private set; } = "";

        public event CardInEvent? OnCardIn;

        public event ReadCardDoneEvent? OnReadCardDone;
        public event DetectDeviceEvent? OnDetectDevice;

        public CardReader(VnHn212Reader reader)
        {
            _reader = reader;
            _reader.OnStatusChanged += OnStatusChanged;
        }

        public void OnStatusChanged(object sender, StatusEventArgs e)
        {
            Console.WriteLine("On status change");
            OnEvent(sender, e);
        }

        public void OnVideoFrame(object sender, StatusEventArgs e)
        {
            Console.WriteLine("On status change");
        }

        private void OnEvent(object sender, StatusEventArgs e)
        {
            switch (e.EventName)
            {
                case EVENT_NAMES.READER:
                    ProcessReaderEvent(e as StatusEventReaderArgs);
                    //Console.WriteLine("On status change:READER");
                    break;
                case EVENT_NAMES.CARD:
                    ProcessCardEvent(e as StatusEventCardArgs);
                    Console.WriteLine("On status change: CARD");
                    break;
                case EVENT_NAMES.READ:
                    ProcessReadEvent(e as StatusEventReadArgs);
                    Console.WriteLine("On status change: READ");
                    break;
                case EVENT_NAMES.SCAN:
                    //ProcessScanEvent(e as ScanEventArgs);
                    Console.WriteLine("On status change: SCAN");
                    break;
                case EVENT_NAMES.READER_CAMERA:

                    //ProcessCameraEvent(e as StatusEventCameraArgs);
                    Console.WriteLine("On status change: READER_CAMERA");
                    break;
            }
        }

        private void ProcessReaderEvent(StatusEventReaderArgs? ev)
        {
            if (ev == null)
                return;
            SerialNumber = ev.ReaderSerialNumber;
            this.OnDetectDevice?.Invoke(new ReaderSerial(ev.ReaderSerialNumber));
        }

        private void ProcessCardEvent(StatusEventCardArgs? ev)
        {
            if (ev == null)
                return;

            //lbCardStatus.Text = (ev.NewState == CARD_STATUS.EMPTY) ? "Không có" : "Có thẻ";
            //lbCardStatus.ForeColor = (ev.NewState == CARD_STATUS.EMPTY) ? Color.Red : Color.Green;

            //Have new card, start timer to show time processing
            if (ev.NewState == CARD_STATUS.PRESENT)
            {
                OnCardIn?.Invoke(ev);
            }

            else if (ev.NewState == CARD_STATUS.EMPTY)
            {

            }
        }

        private void OnReadCardFinish(StatusEventReadArgs ev)
        {
            //Show data
            if (_reader.CardData.Dg2File != null && !string.IsNullOrEmpty(_reader.CardData.Dg2File.FaceImage))
            {
                var ctm = GetCustomer();
                OnReadCardDone?.Invoke(ctm); // Call OnCustomer delegate
            }
        }

        private Customer GetCustomer()
        {
            var dob = DateTime.TryParseExact(_reader.CardData.Dg13File.DateOfBirth, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out var ngaySinh) ? ngaySinh : default;
            var issueDate = DateTime.TryParseExact(_reader.CardData.Dg13File.IssueDate, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out var ngayCap) ? ngayCap : default;
            var expiredDate = DateTime.TryParseExact(_reader.CardData.Dg13File.ExpiredDate, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out var ngayHetHan) ? ngayHetHan : default;

            var faceStr = _reader.CardData.Dg2File.FaceImage;
            var chipFaceBase64 = faceStr[(faceStr.IndexOf(',') + 1)..];

            //Personal info
            var ctm = new Customer
            {
                Id = _reader.CardData.Dg13File.DocumentNumber,
                NgaySinh = dob,
                NgayCap = issueDate,
                NgayHetHan = expiredDate,
                HinhAnh = Convert.FromBase64String(chipFaceBase64),
                CMNDCu = _reader.CardData.Dg13File.PreviousNumber ?? "",
                HoTen = _reader.CardData.Dg13File.Name ?? "",
                GioiTinh = _reader.CardData.Dg13File.Sex ?? "",
                QuocTich = _reader.CardData.Dg13File.Nationality ?? "",
                DanToc = _reader.CardData.Dg13File.Nation ?? "",
                TonGiao = _reader.CardData.Dg13File.Religion ?? "",
                QueQuan = _reader.CardData.Dg13File.Hometown ?? "",
                DiaChi = _reader.CardData.Dg13File.Address ?? "",
                DacDiemND = _reader.CardData.Dg13File.Character ?? "",
                Bo = _reader.CardData.Dg13File.FatherName ?? "",
                Me = _reader.CardData.Dg13File.MotherName ?? "",
                VoChong = _reader.CardData.Dg13File.PartnerName ?? "",
                Mrz = _reader.CardData.Dg1File.Mrz ?? "",
            };

            return ctm;
        }

        private void ProcessReadEvent(StatusEventReadArgs? ev)
        {
            try
            {
                if (ev == null)
                    return;
                switch (ev.Step)
                {
                    case READ_CARD_STEPS.SCANCARD:
                        // OnScanCardEvent(ev);
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


        // private void OnScanCardEvent(StatusEventReadArgs ev)
        // {
        // }

    }
}
