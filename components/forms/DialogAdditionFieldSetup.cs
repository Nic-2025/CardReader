using IdCard.Hanel.Models;


namespace IdCard.Hanel_obj.components.forms
{
    public partial class DialogAdditionFieldSetup : Form
    {
        private AdditionField? _currentField = null;

        private readonly AdditionFieldRepository repository = new(AuthenCardDbContext.Instance);

        public AdditionField? CurrentField { get => _currentField; set => SetCurrentField(value); }// Only use for 

        public bool IsEdit { get; set; } = false;

        List<AdditionField> ExistedFields { get; set; } = new List<AdditionField>();

        public DialogAdditionFieldSetup()
        {
            InitializeComponent();
            UpdateComboOrder();

            cbDataType.SelectedIndex = 0;
            cbRequire.SelectedIndex = 0;
        }

        private void UpdateComboOrder()
        {
            cbOrder.Items.Clear();
            ExistedFields = repository.GetList();
            ExistedFields.ForEach(v => cbOrder.Items.Add(v.Label));
            cbOrder.SelectedIndex = 0;
        }

        private void SetCurrentField(AdditionField? value)
        {
            _currentField = value;
            if (_currentField == null)
                return;


            var index = 0;
            for (int i = 0; i < ExistedFields.Count; i++)
            {
                if (ExistedFields[i].Id == _currentField.Id)
                {
                    index = i == 0 ? -1 : i - 1;
                    break;
                }
            }


            cbDataType.SelectedIndex = (int)_currentField.Type - 1; // Type
            txtFieldName.Text = _currentField.Label;
            txtFieldValue.Text = _currentField.Value;
            cbRequire.SelectedIndex = _currentField.Require ? 0 : 1;

            cbOrder.SelectedIndex = index;
        }


        private void BtnSave_Click(object sender, EventArgs e)
        {
            var beforeIndex = cbOrder.SelectedIndex < 0 ? 0 : ExistedFields[cbOrder.SelectedIndex].SortOrder;
            var field = new AdditionField()
            {
                Type = (AdditionFieldType)cbDataType.SelectedIndex + 1,
                Label = txtFieldName.Text,
                Value = txtFieldValue.Text,
                Require = cbRequire.SelectedIndex > 0,
                SortOrder = beforeIndex + 1,
            };

            if (field.Label == "")
            {
                MessageBox.Show("Thiếu trường, hãy điền cho đủ");
                return;
            }


            if (field.Type == AdditionFieldType.Dropdrown && field.Value.Split(',').Length == 0)
            {
                MessageBox.Show("Trường dữ liệu cần thiết phải điền");
                return;
            }

            if (IsEdit)
            {
                if (CurrentField == null)
                {
                    MessageBox.Show("Không tìm thấy trường dữ liệu cần sửa");
                    return;
                }

                field.Id = CurrentField.Id;
                repository.Update(CurrentField.Id, field);
                CurrentField = field;
            }
            else
            {
                field.Id = Guid.NewGuid().ToString();
                repository.Create(field);
            }


            for (int i = cbOrder.SelectedIndex + 1; i < ExistedFields.Count; i++)
            {
                repository.UpdateOrder(ExistedFields[i].Id, beforeIndex + 42 + i);
            }

            this.Hide();
        }

    }
}
