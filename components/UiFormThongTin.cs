using IdCard.Hanel.Models;
using IdCard.Hanel_obj.components.common;

namespace IdCard.Hanel_obj.components
{
    public partial class UiFormThongTin : UserControl
    {

        private readonly AdditionFieldRepository _fieldRepo = new(AuthenCardDbContext.Instance);

        private List<AdditionField> _fields = new();


        public UiFormThongTin()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            ReloadFields();
        }

        private void ReloadFields()
        {
            _fields = _fieldRepo.GetList();
            ClearFormComponents();
            CreateFormComponent(_fields);
        }


        private void BtnAddField_Click(object sender, EventArgs e)
        {
            var dialog = new forms.DialogAdditionFieldSetup();
            // Đặt vị trí giữa màn hình
            dialog.StartPosition = FormStartPosition.CenterScreen;
            // (Tuỳ chọn) Điều chỉnh kích thước nếu muốn
            var screenHeight = Screen.PrimaryScreen.WorkingArea.Height;
            dialog.ShowDialog();
            ReloadFields();
        }

        private void CreateFormComponent(List<AdditionField> fields)
        {
            pnFormField.Controls.Clear();
            foreach (var field in fields)
            {
                var uiField = new UiAdditionField(field, false);

                uiField.OnEdit += (field) =>
                {
                    forms.DialogAdditionFieldSetup dialog = new()
                    {
                        IsEdit = true,
                        CurrentField = field,
                        StartPosition = FormStartPosition.CenterScreen
                    };

                    dialog.ShowDialog();
                    ReloadFields();
                };

                uiField.OnDelete += (field) =>
                {
                    if (MessageBox.Show(
                        "Quý khách có chắc chắn muốn xoá trường dữ liệu?",
                        "Xoá trường dữ liệu",
                        MessageBoxButtons.YesNo,
                         MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        _fieldRepo.Delete(field.Id);
                        ReloadFields();
                    }
                };

                pnFormField.Controls.Add(uiField);
            }
        }


        private void ClearFormComponents()
        {
            foreach (Control control in pnFormField.Controls)
            {
                if (control is UiAdditionField uiField)
                {
                    uiField.ClearField();
                }
            }
        }

        private void pnFormField_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
