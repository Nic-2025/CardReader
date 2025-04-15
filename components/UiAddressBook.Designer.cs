using System.Windows.Forms;

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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            _lbTitle = new Label();
            dgvCustomer = new DataGridView();
            STT = new DataGridViewTextBoxColumn();
            FullName = new DataGridViewTextBoxColumn();
            LatestVisit = new DataGridViewTextBoxColumn();
            TotalVisit = new DataGridViewTextBoxColumn();
            BtnMoreDetail = new DataGridViewTextBoxColumn();
            uiPaginition1 = new UiPaginition();
            startDate = new DateTimePicker();
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            endDate = new DateTimePicker();
            panel2 = new Panel();
            lbDate = new Label();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            totalVisitor = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // _lbTitle
            // 
            _lbTitle.AutoSize = true;
            _lbTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            _lbTitle.Location = new Point(2, 0);
            _lbTitle.Margin = new Padding(2, 0, 2, 0);
            _lbTitle.Name = "_lbTitle";
            _lbTitle.Size = new Size(193, 37);
            _lbTitle.TabIndex = 0;
            _lbTitle.Text = "Address book";
            // 
            // dgvCustomer
            // 
            dgvCustomer.AllowUserToAddRows = false;
            dgvCustomer.AllowUserToDeleteRows = false;
            dgvCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCustomer.BackgroundColor = Color.White;
            dgvCustomer.BorderStyle = BorderStyle.None;
            dgvCustomer.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Black;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCustomer.ColumnHeadersHeight = 48;
            dgvCustomer.Columns.AddRange(new DataGridViewColumn[] { STT, FullName, LatestVisit, TotalVisit, BtnMoreDetail });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(234, 236, 240);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvCustomer.DefaultCellStyle = dataGridViewCellStyle2;
            dgvCustomer.Dock = DockStyle.Top;
            dgvCustomer.EnableHeadersVisualStyles = false;
            dgvCustomer.GridColor = Color.FromArgb(234, 236, 240);
            dgvCustomer.Location = new Point(0, 16);
            dgvCustomer.Margin = new Padding(2);
            dgvCustomer.Name = "dgvCustomer";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvCustomer.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvCustomer.RowHeadersVisible = false;
            dgvCustomer.RowHeadersWidth = 62;
            dgvCustomer.RowTemplate.Height = 57;
            dgvCustomer.Size = new Size(1281, 612);
            dgvCustomer.TabIndex = 0;
            // 
            // STT
            // 
            STT.HeaderText = "STT";
            STT.MinimumWidth = 2;
            STT.Width = 60;
            STT.Name = "STT";
            // 
            // FullName
            // 
            FullName.HeaderText = "Họ & Tên";
            FullName.MinimumWidth = 8;
            FullName.Name = "FullName";
            // 
            // LatestVisit
            // 
            LatestVisit.HeaderText = "Lượt Visit Gần Nhất";
            LatestVisit.MinimumWidth = 8;
            LatestVisit.Name = "LatestVisit";
            // 
            // TotalVisit
            // 
            TotalVisit.HeaderText = "Tổng Số Lượt Visit";
            TotalVisit.MinimumWidth = 8;
            TotalVisit.Name = "TotalVisit";
            // 
            // BtnMoreDetail
            // 
            BtnMoreDetail.HeaderText = "";
            BtnMoreDetail.MinimumWidth = 8;
            BtnMoreDetail.Name = "BtnMoreDetail";
            // 
            // uiPaginition1
            // 
            uiPaginition1.AutoSize = true;
            uiPaginition1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            uiPaginition1.CurrentPage = 1;
            uiPaginition1.Dock = DockStyle.Right;
            uiPaginition1.Location = new Point(1211, 0);
            uiPaginition1.Margin = new Padding(1);
            uiPaginition1.Name = "uiPaginition1";
            uiPaginition1.Padding = new Padding(0, 16, 0, 0);
            uiPaginition1.Size = new Size(70, 69);
            uiPaginition1.TabIndex = 2;
            uiPaginition1.TotalPages = 0;
            // 
            // startDate
            // 
            startDate.CustomFormat = "dd/MM/yyyy";
            startDate.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            startDate.Format = DateTimePickerFormat.Custom;
            startDate.Location = new Point(2, 75);
            startDate.Margin = new Padding(2);
            startDate.Name = "startDate";
            startDate.Size = new Size(107, 25);
            startDate.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(endDate);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(startDate);
            panel1.Controls.Add(_lbTitle);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1281, 105);
            panel1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(114, 53);
            label3.Name = "label3";
            label3.Size = new Size(68, 19);
            label3.TabIndex = 8;
            label3.Text = "Đến ngày";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(2, 54);
            label2.Name = "label2";
            label2.Size = new Size(58, 19);
            label2.TabIndex = 7;
            label2.Text = "Từ ngày";
            // 
            // endDate
            // 
            endDate.CustomFormat = "dd/MM/yyyy";
            endDate.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            endDate.Format = DateTimePickerFormat.Custom;
            endDate.Location = new Point(114, 75);
            endDate.Name = "endDate";
            endDate.Size = new Size(107, 25);
            endDate.TabIndex = 6;
            endDate.ValueChanged += endDate_ValueChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(lbDate);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(1088, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(193, 105);
            panel2.TabIndex = 5;
            // 
            // lbDate
            // 
            lbDate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbDate.AutoSize = true;
            lbDate.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbDate.Location = new Point(2, 72);
            lbDate.Margin = new Padding(2, 0, 2, 0);
            lbDate.Name = "lbDate";
            lbDate.Size = new Size(51, 25);
            lbDate.TabIndex = 6;
            lbDate.Text = "time";
            lbDate.Click += lbDate_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(dgvCustomer);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 105);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(0, 16, 0, 0);
            panel3.Size = new Size(1281, 629);
            panel3.TabIndex = 6;
            // 
            // panel4
            // 
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(uiPaginition1);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 734);
            panel4.Name = "panel4";
            panel4.Size = new Size(1281, 69);
            panel4.TabIndex = 7;
            panel4.Paint += panel4_Paint;
            // 
            // panel5
            // 
            panel5.Controls.Add(totalVisitor);
            panel5.Controls.Add(label1);
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(148, 69);
            panel5.TabIndex = 3;
            // 
            // totalVisitor
            // 
            totalVisitor.AutoSize = true;
            totalVisitor.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            totalVisitor.Location = new Point(61, 25);
            totalVisitor.Name = "totalVisitor";
            totalVisitor.Size = new Size(66, 15);
            totalVisitor.TabIndex = 1;
            totalVisitor.Text = "120 visitor";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 25);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 0;
            label1.Text = "Tất cả: ";
            // 
            // UiAddressBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "UiAddressBook";
            Size = new Size(1281, 791);
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label _lbTitle;
        private DataGridView dgvCustomer;
        private UiPaginition uiPaginition1;
        private DataGridViewTextBoxColumn STT;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn LatestVisit;
        private DataGridViewTextBoxColumn TotalVisit;
        private DataGridViewTextBoxColumn BtnMoreDetail;
        private DateTimePicker startDate;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label lbDate;
        private Panel panel5;
        private Label totalVisitor;
        private Label label1;
        private DateTimePicker endDate;
        private Label label3;
        private Label label2;
    }
}
