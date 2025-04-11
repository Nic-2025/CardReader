namespace IdCard.Hanel_obj.components.common
{
    partial class UiIOLogTable
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dgvLogIO = new DataGridView();
            STT = new DataGridViewTextBoxColumn();
            HoTen = new DataGridViewTextBoxColumn();
            CCCD = new DataGridViewTextBoxColumn();
            SignedIn = new DataGridViewTextBoxColumn();
            SignedOut = new DataGridViewTextBoxColumn();
            TrangThai = new DataGridViewTextBoxColumn();
            BtnChiTiet = new DataGridViewButtonColumn();
            uiPaginition1 = new UiPaginition();
            panel1 = new Panel();
            panel2 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            panel5 = new Panel();
            countSignedOut = new Label();
            label3 = new Label();
            label4 = new Label();
            label1 = new Label();
            countSignedIn = new Label();
            countAll = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvLogIO).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // dgvLogIO
            // 
            dgvLogIO.AllowUserToAddRows = false;
            dgvLogIO.AllowUserToDeleteRows = false;
            dgvLogIO.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLogIO.BackgroundColor = Color.White;
            dgvLogIO.BorderStyle = BorderStyle.None;
            dgvLogIO.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Black;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvLogIO.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvLogIO.ColumnHeadersHeight = 48;
            dgvLogIO.Columns.AddRange(new DataGridViewColumn[] { STT, HoTen, CCCD, SignedIn, SignedOut, TrangThai, BtnChiTiet });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(234, 236, 240);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvLogIO.DefaultCellStyle = dataGridViewCellStyle2;
            dgvLogIO.Dock = DockStyle.Top;
            dgvLogIO.EnableHeadersVisualStyles = false;
            dgvLogIO.GridColor = Color.FromArgb(234, 236, 240);
            dgvLogIO.Location = new Point(0, 0);
            dgvLogIO.Margin = new Padding(2);
            dgvLogIO.Name = "dgvLogIO";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvLogIO.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvLogIO.RowHeadersVisible = false;
            dgvLogIO.RowHeadersWidth = 62;
            dgvLogIO.RowTemplate.Height = 57;
            dgvLogIO.Size = new Size(1274, 618);
            dgvLogIO.TabIndex = 0;
            // 
            // STT
            // 
            STT.FillWeight = 5F;
            STT.HeaderText = "STT";
            STT.Name = "STT";
            // 
            // HoTen
            // 
            HoTen.FillWeight = 20F;
            HoTen.HeaderText = "Họ Tên";
            HoTen.Name = "HoTen";
            // 
            // CCCD
            // 
            CCCD.FillWeight = 20F;
            CCCD.HeaderText = "CCCD";
            CCCD.Name = "CCCD";
            // 
            // SignedIn
            // 
            SignedIn.FillWeight = 15F;
            SignedIn.HeaderText = "Signed In";
            SignedIn.Name = "SignedIn";
            // 
            // SignedOut
            // 
            SignedOut.FillWeight = 15F;
            SignedOut.HeaderText = "Signed Out";
            SignedOut.Name = "SignedOut";
            // 
            // TrangThai
            // 
            TrangThai.FillWeight = 15F;
            TrangThai.HeaderText = "Trạng thái";
            TrangThai.Name = "TrangThai";
            // 
            // BtnChiTiet
            // 
            BtnChiTiet.FillWeight = 10F;
            BtnChiTiet.HeaderText = "";
            BtnChiTiet.Name = "BtnChiTiet";
            BtnChiTiet.Resizable = DataGridViewTriState.True;
            BtnChiTiet.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // uiPaginition1
            // 
            uiPaginition1.AutoSize = true;
            uiPaginition1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            uiPaginition1.CurrentPage = 1;
            uiPaginition1.Dock = DockStyle.Right;
            uiPaginition1.Location = new Point(354, 0);
            uiPaginition1.Margin = new Padding(1);
            uiPaginition1.Name = "uiPaginition1";
            uiPaginition1.Size = new Size(70, 52);
            uiPaginition1.TabIndex = 1;
            uiPaginition1.TotalPages = 0;
            uiPaginition1.Load += uiPaginition1_Load;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(dgvLogIO);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1274, 796);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 618);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(0, 32, 0, 16);
            panel2.Size = new Size(1274, 100);
            panel2.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Controls.Add(uiPaginition1);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(850, 32);
            panel4.Name = "panel4";
            panel4.Size = new Size(424, 52);
            panel4.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel5);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 32);
            panel3.Name = "panel3";
            panel3.Size = new Size(459, 52);
            panel3.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.AutoSize = true;
            panel5.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel5.Controls.Add(countSignedOut);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(label1);
            panel5.Controls.Add(countSignedIn);
            panel5.Controls.Add(countAll);
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(415, 52);
            panel5.TabIndex = 3;
            // 
            // countSignedOut
            // 
            countSignedOut.AutoSize = true;
            countSignedOut.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            countSignedOut.ForeColor = Color.Red;
            countSignedOut.Location = new Point(373, 0);
            countSignedOut.Name = "countSignedOut";
            countSignedOut.Size = new Size(39, 15);
            countSignedOut.TabIndex = 5;
            countSignedOut.Text = "result";
            countSignedOut.Click += countSignedOut_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(93, 0);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(109, 15);
            label3.TabIndex = 2;
            label3.Text = "Số lượng Signed in:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(250, 0);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.No;
            label4.Size = new Size(117, 15);
            label4.TabIndex = 4;
            label4.Text = "Số lượng Signed out:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(45, 15);
            label1.TabIndex = 0;
            label1.Text = "Tất cả: ";
            // 
            // countSignedIn
            // 
            countSignedIn.AutoSize = true;
            countSignedIn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            countSignedIn.ForeColor = Color.Green;
            countSignedIn.Location = new Point(199, 0);
            countSignedIn.Name = "countSignedIn";
            countSignedIn.Size = new Size(39, 15);
            countSignedIn.TabIndex = 3;
            countSignedIn.Text = "result";
            // 
            // countAll
            // 
            countAll.AutoSize = true;
            countAll.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            countAll.ForeColor = Color.Black;
            countAll.Location = new Point(41, 0);
            countAll.Name = "countAll";
            countAll.Size = new Size(39, 15);
            countAll.TabIndex = 1;
            countAll.Text = "result";
            // 
            // UiIOLogTable
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "UiIOLogTable";
            Size = new Size(1274, 796);
            Load += UiIOLogTable_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLogIO).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }
        #endregion

        private DataGridView dgvLogIO;
        private components.UiPaginition uiPaginition1;
        private DataGridViewTextBoxColumn STT;
        private DataGridViewTextBoxColumn HoTen;
        private DataGridViewTextBoxColumn CCCD;
        private DataGridViewTextBoxColumn SignedIn;
        private DataGridViewTextBoxColumn SignedOut;
        private DataGridViewTextBoxColumn TrangThai;
        private DataGridViewButtonColumn BtnChiTiet;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label countSignedOut;
        private Label label4;
        private Label countSignedIn;
        private Label label3;
        private Label countAll;
        private Label label1;
        private Panel panel5;
    }
}
