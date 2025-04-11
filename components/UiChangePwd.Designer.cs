namespace IdCard.Hanel_obj.components
{
    partial class UiChangePwd
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
            lbOldPwd = new Label();
            txtOldPwd = new TextBox();
            lbNewPwd = new Label();
            txtNewPwd = new TextBox();
            lbNewPwd2 = new Label();
            txtNewPwd2 = new TextBox();
            btnSave = new Button();
            horizo = new Panel();
            panel1 = new Panel();
            panel2 = new Panel();
            panel1.SuspendLayout();
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
            _lbTitle.Size = new Size(189, 37);
            _lbTitle.TabIndex = 0;
            _lbTitle.Text = "Đổi mật khẩu";
            _lbTitle.Click += _lbTitle_Click;
            // 
            // lbOldPwd
            // 
            lbOldPwd.AutoSize = true;
            lbOldPwd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbOldPwd.Location = new Point(0, 29);
            lbOldPwd.Margin = new Padding(2, 0, 2, 0);
            lbOldPwd.Name = "lbOldPwd";
            lbOldPwd.Size = new Size(95, 21);
            lbOldPwd.TabIndex = 1;
            lbOldPwd.Text = "Mật khẩu cũ";
            // 
            // txtOldPwd
            // 
            txtOldPwd.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtOldPwd.Location = new Point(0, 52);
            txtOldPwd.Margin = new Padding(2);
            txtOldPwd.Name = "txtOldPwd";
            txtOldPwd.Size = new Size(580, 32);
            txtOldPwd.TabIndex = 0;
            txtOldPwd.UseSystemPasswordChar = true;
            // 
            // lbNewPwd
            // 
            lbNewPwd.AutoSize = true;
            lbNewPwd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbNewPwd.Location = new Point(0, 111);
            lbNewPwd.Margin = new Padding(2, 0, 2, 0);
            lbNewPwd.Name = "lbNewPwd";
            lbNewPwd.Size = new Size(107, 21);
            lbNewPwd.TabIndex = 1;
            lbNewPwd.Text = "Mật khẩu mới";
            // 
            // txtNewPwd
            // 
            txtNewPwd.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNewPwd.Location = new Point(0, 134);
            txtNewPwd.Margin = new Padding(2);
            txtNewPwd.Name = "txtNewPwd";
            txtNewPwd.Size = new Size(580, 32);
            txtNewPwd.TabIndex = 1;
            txtNewPwd.UseSystemPasswordChar = true;
            // 
            // lbNewPwd2
            // 
            lbNewPwd2.AutoSize = true;
            lbNewPwd2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbNewPwd2.Location = new Point(0, 197);
            lbNewPwd2.Margin = new Padding(2, 0, 2, 0);
            lbNewPwd2.Name = "lbNewPwd2";
            lbNewPwd2.Size = new Size(169, 21);
            lbNewPwd2.TabIndex = 1;
            lbNewPwd2.Text = "Nhập lại mật khẩu mới";
            // 
            // txtNewPwd2
            // 
            txtNewPwd2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNewPwd2.Location = new Point(0, 220);
            txtNewPwd2.Margin = new Padding(2);
            txtNewPwd2.Name = "txtNewPwd2";
            txtNewPwd2.Size = new Size(580, 32);
            txtNewPwd2.TabIndex = 2;
            txtNewPwd2.UseSystemPasswordChar = true;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.DimGray;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.Transparent;
            btnSave.Location = new Point(456, 280);
            btnSave.Margin = new Padding(2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(124, 41);
            btnSave.TabIndex = 3;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += BtnSave_Click;
            // 
            // horizo
            // 
            horizo.BackColor = Color.FromArgb(20, 0, 0, 0);
            horizo.Dock = DockStyle.Bottom;
            horizo.Location = new Point(0, 65);
            horizo.Name = "horizo";
            horizo.Size = new Size(1125, 2);
            horizo.TabIndex = 4;
            horizo.Paint += horizo_Paint;
            // 
            // panel1
            // 
            panel1.Controls.Add(_lbTitle);
            panel1.Controls.Add(horizo);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(32, 32);
            panel1.Name = "panel1";
            panel1.Size = new Size(1125, 67);
            panel1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.Controls.Add(lbOldPwd);
            panel2.Controls.Add(lbNewPwd);
            panel2.Controls.Add(btnSave);
            panel2.Controls.Add(lbNewPwd2);
            panel2.Controls.Add(txtNewPwd2);
            panel2.Controls.Add(txtOldPwd);
            panel2.Controls.Add(txtNewPwd);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(32, 99);
            panel2.Name = "panel2";
            panel2.Size = new Size(1125, 478);
            panel2.TabIndex = 6;
            // 
            // UiChangePwd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "UiChangePwd";
            Padding = new Padding(32);
            Size = new Size(1189, 609);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label _lbTitle;
        private Label lbOldPwd;
        private TextBox txtOldPwd;
        private Label lbNewPwd;
        private TextBox txtNewPwd;
        private Label lbNewPwd2;
        private TextBox txtNewPwd2;
        private Button btnSave;
        private Panel horizo;
        private Panel panel1;
        private Panel panel2;
    }
}
