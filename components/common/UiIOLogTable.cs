using IdCard.Hanel.Models;
using IdCard.Hanel_obj.components.forms;

namespace IdCard.Hanel_obj.components.common
{
    public partial class UiIOLogTable : UserControl
    {
        private readonly InOutLogRepository _ioRepo = new(AuthenCardDbContext.Instance);
        //private CustomerRepository _ctmRepo = new CustomerRepository(AuthenCardDbContext.Instance);

        //int _total = 0;
        //int _page = 1;

        DateTime? _from;
        DateTime? _to;
        IOStatus? _status;

        private List<InOutLog> _logs = new List<InOutLog>();
        private List<LogTransform> _logTrans = new List<LogTransform>();

        public DateTime? From { set => SetFrom(value); get => _from; }
        public DateTime? To { set => SetTo(value); get => _to; }
        public IOStatus? Status { set => SetStatus(value); get => _status; }

        public int CurrentPage { get => uiPaginition1.CurrentPage; }


        public int Limit { get; set; } = 1;

        public UiIOLogTable()
        {
            InitializeComponent();

            // Make dgvLogIO non-editable
            dgvLogIO.ReadOnly = true;
            dgvLogIO.CellClick += DgvLogIO_ViewDetail;
            //dgvLogIO.AllowUserToAddRows = false;
            //dgvLogIO.AllowUserToDeleteRows = false;

            this.Load += OnLoadDone;
        }

        private void OnLoadDone(object? sender, EventArgs e)
        {
            LoadData(1);
            this.uiPaginition1.OnPageChanged += (v) =>
            {
                this.LoadData(v);
            };
        }

        public DataWCount<InOutLog> LoadData(int newPage)
        {
            int skip = (newPage - 1) * Limit;
            var rs = _ioRepo.GetList(From, To, skip, Limit, status: _status);


            _logs = rs.Data;

            uiPaginition1.CurrentPage = newPage;
            uiPaginition1.TotalPages = (rs.Total / Limit) + (rs.Total % Limit > 0 ? 1 : 0);

            _logTrans.Clear();
            for (int i = 0; i < _logs.Count; i++)
                _logTrans.Add(new LogTransform(_logs[i], rs.Total - i - skip));

            this.ManualUpdateData(skip);

            return rs;
        }

        private void SetFrom(DateTime? value)
        {
            _from = value;
            this.LoadData(1);
        }


        private void SetTo(DateTime? value)
        {
            _to = value;
            this.LoadData(1);
        }


        private void SetStatus(IOStatus? value)
        {
            _status = value;
            this.LoadData(1);
        }

        private void ManualUpdateData(int skip)
        {
            // Manually map _logTrans to dgvLogIO
            dgvLogIO.Rows.Clear(); // Clear existing rows
            for (int i = 0; i < _logTrans.Count; i++)
            {
                var log = _logTrans[i];
                int rowIndex = dgvLogIO.Rows.Add();
                var row = dgvLogIO.Rows[rowIndex];

                row.Cells["STT"].Value = log.STT;
                row.Cells["HoTen"].Value = log.HoTen;
                row.Cells["CCCD"].Value = log.CCCD;
                row.Cells["SignedIn"].Value = log.SignedIn;
                row.Cells["SignedOut"].Value = log.SignedOut;
                row.Cells["TrangThai"].Value = log.TrangThai;
                row.Cells["BtnChiTiet"] = new DataGridViewButtonCell
                {
                    Value = "Xem Chi Tiết"
                }; ;

                // Add a delegate for the button click event
                // dgvLogIO.CellClick += (s, e) =>
                // {
                //     if (e.RowIndex >= 0 && dgvLogIO.Columns[e.ColumnIndex].Name == "BtnChiTiet")
                //     {
                //         var logDetail = _logs[e.RowIndex];
                //         MessageBox.Show($"Details for ID: {logDetail.Id}");
                //     }
                // };
            }
        }

        private void DgvLogIO_ViewDetail(object? sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is in the action button column
            if (e.RowIndex >= 0 && dgvLogIO.Columns[e.ColumnIndex].Name == "BtnChiTiet")
            {
                var log = _logs[e.RowIndex];
                var formDetail = new FormIoLogDetail(log.Id);
                formDetail.Width = 600; formDetail.Height = 1200;
                formDetail.ShowDialog();
            }
        }

        private void BtnReload_Click(object sender, EventArgs e)
        {
            this.LoadData(uiPaginition1.CurrentPage);
        }
    }

    class LogTransform
    {
        public int STT { get; set; } = 0;

        public string HoTen { get; set; } = string.Empty;

        public string CCCD { get; set; } = string.Empty;

        public string SignedIn { get; set; } = string.Empty;

        public string SignedOut { get; set; } = string.Empty;

        public string TrangThai { get; set; } = string.Empty;

        // public LogTransform() { }

        public LogTransform(InOutLog data, int stt)
        {
            STT = stt;
            HoTen = data.Customer?.HoTen ?? "";
            CCCD = data.CustomerId;
            SignedIn = data.CheckInTime.ToString("HH:mm");
            SignedOut = data.CheckOutTime?.ToString("HH:mm") ?? "--:--";
            TrangThai = data.CheckOutTime == null ? "Signed In" : (data.ManualSignOut == 0 ? "Signed Out" : "Signed Out");
        }
    }

}
