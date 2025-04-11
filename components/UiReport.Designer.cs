namespace IdCard.Hanel_obj.components
{
    partial class UiReport
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
            uiioLogTable1 = new IdCard.Hanel_obj.components.common.UiIOLogTable();
            panel1 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel6 = new Panel();
            button1 = new Button();
            panel5 = new Panel();
            textBox1 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // _lbTitle
            // 
            _lbTitle.AutoSize = true;
            _lbTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            _lbTitle.Location = new Point(0, 0);
            _lbTitle.Margin = new Padding(2, 0, 2, 0);
            _lbTitle.Name = "_lbTitle";
            _lbTitle.Size = new Size(106, 37);
            _lbTitle.TabIndex = 0;
            _lbTitle.Text = "Report";
            // 
            // uiioLogTable1
            // 
            uiioLogTable1.Dock = DockStyle.Fill;
            uiioLogTable1.From = null;
            uiioLogTable1.Limit = 10;
            uiioLogTable1.Location = new Point(0, 0);
            uiioLogTable1.Margin = new Padding(1);
            uiioLogTable1.Name = "uiioLogTable1";
            uiioLogTable1.Size = new Size(1411, 785);
            uiioLogTable1.Status = null;
            uiioLogTable1.TabIndex = 1;
            uiioLogTable1.To = null;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1411, 111);
            panel1.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Controls.Add(_lbTitle);
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1411, 109);
            panel3.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Controls.Add(panel6);
            panel4.Controls.Add(panel5);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 52);
            panel4.Name = "panel4";
            panel4.Size = new Size(1411, 57);
            panel4.TabIndex = 8;
            // 
            // panel6
            // 
            panel6.Controls.Add(button1);
            panel6.Dock = DockStyle.Right;
            panel6.Location = new Point(1216, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(195, 57);
            panel6.TabIndex = 10;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(75, 9);
            button1.Name = "button1";
            button1.Size = new Size(120, 39);
            button1.TabIndex = 2;
            button1.Text = "Xuất file Excel";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.Controls.Add(textBox1);
            panel5.Controls.Add(dateTimePicker1);
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(526, 57);
            panel5.TabIndex = 9;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(0, 15);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(225, 25);
            textBox1.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(234, 15);
            dateTimePicker1.Margin = new Padding(2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(211, 25);
            dateTimePicker1.TabIndex = 0;
            dateTimePicker1.ValueChanged += DateTimePicker1_ValueChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(uiioLogTable1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 111);
            panel2.Name = "panel2";
            panel2.Size = new Size(1411, 785);
            panel2.TabIndex = 3;
            // 
            // UiReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "UiReport";
            Size = new Size(1411, 908);
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label _lbTitle;
        private common.UiIOLogTable uiioLogTable1;
        private Panel panel1;
        private DateTimePicker dateTimePicker1;
        private Panel panel2;
        private Panel panel3;
        private TextBox textBox1;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Button button1;
    }
}
