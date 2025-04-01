namespace IdCard.Hanel_obj.components
{
    partial class UiAddressBook
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
            dgvCustomer = new DataGridView();
            STT = new DataGridViewTextBoxColumn();
            FullName = new DataGridViewTextBoxColumn();
            LatestVisit = new DataGridViewTextBoxColumn();
            TotalVisit = new DataGridViewTextBoxColumn();
            BtnMoreDetail = new DataGridViewTextBoxColumn();
            uiPaginition1 = new UiPaginition();
            btnReload = new Button();
            dtFilter = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).BeginInit();
            SuspendLayout();
            // 
            // _lbTitle
            // 
            _lbTitle.AutoSize = true;
            _lbTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            _lbTitle.Location = new Point(51, 0);
            _lbTitle.Name = "_lbTitle";
            _lbTitle.Size = new Size(281, 54);
            _lbTitle.TabIndex = 0;
            _lbTitle.Text = "Address book";
            // 
            // dgvCustomer
            // 
            dgvCustomer.AllowUserToAddRows = false;
            dgvCustomer.AllowUserToDeleteRows = false;
            dgvCustomer.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomer.Columns.AddRange(new DataGridViewColumn[] { STT, FullName, LatestVisit, TotalVisit, BtnMoreDetail });
            dgvCustomer.Location = new Point(51, 162);
            dgvCustomer.Name = "dgvCustomer";
            dgvCustomer.RowHeadersWidth = 62;
            dgvCustomer.RowTemplate.Height = 33;
            dgvCustomer.Size = new Size(1751, 517);
            dgvCustomer.TabIndex = 1;
            // 
            // STT
            // 
            STT.HeaderText = "STT";
            STT.MinimumWidth = 8;
            STT.Name = "STT";
            STT.Width = 150;
            // 
            // FullName
            // 
            FullName.HeaderText = "Họ & Tên";
            FullName.MinimumWidth = 8;
            FullName.Name = "FullName";
            FullName.Width = 250;
            // 
            // LatestVisit
            // 
            LatestVisit.HeaderText = "Lượt Visit Gần Nhất";
            LatestVisit.MinimumWidth = 8;
            LatestVisit.Name = "LatestVisit";
            LatestVisit.Width = 250;
            // 
            // TotalVisit
            // 
            TotalVisit.HeaderText = "Tổng Số Lượt Visit";
            TotalVisit.MinimumWidth = 8;
            TotalVisit.Name = "TotalVisit";
            TotalVisit.Width = 250;
            // 
            // BtnMoreDetail
            // 
            BtnMoreDetail.HeaderText = "";
            BtnMoreDetail.MinimumWidth = 8;
            BtnMoreDetail.Name = "BtnMoreDetail";
            BtnMoreDetail.Width = 150;
            // 
            // uiPaginition1
            // 
            uiPaginition1.CurrentPage = 0;
            uiPaginition1.Location = new Point(1031, 718);
            uiPaginition1.Name = "uiPaginition1";
            uiPaginition1.Size = new Size(771, 79);
            uiPaginition1.TabIndex = 2;
            uiPaginition1.TotalPages = 0;
            // 
            // btnReload
            // 
            btnReload.Location = new Point(51, 718);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(112, 34);
            btnReload.TabIndex = 3;
            btnReload.Text = "Reload";
            btnReload.UseVisualStyleBackColor = true;
            // 
            // dtFilter
            // 
            dtFilter.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtFilter.Location = new Point(51, 84);
            dtFilter.Name = "dtFilter";
            dtFilter.Size = new Size(300, 45);
            dtFilter.TabIndex = 4;
            dtFilter.ValueChanged += DtFilter_ValueChanged;
            // 
            // UiAddressBook
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dtFilter);
            Controls.Add(btnReload);
            Controls.Add(uiPaginition1);
            Controls.Add(dgvCustomer);
            Controls.Add(_lbTitle);
            Name = "UiAddressBook";
            Size = new Size(1830, 958);
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label _lbTitle;
        private DataGridView dgvCustomer;
        private UiPaginition uiPaginition1;
        private Button btnReload;
        private DataGridViewTextBoxColumn STT;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn LatestVisit;
        private DataGridViewTextBoxColumn TotalVisit;
        private DataGridViewTextBoxColumn BtnMoreDetail;
        private DateTimePicker dtFilter;
    }
}
