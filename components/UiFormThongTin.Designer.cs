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
            panel1 = new Panel();
            panel2 = new Panel();
            horizo = new Panel();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // _lbTitle
            // 
            _lbTitle.AutoSize = true;
            _lbTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            _lbTitle.Location = new Point(0, 0);
            _lbTitle.Margin = new Padding(2, 0, 2, 0);
            _lbTitle.Name = "_lbTitle";
            _lbTitle.Size = new Size(220, 37);
            _lbTitle.TabIndex = 0;
            _lbTitle.Text = "Form Thông Tin";
            // 
            // btnAddField
            // 
            btnAddField.Location = new Point(36, 7);
            btnAddField.Margin = new Padding(2);
            btnAddField.Name = "btnAddField";
            btnAddField.Size = new Size(164, 36);
            btnAddField.TabIndex = 1;
            btnAddField.Text = "Add Custom Field";
            btnAddField.UseVisualStyleBackColor = true;
            btnAddField.Click += BtnAddField_Click;
            // 
            // pnFormField
            // 
            pnFormField.AutoScroll = true;
            pnFormField.Dock = DockStyle.Fill;
            pnFormField.FlowDirection = FlowDirection.TopDown;
            pnFormField.Location = new Point(0, 0);
            pnFormField.Margin = new Padding(2);
            pnFormField.Name = "pnFormField";
            pnFormField.Padding = new Padding(0, 16, 0, 0);
            pnFormField.Size = new Size(793, 800);
            pnFormField.TabIndex = 3;
            pnFormField.Paint += pnFormField_Paint;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(horizo);
            panel1.Controls.Add(_lbTitle);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(32, 32);
            panel1.Name = "panel1";
            panel1.Size = new Size(793, 67);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnAddField);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(593, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 65);
            panel2.TabIndex = 5;
            // 
            // horizo
            // 
            horizo.BackColor = Color.FromArgb(20, 0, 0, 0);
            horizo.Dock = DockStyle.Bottom;
            horizo.Location = new Point(0, 65);
            horizo.Name = "horizo";
            horizo.Size = new Size(793, 2);
            horizo.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.Controls.Add(pnFormField);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(32, 99);
            panel3.Name = "panel3";
            panel3.Size = new Size(793, 800);
            panel3.TabIndex = 5;
            // 
            // UiFormThongTin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel3);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "UiFormThongTin";
            Padding = new Padding(32);
            Size = new Size(857, 707);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label _lbTitle;
        private Button btnAddField;
        private FlowLayoutPanel pnFormField;
        private Panel panel1;
        private Panel panel2;
        private Panel horizo;
        private Panel panel3;
    }
}
