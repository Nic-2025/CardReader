using IdCard.Hanel.Models;

namespace IdCard.Hanel_obj.components.common
{
    public partial class UiFormComponent : UserControl
    {
        private readonly bool _isInput = false;
        private List<AdditionField> _fields = new();

        public event UiAdditionField.EditEvent? OnEdit;
        public event UiAdditionField.DeleteEvent? OnDelete;

        public List<AdditionField> Fields { get => _fields; set => SetFields(value); }


        public UiFormComponent(bool isInput = true)
        {
            _isInput = isInput;
            InitializeComponent();
        }

        private void SetFields(List<AdditionField> fields)
        {
            _fields = fields;
            ReloadFields();
        }

        private void CreateFormComponent(List<AdditionField> fields)
        {
            pnFormField.Controls.Clear();
            foreach (var field in fields)
            {
                var uiField = new UiAdditionField(field, _isInput);
                if (!_isInput)
                {
                    uiField.OnEdit += this.OnEdit;
                    uiField.OnDelete += this.OnDelete;
                }
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

        private void ReloadFields()
        {
            ClearFormComponents();
            CreateFormComponent(_fields);
        }
    }
}
