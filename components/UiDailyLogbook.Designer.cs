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
            uiioLogTable1 = new IdCard.Hanel_obj.components.common.UiIOLogTable();
            cbStatus = new ComboBox();
            lbDate = new Label();
            panel1 = new Panel();
            textBox1 = new TextBox();
            panel2 = new Panel();
            date = new Label();
            panel3 = new Panel();
            banner = new Panel();
            panel5 = new Panel();
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
            _lbTitle.Margin = new Padding(2, 0, 2, 0);
            _lbTitle.Name = "_lbTitle";
            _lbTitle.Size = new Size(204, 37);
            _lbTitle.TabIndex = 0;
            _lbTitle.Text = "Daily Logbook";
            // 
            // uiioLogTable1
            // 
            uiioLogTable1.Dock = DockStyle.Fill;
            uiioLogTable1.From = null;
            uiioLogTable1.Limit = 10;
            uiioLogTable1.Location = new Point(0, 0);
            uiioLogTable1.Margin = new Padding(1);
            uiioLogTable1.Name = "uiioLogTable1";
            uiioLogTable1.Size = new Size(1411, 647);
            uiioLogTable1.Status = null;
            uiioLogTable1.TabIndex = 1;
            uiioLogTable1.To = null;
            uiioLogTable1.Load += uiioLogTable1_Load;
            // 
            // cbStatus
            // 
            cbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStatus.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbStatus.FormattingEnabled = true;
            cbStatus.Items.AddRange(new object[] { "None", "Signed In", "Signed Out" });
            cbStatus.Location = new Point(230, 60);
            cbStatus.Margin = new Padding(2);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(146, 33);
            cbStatus.TabIndex = 2;
            cbStatus.SelectedIndexChanged += CbStatus_SelectedIndexChanged;
            // 
            // lbDate
            // 
            lbDate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbDate.AutoSize = true;
            lbDate.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbDate.Location = new Point(3, 46);
            lbDate.Margin = new Padding(2, 0, 2, 0);
            lbDate.Name = "lbDate";
            lbDate.Size = new Size(60, 30);
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
            panel1.Name = "panel1";
            panel1.Size = new Size(1411, 134);
            panel1.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(0, 60);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(225, 33);
            textBox1.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.Controls.Add(date);
            panel2.Controls.Add(lbDate);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(1268, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(143, 134);
            panel2.TabIndex = 6;
            // 
            // date
            // 
            date.AutoSize = true;
            date.Font = new Font("Segoe UI", 10F);
            date.Location = new Point(3, 78);
            date.Name = "date";
            date.Size = new Size(45, 19);
            date.TabIndex = 5;
            date.Text = "label1";
            // 
            // panel3
            // 
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(banner);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1411, 834);
            panel3.TabIndex = 6;
            // 
            // banner
            // 
            banner.BackgroundImageLayout = ImageLayout.Stretch;
            banner.BackgroundImage = Image.FromFile(Path.Combine(Application.StartupPath, "public", "banner.png"));
            banner.Dock = DockStyle.Top;
            banner.Location = new Point(0, 0);
            banner.Name = "banner";
            banner.Size = new Size(1411, 187);
            banner.TabIndex = 6;
            // 
            // panel5
            // 
            panel5.Controls.Add(panel1);
            panel5.Controls.Add(uiioLogTable1);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 187);
            panel5.Name = "panel5";
            panel5.Size = new Size(1411, 647);
            panel5.TabIndex = 7;
            // 
            // UiDailyLogbook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel3);
            Margin = new Padding(2);
            Name = "UiDailyLogbook";
            Size = new Size(1411, 834);
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
        private common.UiIOLogTable uiioLogTable1;
        private ComboBox cbStatus;
        private Label lbDate;
        private Panel panel1;
        private Panel panel2;
        private TextBox textBox1;
        private Panel panel3;
        private Label date;
        private Panel banner;
        private Panel panel5;
    }
}
