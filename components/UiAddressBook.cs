using IdCard.Hanel.Models;
using IdCard.Hanel_obj.components.common;
using IdCard.Hanel_obj.components.forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace IdCard.Hanel_obj.components
{
    public partial class UiAddressBook : UserControl
    {
        private CustomerRepository _customerRepo = new(AuthenCardDbContext.Instance);
        private InOutLogRepository _ioRepo = new(AuthenCardDbContext.Instance);


        int _page = 1;
        int _pageSize = 10;
        int _total = 0;

        private DateTime? _from = null;
        private DateTime? _to = null;

        private List<CustomerExtend> _customers = new();


        public List<CustomerTransformTable> _dataTables = new();


        public UiAddressBook()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            dgvCustomer.CellClick += DgvLogIO_MoreDetail;
            dgvCustomer.CellPainting += dgvCustomer_CellPainting;
            dgvCustomer.CellMouseMove += dgvCustomer_CellMouseMove;

            DateTime now = DateTime.Now;
            lbDate.Text = $"{now:dd/MM/yyyy}";
            string[] weekdays = { "Chủ nhật", "Thứ 2", "Thứ 3", "Thứ 4", "Thứ 5", "Thứ 6", "Thứ 7" };
            string formatted = $"{weekdays[(int)now.DayOfWeek]}, {now:dd/MM/yyyy}";
            date.Text = formatted;

            //LoadData(1);
            GenerateMockData();
            uiPaginition1.OnPageChanged += OnPageChange;
        }

        private void OnPageChange(int newPage)
        {
            _page = newPage;
            LoadData(newPage);
        }

        private void LoadData(int newPage)
        {
            try
            {
                int skip = (newPage - 1) * _pageSize;
                var rs = _customerRepo.GetCustomers(_from, _to);

                _total = rs.Total;
                _page = newPage;
                _customers = rs.Data;

                _dataTables.Clear();
                for (int i = 0; i < rs.Data.Count; i++)
                {
                    var latest = _ioRepo.GetByCCCD(null, null, rs.Data[i].Id);
                    var trans = new CustomerTransformTable(_total - i - skip, rs.Data[i]);
                    if (latest.Count > 0)
                    {
                        trans.LatestVisit = latest[0].CheckInTime;
                    }
                    _dataTables.Add(trans);

                }
                ManualUpdateData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load data failed: ", ex.ToString());
            }

        }


        private void ManualUpdateData()
        {
            // Manually map _logTrans to dgvLogIO
            dgvCustomer.Rows.Clear(); // Clear existing rows
            for (int i = 0; i < _dataTables.Count; i++)
            {
                var rowData = _dataTables[i];
                int rowIndex = dgvCustomer.Rows.Add();
                var row = dgvCustomer.Rows[rowIndex];

                row.Cells["STT"].Value = i + 1;
                row.Cells["FullName"].Value = rowData.FullName;
                row.Cells["LatestVisit"].Value = rowData.LatestVisit;
                row.Cells["TotalVisit"].Value = rowData.TotalVisit;
                row.Cells["BtnMoreDetail"] = new DataGridViewButtonCell
                {
                    Value = "Xem Chi Tiết"
                };
            }
        }



        private void DgvLogIO_MoreDetail(object? sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is in the action button column
            if (e.RowIndex >= 0 && dgvCustomer.Columns[e.ColumnIndex].Name == "BtnMoreDetail")
            {
                var ctm = _customers[e.RowIndex];
                var history = new DialogCustomerHistories(ctm.Id);

                // Lấy kích thước màn hình chính
                var screenHeight = Screen.PrimaryScreen.WorkingArea.Height;

                // Nếu nhỏ hơn 1000 thì set theo chiều cao màn hình, ngược lại set 1000
                history.Height = screenHeight < 1000 ? screenHeight : 1000;
                history.StartPosition = FormStartPosition.CenterScreen;
                history.ShowDialog();
            }
        }

        private void DtFilter_ValueChanged(object sender, EventArgs e)
        {
            _from = dtFilter.Value.Date;
            _to = dtFilter.Value.Date.AddDays(1).AddSeconds(-1);
            LoadData(_page);
        }

        private void lbDate_Click(object sender, EventArgs e)
        {

        }


        private void GenerateMockData()
        {
            _dataTables.Clear();
            _customers.Clear();

            for (int i = 1; i <= 100; i++)
            {
                var mockCustomer = new CustomerExtend
                {
                    Id = Guid.NewGuid().ToString(),
                    HoTen = $"Khách hàng {i}",
                    CreatedAt = DateTime.Today.AddDays(-i),
                    InOutLogCount = i % 10 + 1,
                    InOutLogs = new List<InOutLog>
            {
                new InOutLog { CheckInTime = DateTime.Today.AddMinutes(-i * 10) }
            }
                };

                _customers.Add(mockCustomer);

                var trans = new CustomerTransformTable(i, mockCustomer);
                _dataTables.Add(trans);
            }

            uiPaginition1.TotalPages = (_dataTables.Count + _pageSize - 1) / _pageSize;
            uiPaginition1.CurrentPage = 1;

            ManualUpdateData();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvCustomer_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
          

            if (e.RowIndex >= 0 && dgvCustomer.Columns[e.ColumnIndex].Name == "BtnMoreDetail" && e.Value != null)
            {
                e.Handled = true;
                e.PaintBackground(e.ClipBounds, false);

                string text = e.Value.ToString();
                Font font = new Font(e.CellStyle.Font, FontStyle.Underline);
                Color linkColor = Color.Black;

                using (SolidBrush brush = new SolidBrush(linkColor))
                {
                    StringFormat format = new StringFormat
                    {
                        Alignment = StringAlignment.Center,
                        LineAlignment = StringAlignment.Center
                    };

                    e.Graphics.DrawString(text, font, brush, e.CellBounds, format);
                }

                e.Paint(e.ClipBounds, DataGridViewPaintParts.Border);
            }

        }


        private void dgvCustomer_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvCustomer.Columns[e.ColumnIndex].Name == "BtnMoreDetail")
            {
                dgvCustomer.Cursor = Cursors.Hand;
            }
            else
            {
                dgvCustomer.Cursor = Cursors.Default;
            }
        }


    }



    public class CustomerTransformTable
    {
        public int STT { set; get; }
        public string FullName { set; get; } = string.Empty;
        public DateTime LatestVisit { set; get; }
        public int TotalVisit { set; get; }


        public CustomerTransformTable(int stt, CustomerExtend ctm)
        {
            STT = stt;
            FullName = ctm.HoTen;
            LatestVisit = ctm.InOutLogs?.Count > 0 ? ctm.InOutLogs[0].CheckInTime : ctm.CreatedAt;
            TotalVisit = ctm.InOutLogCount;
        }
    }
}
