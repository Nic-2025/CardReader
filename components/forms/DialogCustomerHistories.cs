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
    public partial class DialogCustomerHistories: Form
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
            dgvHistories.Columns.Add("VisitDay", "Ngay visit");
            dgvHistories.Columns.Add("SignedIn", "Signed In");
            dgvHistories.Columns.Add("SignedOut", "Signed out");

            for (int i = 0; i < _fields.Count; i++)
            {
                var field = _fields[i];
                dgvHistories.Columns.Add($"field_{i}", field.Label);
            }

            dgvHistories.Columns.Add("Image", "Ảnh signed in");
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
                row.Cells["SignedOut"].Value = log.CheckOutTime != null ? log.CheckInTime.ToString("HH:mm") : "--:--";

                for (int j = 0; j < _fields.Count; j++)
                {
                    var field = _fields[j];
                    log.AdditionFields.TryGetValue(field.Label, out var fieldValue);
                    row.Cells[$"field_{j}"].Value = fieldValue ?? "";
                }
                row.Cells["Image"] = new DataGridViewButtonCell
                {
                    Value = "Xem Ảnh"
                };
            }
        }

        private void dgvHistories_OnClick(object? sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is in the action button column
            if (e.RowIndex >= 0 && dgvHistories.Columns[e.ColumnIndex].Name == "Image")
            {
                var imageForm = new FormImage(_logs[e.RowIndex].InImg);
                imageForm.ShowDialog();
            }
        }

    }
}
