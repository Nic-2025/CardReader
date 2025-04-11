using IdCard.Hanel.Models;

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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label5 = new Label();
            label3 = new Label();
            _lbCCCDVal = new Label();
            _lbHoTenVal = new Label();
            label1 = new Label();
            dgvHistories = new DataGridView();
            VisitDate = new DataGridViewTextBoxColumn();
            SignIn = new DataGridViewTextBoxColumn();
            SignOut = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            panel4 = new Panel();
            panel8 = new Panel();
            panel7 = new Panel();
            label2 = new Label();
            wrapperDate = new Panel();
            dtFilter = new DateTimePicker();
            panel5 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            _lbTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvHistories).BeginInit();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            wrapperDate.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.5F);
            label5.Location = new Point(349, 80);
            label5.Name = "label5";
            label5.Size = new Size(65, 30);
            label5.TabIndex = 0;
            label5.Text = "CCCD";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(20, 15);
            label3.Name = "label3";
            label3.Size = new Size(290, 45);
            label3.TabIndex = 0;
            label3.Text = "Thông tin cá nhân";
            label3.Click += label3_Click;
            // 
            // _lbCCCDVal
            // 
            _lbCCCDVal.AutoSize = true;
            _lbCCCDVal.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            _lbCCCDVal.Location = new Point(349, 127);
            _lbCCCDVal.Name = "_lbCCCDVal";
            _lbCCCDVal.Size = new Size(193, 30);
            _lbCCCDVal.TabIndex = 0;
            _lbCCCDVal.Text = "051454545454654";
            // 
            // _lbHoTenVal
            // 
            _lbHoTenVal.AutoSize = true;
            _lbHoTenVal.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            _lbHoTenVal.Location = new Point(20, 127);
            _lbHoTenVal.Name = "_lbHoTenVal";
            _lbHoTenVal.Size = new Size(255, 30);
            _lbHoTenVal.TabIndex = 0;
            _lbHoTenVal.Text = "Nguyễn Ngọc Minh Anh";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.5F);
            label1.Location = new Point(20, 80);
            label1.Name = "label1";
            label1.Size = new Size(103, 30);
            label1.TabIndex = 0;
            label1.Text = "Họ và tên";
            // 
            // dgvHistories
            // 
            dgvHistories.AllowUserToAddRows = false;
            dgvHistories.AllowUserToDeleteRows = false;
            dgvHistories.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistories.BackgroundColor = Color.White;
            dgvHistories.BorderStyle = BorderStyle.None;
            dgvHistories.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Black;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvHistories.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvHistories.ColumnHeadersHeight = 48;
            dgvHistories.Columns.AddRange(new DataGridViewColumn[] { VisitDate, SignIn, SignOut });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(234, 236, 240);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvHistories.DefaultCellStyle = dataGridViewCellStyle2;
            dgvHistories.Dock = DockStyle.Fill;
            dgvHistories.EnableHeadersVisualStyles = false;
            dgvHistories.GridColor = Color.FromArgb(234, 236, 240);
            dgvHistories.Location = new Point(23, 85);
            dgvHistories.Name = "dgvHistories";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvHistories.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvHistories.RowHeadersVisible = false;
            dgvHistories.RowHeadersWidth = 62;
            dgvHistories.RowTemplate.Height = 57;
            dgvHistories.Size = new Size(1825, 598);
            dgvHistories.TabIndex = 0;
            dgvHistories.CellContentClick += dgvHistories_CellContentClick;
            // 
            // VisitDate
            // 
            VisitDate.HeaderText = "Ngày visit";
            VisitDate.MinimumWidth = 8;
            VisitDate.Name = "VisitDate";
            // 
            // SignIn
            // 
            SignIn.HeaderText = "SignIn";
            SignIn.MinimumWidth = 8;
            SignIn.Name = "SignIn";
            // 
            // SignOut
            // 
            SignOut.HeaderText = "Sign out";
            SignOut.MinimumWidth = 8;
            SignOut.Name = "SignOut";
            // 
            // panel1
            // 
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(23, 27, 23, 27);
            panel1.Size = new Size(1917, 1062);
            panel1.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(panel8);
            panel4.Controls.Add(panel5);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(23, 312);
            panel4.Margin = new Padding(4, 5, 4, 5);
            panel4.Name = "panel4";
            panel4.Size = new Size(1871, 723);
            panel4.TabIndex = 6;
            panel4.Paint += panel4_Paint;
            // 
            // panel8
            // 
            panel8.Controls.Add(dgvHistories);
            panel8.Controls.Add(panel7);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(0, 40);
            panel8.Margin = new Padding(4, 5, 4, 5);
            panel8.Name = "panel8";
            panel8.Padding = new Padding(23, 0, 23, 0);
            panel8.Size = new Size(1871, 683);
            panel8.TabIndex = 10;
            // 
            // panel7
            // 
            panel7.Controls.Add(label2);
            panel7.Controls.Add(wrapperDate);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(23, 0);
            panel7.Margin = new Padding(4, 5, 4, 5);
            panel7.Name = "panel7";
            panel7.Size = new Size(1825, 85);
            panel7.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(-3, 15);
            label2.Name = "label2";
            label2.Size = new Size(193, 45);
            label2.TabIndex = 1;
            label2.Text = "Lịch sử visit";
            label2.Click += label2_Click;
            // 
            // wrapperDate
            // 
            wrapperDate.Controls.Add(dtFilter);
            wrapperDate.Dock = DockStyle.Right;
            wrapperDate.Location = new Point(1278, 0);
            wrapperDate.Margin = new Padding(4, 5, 4, 5);
            wrapperDate.Name = "wrapperDate";
            wrapperDate.Size = new Size(547, 85);
            wrapperDate.TabIndex = 9;
            // 
            // dtFilter
            // 
            dtFilter.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtFilter.Location = new Point(243, 23);
            dtFilter.Name = "dtFilter";
            dtFilter.Size = new Size(300, 34);
            dtFilter.TabIndex = 5;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.Control;
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Margin = new Padding(4, 5, 4, 5);
            panel5.Name = "panel5";
            panel5.Size = new Size(1871, 40);
            panel5.TabIndex = 7;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(_lbCCCDVal);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(_lbHoTenVal);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(23, 110);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(17, 0, 17, 20);
            panel3.Size = new Size(1871, 202);
            panel3.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.Controls.Add(_lbTitle);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(23, 27);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(1871, 83);
            panel2.TabIndex = 4;
            // 
            // _lbTitle
            // 
            _lbTitle.AutoSize = true;
            _lbTitle.Dock = DockStyle.Top;
            _lbTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            _lbTitle.Location = new Point(0, 0);
            _lbTitle.Name = "_lbTitle";
            _lbTitle.Size = new Size(291, 54);
            _lbTitle.TabIndex = 3;
            _lbTitle.Text = "Chi tiết lịch sử";
            // 
            // DialogCustomerHistories
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1917, 1062);
            Controls.Add(panel1);
            Name = "DialogCustomerHistories";
            Text = "DialogCustomerHistories";
            Load += DialogCustomerHistories_Load;
            ((System.ComponentModel.ISupportInitialize)dgvHistories).EndInit();
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            wrapperDate.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label5;
        private Label label3;
        private Label _lbCCCDVal;
        private Label _lbHoTenVal;
        private Label label1;
        private DataGridView dgvHistories;
        private DataGridViewTextBoxColumn VisitDate;
        private DataGridViewTextBoxColumn SignIn;
        private DataGridViewTextBoxColumn SignOut;
        private Panel panel1;
        private Label _lbTitle;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Label label2;
        private DateTimePicker dtFilter;
        private Panel wrapperDate;
        private Panel panel7;
        private Panel panel8;
    }
}