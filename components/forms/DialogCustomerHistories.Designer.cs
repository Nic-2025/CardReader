namespace IdCard.Hanel_obj.components.forms
{
    partial class DialogCustomerHistories
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnInfo = new Panel();
            label5 = new Label();
            label3 = new Label();
            _lbCCCDVal = new Label();
            _lbHoTenVal = new Label();
            label1 = new Label();
            lbTitle = new Label();
            pnHistory = new Panel();
            dgvHistories = new DataGridView();
            VisitDate = new DataGridViewTextBoxColumn();
            SignIn = new DataGridViewTextBoxColumn();
            SignOut = new DataGridViewTextBoxColumn();
            flowPn = new FlowLayoutPanel();
            pnInfo.SuspendLayout();
            pnHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistories).BeginInit();
            flowPn.SuspendLayout();
            SuspendLayout();
            // 
            // pnInfo
            // 
            pnInfo.BackColor = SystemColors.ControlLight;
            pnInfo.Controls.Add(label5);
            pnInfo.Controls.Add(label3);
            pnInfo.Controls.Add(_lbCCCDVal);
            pnInfo.Controls.Add(_lbHoTenVal);
            pnInfo.Controls.Add(label1);
            pnInfo.Location = new Point(3, 3);
            pnInfo.Name = "pnInfo";
            pnInfo.Size = new Size(1613, 228);
            pnInfo.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(336, 104);
            label5.Name = "label5";
            label5.Size = new Size(58, 25);
            label5.TabIndex = 0;
            label5.Text = "CCCD";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(34, 27);
            label3.Name = "label3";
            label3.Size = new Size(362, 54);
            label3.TabIndex = 0;
            label3.Text = "Thông tin cá nhân";
            // 
            // _lbCCCDVal
            // 
            _lbCCCDVal.AutoSize = true;
            _lbCCCDVal.Location = new Point(336, 161);
            _lbCCCDVal.Name = "_lbCCCDVal";
            _lbCCCDVal.Size = new Size(58, 25);
            _lbCCCDVal.TabIndex = 0;
            _lbCCCDVal.Text = "CCCD";
            // 
            // _lbHoTenVal
            // 
            _lbHoTenVal.AutoSize = true;
            _lbHoTenVal.Location = new Point(38, 161);
            _lbHoTenVal.Name = "_lbHoTenVal";
            _lbHoTenVal.Size = new Size(62, 25);
            _lbHoTenVal.TabIndex = 0;
            _lbHoTenVal.Text = "HoTen";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 104);
            label1.Name = "label1";
            label1.Size = new Size(89, 25);
            label1.TabIndex = 0;
            label1.Text = "Họ và tên";
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTitle.Location = new Point(24, 23);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(326, 65);
            lbTitle.TabIndex = 5;
            lbTitle.Text = "Chi tiết lịch sử";
            // 
            // pnHistory
            // 
            pnHistory.BackColor = SystemColors.AppWorkspace;
            pnHistory.Controls.Add(dgvHistories);
            pnHistory.Location = new Point(3, 237);
            pnHistory.Name = "pnHistory";
            pnHistory.Size = new Size(1622, 740);
            pnHistory.TabIndex = 2;
            // 
            // dgvHistories
            // 
            dgvHistories.AllowUserToAddRows = false;
            dgvHistories.AllowUserToDeleteRows = false;
            dgvHistories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistories.Columns.AddRange(new DataGridViewColumn[] { VisitDate, SignIn, SignOut });
            dgvHistories.Location = new Point(3, 198);
            dgvHistories.Name = "dgvHistories";
            dgvHistories.RowHeadersWidth = 62;
            dgvHistories.RowTemplate.Height = 33;
            dgvHistories.Size = new Size(1613, 539);
            dgvHistories.TabIndex = 0;
            // 
            // VisitDate
            // 
            VisitDate.HeaderText = "Ngày visit";
            VisitDate.MinimumWidth = 8;
            VisitDate.Name = "VisitDate";
            VisitDate.Width = 150;
            // 
            // SignIn
            // 
            SignIn.HeaderText = "SignIn";
            SignIn.MinimumWidth = 8;
            SignIn.Name = "SignIn";
            SignIn.Width = 150;
            // 
            // SignOut
            // 
            SignOut.HeaderText = "Sign out";
            SignOut.MinimumWidth = 8;
            SignOut.Name = "SignOut";
            SignOut.Width = 150;
            // 
            // flowPn
            // 
            flowPn.Controls.Add(pnInfo);
            flowPn.Controls.Add(pnHistory);
            flowPn.Dock = DockStyle.Bottom;
            flowPn.FlowDirection = FlowDirection.TopDown;
            flowPn.Location = new Point(0, 121);
            flowPn.Name = "flowPn";
            flowPn.Size = new Size(1917, 1014);
            flowPn.TabIndex = 6;
            // 
            // DialogCustomerHistories
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1917, 1135);
            Controls.Add(lbTitle);
            Controls.Add(flowPn);
            Name = "DialogCustomerHistories";
            Text = "DialogCustomerHistories";
            pnInfo.ResumeLayout(false);
            pnInfo.PerformLayout();
            pnHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHistories).EndInit();
            flowPn.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnInfo;
        private Label label5;
        private Label label3;
        private Label _lbCCCDVal;
        private Label _lbHoTenVal;
        private Label label1;
        private Label lbTitle;
        private Panel pnHistory;
        private DataGridView dgvHistories;
        private DataGridViewTextBoxColumn VisitDate;
        private DataGridViewTextBoxColumn SignIn;
        private DataGridViewTextBoxColumn SignOut;
        private FlowLayoutPanel flowPn;
    }
}