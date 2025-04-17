using DocumentFormat.OpenXml.Spreadsheet;
using IdCard.Hanel.Models;
using IdCard.Hanel_obj.components.forms;
using System.Drawing.Drawing2D;
using System.IO;

namespace IdCard.Hanel_obj.components.common
{
    public partial class UiIOLogTable : UserControl
    {
        private readonly InOutLogRepository _ioRepo = new(AuthenCardDbContext.Instance);
        private readonly AdditionFieldRepository _additionFieldRepo = new(AuthenCardDbContext.Instance);
        //private CustomerRepository _ctmRepo = new CustomerRepository(AuthenCardDbContext.Instance);

        //int _total = 0;
        //int _page = 1;

        DateTime? _from;
        DateTime? _to;
        IOStatus? _status;
        string _searchHoTen = "";

        private List<InOutLog> _logs = new List<InOutLog>();
        private List<LogTransform> _logTrans = new List<LogTransform>();

        public DateTime? From { set => SetFrom(value); get => _from; }
        public DateTime? To { set => SetTo(value); get => _to; }
        public IOStatus? Status { set => SetStatus(value); get => _status; }

        public string Search { set => SetSearch(value); get => _searchHoTen; }

        public int CurrentPage { get => uiPaginition1.CurrentPage; }

        private List<InOutLog> _mockLogs = new();


        public int Limit { get; set; } = 10;

        public UiIOLogTable()
        {
            InitializeComponent();

            // Make dgvLogIO non-editable
            dgvLogIO.ReadOnly = true;
            dgvLogIO.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvLogIO.CellClick += DgvLogIO_ViewDetail;
#pragma warning disable CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
            dgvLogIO.CellPainting += dgvLogIO_CellPainting;
#pragma warning restore CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
            dgvLogIO.CellMouseMove += dgvLogIO_CellMouseMove;


            //dgvLogIO.AllowUserToAddRows = false;
            //dgvLogIO.AllowUserToDeleteRows = false;

            this.Load += OnLoadDone;
        }

        private void OnLoadDone(object? sender, EventArgs e)
        {
            LoadData(1);
            //GenerateMockData();
            //LoadMockPagedData(1);
            this.uiPaginition1.OnPageChanged += (v) =>
            {
                this.LoadData(v);
                //this.LoadMockPagedData(v);

            };
        }

        public DataWCount<InOutLog> LoadData(int newPage)
        {
            int skip = (newPage - 1) * Limit;
            var rs = _ioRepo.GetList(From, To, skip, Limit, status: _status, hoTen: _searchHoTen != "" ? _searchHoTen : null);

            _logs = rs.Data;

            uiPaginition1.CurrentPage = newPage;
            uiPaginition1.TotalPages = (rs.Total / Limit) + (rs.Total % Limit > 0 ? 1 : 0);

            _logTrans.Clear();
            for (int i = 0; i < _logs.Count; i++)
                _logTrans.Add(new LogTransform(_logs[i], rs.Total - i - skip));

            int total = rs.Total;
            int signedIn = rs.Data.Count(x => x.CheckOutTime == null);
            int signedOut = rs.Data.Count(x => x.CheckOutTime != null);

            countAll.Text = $"{total}";
            countSignedIn.Text = $"{signedIn}";
            countSignedOut.Text = $"{signedOut}";

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
            //this.LoadMockPagedData(1);
        }


        private void SetStatus(IOStatus? value)
        {
            _status = value;
            this.LoadData(1);
            //this.LoadMockPagedData(1);

        }


        private void SetSearch(string value)
        {
            _searchHoTen = value;
            this.LoadData(1);
            //this.LoadMockPagedData(1);

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
                row.Cells["CCCD"].Style.WrapMode = DataGridViewTriState.True;
                row.Cells["SignedIn"].Value = log.SignedIn;
                row.Cells["SignedOut"].Value = log.SignedOut;
                row.Cells["TrangThai"].Value = log.TrangThai;
                row.Cells["BtnChiTiet"] = new DataGridViewTextBoxCell
                {
                    Value = "Xem Chi Tiết"
                };

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
                var formDetail = new FormIoLogDetail(log.Id)
                {
                    StartPosition = FormStartPosition.CenterScreen
                };
                formDetail.ShowDialog();
                this.LoadData(uiPaginition1.CurrentPage);
            }
        }

        private void BtnReload_Click(object sender, EventArgs e)
        {
            this.LoadData(uiPaginition1.CurrentPage);
        }


        private void GenerateMockData()
        {
            _mockLogs.Clear();

            for (int i = 1; i <= 100; i++) // 100 bản ghi giả
            {
                _mockLogs.Add(new InOutLog
                {
                    Id = Guid.NewGuid().ToString(),
                    CustomerId = $"01234567890{i:D3}",
                    Customer = new Customer { HoTen = $"Nguyễn Văn {i}" },
                    CheckInTime = DateTime.Today.AddMinutes(-i * 10),
                    CheckOutTime = (i % 3 == 0) ? null : DateTime.Today.AddMinutes(-i * 5),
                    ManualSignOut = i % 4 == 0 ? 1 : 0
                });
            }
        }

        private void LoadMockPagedData(int newPage)
        {
            int skip = (newPage - 1) * Limit;
            var paged = _mockLogs.Skip(skip).Take(Limit).ToList();

            _logs = paged;
            _logTrans = new List<LogTransform>();

            for (int i = 0; i < paged.Count; i++)
            {
                _logTrans.Add(new LogTransform(paged[i], _mockLogs.Count - skip - i));
            }

            uiPaginition1.CurrentPage = newPage;
            uiPaginition1.TotalPages = (_mockLogs.Count + Limit - 1) / Limit;

            ManualUpdateData(skip);
        }


        private void dgvLogIO_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvLogIO.Columns[e.ColumnIndex].Name == "TrangThai" && e.Value != null)
            {
                e.Handled = true;
                e.PaintBackground(e.ClipBounds, true);

                string status = e.Value?.ToString()?.ToLower()?.Trim() ?? string.Empty;
                System.Drawing.Color textColor = System.Drawing.Color.Black;
                string displayText = e.Value?.ToString() ?? string.Empty;

                switch (status)
                {
                    case "signed out":
                        textColor = ColorTranslator.FromHtml("red");
                        break;
                    case "signed in":
                        textColor = ColorTranslator.FromHtml("green");
                        break;
                    case "manual signed out":
                        textColor = ColorTranslator.FromHtml("yellow");
                        break;
                }

                System.Drawing.Font font = new(e.CellStyle.Font, FontStyle.Bold);

                using (SolidBrush brush = new(textColor))
                {
                    StringFormat format = new()
                    {
                        Alignment = StringAlignment.Near,          // canh trái (giữ nguyên mặc định)
                        LineAlignment = StringAlignment.Center     // canh giữa theo chiều dọc
                    };

                    Rectangle textRect = e.CellBounds;
                    textRect.X += 4; // Padding trái nhẹ cho đẹp

                    e.Graphics.DrawString(displayText, font, brush, textRect, format);
                }

                e.Paint(e.ClipBounds, DataGridViewPaintParts.Border);
            }

            if (e.RowIndex >= 0 && dgvLogIO.Columns[e.ColumnIndex].Name == "BtnChiTiet" && e.Value != null)
            {
                e.Handled = true;
                e.PaintBackground(e.ClipBounds, false);

                string text = e.Value?.ToString() ?? string.Empty;
                System.Drawing.Font font = new(e.CellStyle.Font, FontStyle.Underline);
                System.Drawing.Color linkColor = System.Drawing.Color.Black;

                using (SolidBrush brush = new(linkColor))
                {
                    StringFormat format = new()
                    {
                        Alignment = StringAlignment.Center,
                        LineAlignment = StringAlignment.Center
                    };

                    e.Graphics.DrawString(text, font, brush, e.CellBounds, format);
                }

                e.Paint(e.ClipBounds, DataGridViewPaintParts.Border);
            }

        }


        private void dgvLogIO_CellMouseMove(object? sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvLogIO.Columns[e.ColumnIndex].Name == "BtnChiTiet")
            {
                dgvLogIO.Cursor = Cursors.Hand;
            }
            else
            {
                dgvLogIO.Cursor = Cursors.Default;
            }
        }

        public void WriteToExcel(string excelTemplatePath)
        {
            var ioList = _ioRepo.GetList(From, To, 0, 50000, status: _status);
            var logs = ioList.Data;
            if (logs == null || logs.Count == 0)
            {
                MessageBox.Show("No data to export.", "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var fields = _additionFieldRepo.GetList();
            try
            {
                using SaveFileDialog saveFileDialog = new();
                saveFileDialog.Filter = "Excel Files|*.xlsx";
                saveFileDialog.Title = "Save Excel File";
                saveFileDialog.FileName = $"Export_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string outputFilePath = saveFileDialog.FileName;


                    // Load the template
                    using (var workbook = new ClosedXML.Excel.XLWorkbook(excelTemplatePath))
                    {
                        var worksheet = workbook.Worksheet(1); // Assuming the first sheet

                        // Start writing data from the second row
                        // int row = 2;

                        for (var i = 0; i < fields.Count; i++)
                        {
                            worksheet.Cell(7, 8 + i).Value = fields[i].Label ?? "";
                        }

                        int row = 8;
                        worksheet.Cell(4, 2).Value = $"Ngày {From?.ToString("dd/MM/yyyy")}";
                        worksheet.Cell(5, 2).Value = $"Số lượng: {ioList.Total}";
                        foreach (var log in logs)
                        {
                            worksheet.Cell(row, 2).Value = row - 8 + 1; // Stt
                            worksheet.Cell(row, 3).Value = log.Customer?.HoTen ?? ""; // Column 1: HoTen
                            worksheet.Cell(row, 4).Value = log.CustomerId; // Column 2: CCCD
                            worksheet.Cell(row, 5).Value = log.CheckInTime.ToString("HH:mm"); // Column 3: CheckInTime
                            worksheet.Cell(row, 6).Value = log.CheckOutTime?.ToString("HH:mm") ?? "--:--"; // Column 4: CheckOutTime
                            worksheet.Cell(row, 7).Value = log.ManualSignOut == 0 ? "Signed Out" : "Manual Signed Out"; // Column 5: Status

                            for (var i = 0; i < fields.Count; i++)
                            {
                                worksheet.Cell(row, 8 + i).Value = log.AdditionFields[fields[i].Label] ?? "";
                            }
                            row++;
                        }

                        // Save the file
                        workbook.SaveAs(outputFilePath);
                    }

                    MessageBox.Show("Data exported successfully to Excel.", "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while exporting to Excel: {ex.Message}", "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
