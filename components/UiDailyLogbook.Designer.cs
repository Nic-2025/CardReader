namespace IdCard.Hanel_obj.components
{
    partial class UiDailyLogbook
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
            cbStatus = new ComboBox();
            lbDate = new Label();
            panel1 = new Panel();
            textBox1 = new TextBox();
            panel2 = new Panel();
            date = new Label();
            panel3 = new Panel();
            panel5 = new Panel();
            uiioLogTable2 = new IdCard.Hanel_obj.components.common.UiIOLogTable();
            banner = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // _lbTitle
            // 
            _lbTitle.AutoSize = true;
            _lbTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            _lbTitle.Location = new Point(0, 0);
            _lbTitle.Name = "_lbTitle";
            _lbTitle.Size = new Size(294, 54);
            _lbTitle.TabIndex = 0;
            _lbTitle.Text = "Daily Logbook";
            // 
            // cbStatus
            // 
            cbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStatus.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbStatus.FormattingEnabled = true;
            cbStatus.Items.AddRange(new object[] { "None", "Signed In", "Signed Out" });
            cbStatus.Location = new Point(329, 100);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(207, 46);
            cbStatus.TabIndex = 2;
            cbStatus.SelectedIndexChanged += CbStatus_SelectedIndexChanged;
            // 
            // lbDate
            // 
            lbDate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbDate.AutoSize = true;
            lbDate.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbDate.Location = new Point(4, 77);
            lbDate.Name = "lbDate";
            lbDate.Size = new Size(87, 45);
            lbDate.TabIndex = 4;
            lbDate.Text = "time";
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(_lbTitle);
            panel1.Controls.Add(cbStatus);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(2016, 223);
            panel1.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(0, 100);
            textBox1.Margin = new Padding(4, 5, 4, 5);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(320, 52);
            textBox1.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.Controls.Add(date);
            panel2.Controls.Add(lbDate);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(1812, 0);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(204, 223);
            panel2.TabIndex = 6;
            // 
            // date
            // 
            date.AutoSize = true;
            date.Font = new Font("Segoe UI", 10F);
            date.Location = new Point(4, 130);
            date.Margin = new Padding(4, 0, 4, 0);
            date.Name = "date";
            date.Size = new Size(65, 28);
            date.TabIndex = 5;
            date.Text = "label1";
            // 
            // panel3
            // 
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(banner);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(2016, 1390);
            panel3.TabIndex = 6;
            // 
            // panel5
            // 
            panel5.Controls.Add(uiioLogTable2);
            panel5.Controls.Add(panel1);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 312);
            panel5.Margin = new Padding(4, 5, 4, 5);
            panel5.Name = "panel5";
            panel5.Size = new Size(2016, 1078);
            panel5.TabIndex = 7;
            panel5.Paint += panel5_Paint;
            // 
            // uiioLogTable2
            // 
            uiioLogTable2.Dock = DockStyle.Fill;
            uiioLogTable2.From = null;
            uiioLogTable2.Limit = 10;
            uiioLogTable2.Location = new Point(0, 223);
            uiioLogTable2.Name = "uiioLogTable2";
            uiioLogTable2.Size = new Size(2016, 855);
            uiioLogTable2.Status = null;
            uiioLogTable2.TabIndex = 6;
            uiioLogTable2.To = null;
            // 
            // banner
            // 
            banner.BackgroundImageLayout = ImageLayout.Stretch;
            banner.Dock = DockStyle.Top;
            banner.Location = new Point(0, 0);
            banner.Margin = new Padding(4, 5, 4, 5);
            banner.Name = "banner";
            banner.Size = new Size(2016, 312);
            banner.TabIndex = 6;
            // 
            // UiDailyLogbook
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel3);
            Name = "UiDailyLogbook";
            Size = new Size(2016, 1390);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label _lbTitle;
        private ComboBox cbStatus;
        private Label lbDate;
        private Panel panel1;
        private Panel panel2;
        private TextBox textBox1;
        private Panel panel3;
        private Label date;
        private Panel banner;
        private Panel panel5;
        private common.UiIOLogTable uiioLogTable2;
    }
}
