using Castle.Core.Resource;
using IdCard.Hanel.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IdCard.Hanel_obj.components.forms
{
    public partial class DialogCustomerHistories : Form
    {
        private CustomerRepository ctmRepository = new(AuthenCardDbContext.Instance);
        private InOutLogRepository ioRepository = new(AuthenCardDbContext.Instance);
        private AdditionFieldRepository fieldsRepository = new(AuthenCardDbContext.Instance);


        private string _customerId = "";

        private Customer? _ctm;
        private List<AdditionField> _fields = new();
        private List<InOutLog> _logs = new();

        public DateTime From = new DateTime(2025, 04, 01);
        public DateTime To = DateTime.Now;

        private bool useMockData = true;



        public DialogCustomerHistories(string customerId)
        {
            
            _customerId = customerId;
            InitializeComponent();
            SetupDGVHistories();
            UpdateInfo();
            LoadData();
        }


        private void SetupDGVHistories()
        {
            _fields = fieldsRepository.GetList();
            dgvHistories.Columns.Clear();
            dgvHistories.Columns.Add("VisitDay", "Ngày visit");
            dgvHistories.Columns.Add("SignedIn", "Signed In");
            dgvHistories.Columns.Add("SignedOut", "Signed out");

            for (int i = 0; i < _fields.Count; i++)
            {
                var field = _fields[i];
                dgvHistories.Columns.Add($"field_{i}", field.Label);
            }

            dgvHistories.Columns.Add("Image", "Ảnh signed in");
            dgvHistories.CellPainting += dgvHistories_CellPainting;
            dgvHistories.CellMouseMove += dgvHistories_CellMouseMove;
            dgvHistories.CellClick += dgvHistories_OnClick;
            // Add more columns as needed
        }

        private void LoadData()
        {
            _ctm = ctmRepository.GetCustomerById(_customerId);
            UpdateInfo();

            if (_ctm == null)
            {
                return;
            }
            _logs = ioRepository.GetByCCCD(From, To, _customerId);
            RenderData();
        }


        //private void LoadData()
        //{
        //    if (useMockData)
        //    {
        //        GenerateMockData();
        //        UpdateInfo();
        //        RenderData();
        //        return;
        //    }

        //    _ctm = ctmRepository.GetCustomerById(_customerId);
        //    UpdateInfo();

        //    if (_ctm == null)
        //    {
        //        return;
        //    }
        //    _logs = ioRepository.GetByCCCD(From, To, _customerId);
        //    RenderData();
        //}


        private void UpdateInfo()
        {
            if (_ctm == null)
            {
                _lbCCCDVal.Text = "";
                _lbHoTenVal.Text = "";
                return;
            }
            else
            {
                _lbCCCDVal.Text = _ctm.Id;
                _lbHoTenVal.Text = _ctm.HoTen;
            }
        }

        private void RenderData()
        {
            dgvHistories.Rows.Clear();

            //dgvHistories
            for (int i = 0; i < _logs.Count; i++)
            {
                var log = _logs[i];
                int rowIndex = dgvHistories.Rows.Add();
                var row = dgvHistories.Rows[rowIndex];

                row.Cells["VisitDay"].Value = log.CheckInTime.ToString("yyyy-MM-dd");
                row.Cells["SignedIn"].Value = log.CheckInTime.ToString("HH:mm");
                row.Cells["SignedOut"].Value = log.CheckOutTime != null ? log.CheckOutTime.Value.ToString("HH:mm") : "--:--";

                for (int j = 0; j < _fields.Count; j++)
                {
                    var field = _fields[j];
                    log.AdditionFields.TryGetValue(field.Label, out var fieldValue);
                    row.Cells[$"field_{j}"].Value = fieldValue ?? "";
                }
                row.Cells["Image"] = new DataGridViewButtonCell
                {
                    Value = "Xem ảnh"
                };
            }
        }

        private void dgvHistories_OnClick(object? sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is in the action button column
            if (e.RowIndex >= 0 && dgvHistories.Columns[e.ColumnIndex].Name == "Image")
            {
                var imageForm = new FormImage(_logs[e.RowIndex].InImg);
                imageForm.StartPosition = FormStartPosition.CenterScreen;
                imageForm.ShowDialog();
            }
        }

        private void GenerateMockData()
        {
            _ctm = new Customer
            {
                Id = _customerId,
                HoTen = "Nguyễn Văn Mẫu"
            };

            _fields = new List<AdditionField>
    {
        new AdditionField { Label = "Mục đích" },
        new AdditionField { Label = "Người liên hệ" }
    };

            _logs = new List<InOutLog>();
            for (int i = 0; i < 20; i++)
            {
                var checkIn = DateTime.Today.AddDays(-i).AddHours(8).AddMinutes(i * 3);
                var checkOut = checkIn.AddHours(2);

                var log = new InOutLog
                {
                    CheckInTime = checkIn,
                    CheckOutTime = checkOut,
                    AdditionFields = new Dictionary<string, string>
            {
                { "Mục đích", $"Giao dịch {i + 1}" },
                { "Người liên hệ", $"Mr. A{i}" }
            }
                };

                _logs.Add(log);
            }
        }


        private void dgvHistories_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {


            if (e.RowIndex >= 0 && dgvHistories.Columns[e.ColumnIndex].Name == "Image" && e.Value != null)
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


        private void dgvHistories_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvHistories.Columns[e.ColumnIndex].Name == "Image")
            {
                dgvHistories.Cursor = Cursors.Hand;
            }
            else
            {
                dgvHistories.Cursor = Cursors.Default;
            }
        }



        private void DialogCustomerHistories_Load(object sender, EventArgs e)
        {

        }

        private void dgvHistories_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pnInfo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
