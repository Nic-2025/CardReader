namespace IdCard.Hanel_obj.components.common
{
    partial class UiAdditionField
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
            flowPn = new FlowLayoutPanel();
            panel1 = new Panel();
            btnDelete = new Button();
            btnEdit = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // _lbTitle
            // 
            _lbTitle.AutoSize = true;
            _lbTitle.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            _lbTitle.Location = new Point(2, 15);
            _lbTitle.Margin = new Padding(2, 0, 2, 0);
            _lbTitle.Name = "_lbTitle";
            _lbTitle.Size = new Size(63, 25);
            _lbTitle.TabIndex = 0;
            _lbTitle.Text = "label1";
            _lbTitle.Click += _lbTitle_Click;
            // 
            // flowPn
            // 
            flowPn.FlowDirection = FlowDirection.TopDown;
            flowPn.Location = new Point(2, 54);
            flowPn.Margin = new Padding(2);
            flowPn.Name = "flowPn";
            flowPn.Size = new Size(376, 44);
            flowPn.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(250, 250, 250);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(flowPn);
            panel1.Controls.Add(btnEdit);
            panel1.Controls.Add(_lbTitle);
            panel1.Location = new Point(2, 2);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(378, 101);
            panel1.TabIndex = 1;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.Red;
            btnDelete.Location = new Point(313, 14);
            btnDelete.Margin = new Padding(2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(60, 28);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Del";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += BtnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEdit.ForeColor = Color.Blue;
            btnEdit.Location = new Point(240, 15);
            btnEdit.Margin = new Padding(2);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(60, 28);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += BtnEdit_Click;
            // 
            // UiAdditionField
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "UiAdditionField";
            Size = new Size(380, 107);
            Load += UiAdditionField_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label _lbTitle;
        private FlowLayoutPanel flowPn;
        private Panel panel1;
        private Button btnEdit;
        private Button btnDelete;
    }
}
