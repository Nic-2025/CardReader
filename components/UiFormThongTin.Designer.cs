namespace IdCard.Hanel_obj.components
{
    partial class UiFormThongTin
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            _lbTitle = new Label();
            btnAddField = new Button();
            pnFormField = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // _lbTitle
            // 
            _lbTitle.AutoSize = true;
            _lbTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            _lbTitle.Location = new Point(39, 26);
            _lbTitle.Name = "_lbTitle";
            _lbTitle.Size = new Size(321, 54);
            _lbTitle.TabIndex = 0;
            _lbTitle.Text = "Form Thông Tin";
            // 
            // btnAddField
            // 
            btnAddField.Location = new Point(917, 31);
            btnAddField.Name = "btnAddField";
            btnAddField.Size = new Size(234, 60);
            btnAddField.TabIndex = 1;
            btnAddField.Text = "Add Field";
            btnAddField.UseVisualStyleBackColor = true;
            btnAddField.Click += BtnAddField_Click;
            // 
            // pnFormField
            // 
            pnFormField.AutoScroll = true;
            pnFormField.FlowDirection = FlowDirection.TopDown;
            pnFormField.Location = new Point(167, 228);
            pnFormField.Name = "pnFormField";
            pnFormField.Size = new Size(575, 691);
            pnFormField.TabIndex = 3;
            pnFormField.Paint += pnFormField_Paint;
            // 
            // UiFormThongTin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnFormField);
            Controls.Add(btnAddField);
            Controls.Add(_lbTitle);
            Name = "UiFormThongTin";
            Size = new Size(1224, 1178);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label _lbTitle;
        private Button btnAddField;
        private FlowLayoutPanel pnFormField;
    }
}
