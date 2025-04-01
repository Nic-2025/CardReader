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
            dgvLogIO = new DataGridView();
            btnReload = new Button();
            uiPaginition1 = new UiPaginition();
            STT = new DataGridViewTextBoxColumn();
            HoTen = new DataGridViewTextBoxColumn();
            CCCD = new DataGridViewTextBoxColumn();
            SignedIn = new DataGridViewTextBoxColumn();
            SignedOut = new DataGridViewTextBoxColumn();
            TrangThai = new DataGridViewTextBoxColumn();
            BtnChiTiet = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvLogIO).BeginInit();
            SuspendLayout();
            // 
            // dgvLogIO
            // 
            dgvLogIO.AllowUserToAddRows = false;
            dgvLogIO.AllowUserToDeleteRows = false;
            dgvLogIO.ColumnHeadersHeight = 34;
            dgvLogIO.Columns.AddRange(new DataGridViewColumn[] { STT, HoTen, CCCD, SignedIn, SignedOut, TrangThai, BtnChiTiet });
            dgvLogIO.Dock = DockStyle.Top;
            dgvLogIO.Location = new Point(0, 0);
            dgvLogIO.Name = "dgvLogIO";
            dgvLogIO.RowHeadersWidth = 62;
            dgvLogIO.Size = new Size(1506, 634);
            dgvLogIO.TabIndex = 0;
            // 
            // btnReload
            // 
            btnReload.Location = new Point(0, 640);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(112, 34);
            btnReload.TabIndex = 0;
            btnReload.Text = "Reload";
            btnReload.UseVisualStyleBackColor = true;
            btnReload.Click += BtnReload_Click;
            // 
            // uiPaginition1
            // 
            uiPaginition1.CurrentPage = 0;
            uiPaginition1.Location = new Point(507, 640);
            uiPaginition1.Name = "uiPaginition1";
            uiPaginition1.Size = new Size(999, 82);
            uiPaginition1.TabIndex = 1;
            uiPaginition1.TotalPages = 0;
            // 
            // STT
            // 
            STT.HeaderText = "STT";
            STT.MinimumWidth = 8;
            STT.Name = "STT";
            STT.Width = 150;
            // 
            // HoTen
            // 
            HoTen.HeaderText = "Họ Tên";
            HoTen.MinimumWidth = 8;
            HoTen.Name = "HoTen";
            HoTen.Width = 250;
            // 
            // CCCD
            // 
            CCCD.HeaderText = "CCCD";
            CCCD.MinimumWidth = 8;
            CCCD.Name = "CCCD";
            CCCD.Width = 250;
            // 
            // SignedIn
            // 
            SignedIn.HeaderText = "Signed In";
            SignedIn.MinimumWidth = 8;
            SignedIn.Name = "SignedIn";
            SignedIn.Width = 150;
            // 
            // SignedOut
            // 
            SignedOut.HeaderText = "Signed Out";
            SignedOut.MinimumWidth = 8;
            SignedOut.Name = "SignedOut";
            SignedOut.Width = 150;
            // 
            // TrangThai
            // 
            TrangThai.HeaderText = "Trạng thái";
            TrangThai.MinimumWidth = 8;
            TrangThai.Name = "TrangThai";
            TrangThai.Width = 150;
            // 
            // BtnChiTiet
            // 
            BtnChiTiet.HeaderText = "";
            BtnChiTiet.MinimumWidth = 8;
            BtnChiTiet.Name = "BtnChiTiet";
            BtnChiTiet.Resizable = DataGridViewTriState.True;
            BtnChiTiet.SortMode = DataGridViewColumnSortMode.Automatic;
            BtnChiTiet.Width = 150;
            // 
            // UiIOLogTable
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(uiPaginition1);
            Controls.Add(btnReload);
            Controls.Add(dgvLogIO);
            Name = "UiIOLogTable";
            Size = new Size(1506, 797);
            ((System.ComponentModel.ISupportInitialize)dgvLogIO).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvLogIO;
        private Button btnReload;
        private components.UiPaginition uiPaginition1;
        private DataGridViewTextBoxColumn STT;
        private DataGridViewTextBoxColumn HoTen;
        private DataGridViewTextBoxColumn CCCD;
        private DataGridViewTextBoxColumn SignedIn;
        private DataGridViewTextBoxColumn SignedOut;
        private DataGridViewTextBoxColumn TrangThai;
        private DataGridViewButtonColumn BtnChiTiet;
    }
}
