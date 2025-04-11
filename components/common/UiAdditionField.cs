using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using IdCard.Hanel.Models;

namespace IdCard.Hanel_obj.components.common
{


    public partial class UiAdditionField : UserControl
    {
        private Control? _inputControl;
        public AdditionField Field { set; get; }

        public delegate void EditEvent(AdditionField field);

        public delegate void DeleteEvent(AdditionField field);

        public event EditEvent? OnEdit;

        public event DeleteEvent? OnDelete;

        public UiAdditionField(AdditionField field, bool isInput = true)
        {

            Field = field;
            InitializeComponent();
            ConfigField();


            if (isInput)
            {
                btnEdit.Visible = false;
                btnDelete.Visible = false;
            }
            else
            {
                btnEdit.Visible = true;
                btnDelete.Visible = true;
            }
        }


        public void ConfigField()
        {
            this._lbTitle.Text = Field.Label;
            if (Field == null) // Fix null check for _field
                return;

            if (_inputControl != null)
                flowPn.Controls.Remove(_inputControl);

            _inputControl = CreateValueField();
            if (_inputControl != null)
            {
                flowPn.Controls.Add(_inputControl);
            }    

        }

        public string GetValue()
        {
            if (_inputControl == null)
                return "";

            if (_inputControl is TextBox textBox)
                return textBox.Text;

            if (_inputControl is ComboBox comboBox)
                return comboBox.SelectedItem?.ToString() ?? string.Empty;

            if (_inputControl is CheckBox checkBox)
                return checkBox.Checked ? "1" : "0";

            return string.Empty;
        }

        public void SetValue(string value)
        {
            Field.Value = value;
            if (_inputControl == null)
                return;

            if (_inputControl is TextBox textBox)
            {
                textBox.Text = Field.Value;
                return;
            }

            if (_inputControl is ComboBox comboBox)
            {
                comboBox.SelectedItem = Field.Value;
                return;
            }

            if (_inputControl is CheckBox checkBox)
            {
                checkBox.Checked = Field.Value == "1";
                return;
            }

            if (_inputControl is RadioButton radioButton)
            {
                radioButton.Checked = Field.Value == "1";
                return;
            }

            if (_inputControl is DateTimePicker dateTimePicker)
            {
                if (DateTime.TryParse(Field.Value, out DateTime dateValue))
                {
                    dateTimePicker.Value = dateValue;
                }
            }
            else if (_inputControl is NumericUpDown numericUpDown)
            {
                if (decimal.TryParse(Field.Value, out decimal numericValue))
                {
                    numericUpDown.Value = numericValue;
                }
            }
        }

        public void ClearField()
        {
            if (_inputControl is TextBox textBox)
            {
                textBox.Clear();
            }

            else if (_inputControl is ComboBox comboBox)
            {
                comboBox.SelectedIndex = -1;
            }
        }

        private Control? CreateValueField()
        {
            if (Field.Type == AdditionFieldType.Text)
            {
                var txtVal = new TextBox
                {
                    Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0),
                    Location = new Point(3, 41),
                    Name = "txtText",
                    Size = new Size(449, 45),
                    TabIndex = 1,
                    //Text = Field.Label
                };
                return txtVal;
            }

            if (Field.Type == AdditionFieldType.Dropdrown) // Fix incorrect condition
            {
                var cbVal = new ComboBox
                {
                    Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0),
                    FormattingEnabled = true,
                    Location = new Point(3, 92),
                    Name = "cbValue",
                    Size = new Size(449, 46),
                    TabIndex = 2,
                    DropDownStyle = ComboBoxStyle.DropDownList,
                };

                // Ensure Value is not null or empty before splitting
                if (!string.IsNullOrWhiteSpace(Field.Value))
                {
                    var options = Field.Value.Split(';');
                    cbVal.Items.AddRange(options);
                    if (cbVal.Items.Count > 0)
                    {
                        cbVal.SelectedIndex = 0;
                    }
                }
                else
                {
                    // Log or handle the case where Value is missing
                    Console.WriteLine($"Warning: AdditionField '{Field.Label}' has no Value set.");
                }
                return cbVal;
            }


            if (Field.Type == AdditionFieldType.Checkbox)
            {
                var checkBox = new CheckBox
                {
                    Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0),
                    Location = new Point(3, 41),
                    Name = "checkBox",
                    Size = new Size(449, 45),
                    TabIndex = 1,
                    //Text = Field.Label
                    Checked = false,
                };
                return checkBox;
            }

            return null;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            this.OnEdit?.Invoke(Field);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            this.OnDelete?.Invoke(Field);
        }

        private void _lbTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
