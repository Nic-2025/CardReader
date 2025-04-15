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
            btnExportExcel = new Button();
            panel5 = new Panel();
            label2 = new Label();
            label1 = new Label();
            endDate = new DateTimePicker();
            startDate = new DateTimePicker();
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
            _lbTitle.Name = "_lbTitle";
            _lbTitle.Size = new Size(152, 54);
            _lbTitle.TabIndex = 0;
            _lbTitle.Text = "Report";
            // 
            // uiioLogTable1
            // 
            uiioLogTable1.Dock = DockStyle.Fill;
            uiioLogTable1.From = null;
            uiioLogTable1.Limit = 10;
            uiioLogTable1.Location = new Point(0, 0);
            uiioLogTable1.Margin = new Padding(1, 2, 1, 2);
            uiioLogTable1.Name = "uiioLogTable1";
            uiioLogTable1.Size = new Size(2016, 1308);
            uiioLogTable1.Status = null;
            uiioLogTable1.TabIndex = 1;
            uiioLogTable1.To = null;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(2016, 185);
            panel1.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Controls.Add(_lbTitle);
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(2016, 182);
            panel3.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Controls.Add(panel6);
            panel4.Controls.Add(panel5);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 87);
            panel4.Margin = new Padding(4, 5, 4, 5);
            panel4.Name = "panel4";
            panel4.Size = new Size(2016, 95);
            panel4.TabIndex = 8;
            // 
            // panel6
            // 
            panel6.Controls.Add(btnExportExcel);
            panel6.Dock = DockStyle.Right;
            panel6.Location = new Point(1737, 0);
            panel6.Margin = new Padding(4, 5, 4, 5);
            panel6.Name = "panel6";
            panel6.Size = new Size(279, 95);
            panel6.TabIndex = 10;
            // 
            // btnExportExcel
            // 
            btnExportExcel.Font = new Font("Segoe UI", 12F);
            btnExportExcel.Location = new Point(107, 15);
            btnExportExcel.Margin = new Padding(4, 5, 4, 5);
            btnExportExcel.Name = "btnExportExcel";
            btnExportExcel.Size = new Size(171, 65);
            btnExportExcel.TabIndex = 2;
            btnExportExcel.Text = "Xuất file Excel";
            btnExportExcel.UseVisualStyleBackColor = true;
            btnExportExcel.Click += BtnExportExcel_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(label2);
            panel5.Controls.Add(label1);
            panel5.Controls.Add(endDate);
            panel5.Controls.Add(startDate);
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(0, 0);
            panel5.Margin = new Padding(4, 5, 4, 5);
            panel5.Name = "panel5";
            panel5.Size = new Size(751, 95);
            panel5.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(111, 0);
            label2.Name = "label2";
            label2.Size = new Size(68, 19);
            label2.TabIndex = 3;
            label2.Text = "Đến ngày";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(58, 19);
            label1.TabIndex = 2;
            label1.Text = "Từ ngày";
            // 
            // endDate
            // 
            endDate.Font = new Font("Segoe UI", 10F);
            endDate.Location = new Point(111, 23);
            endDate.Name = "endDate";
            endDate.Size = new Size(107, 25);
            endDate.TabIndex = 1;
            endDate.ValueChanged += endDate_ValueChanged;
            // 
            // startDate
            // 
            startDate.CalendarFont = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            startDate.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            startDate.Location = new Point(-1, 23);
            startDate.Margin = new Padding(2);
            startDate.Name = "startDate";
            startDate.Size = new Size(107, 25);
            startDate.TabIndex = 0;
            startDate.ValueChanged += DateTimePicker1_ValueChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(uiioLogTable1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 185);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(2016, 1308);
            panel2.TabIndex = 3;
            // 
            // UiReport
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "UiReport";
            Size = new Size(2016, 1513);
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
        private DateTimePicker startDate;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Button button1;
        private DateTimePicker endDate;
        private Label label2;
        private Label label1;
    }
}
