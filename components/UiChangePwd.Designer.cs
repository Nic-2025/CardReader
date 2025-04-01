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
            SuspendLayout();
            // 
            // _lbTitle
            // 
            _lbTitle.AutoSize = true;
            _lbTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            _lbTitle.Location = new Point(41, 0);
            _lbTitle.Name = "_lbTitle";
            _lbTitle.Size = new Size(277, 54);
            _lbTitle.TabIndex = 0;
            _lbTitle.Text = "Đổi mật khẩu";
            // 
            // lbOldPwd
            // 
            lbOldPwd.AutoSize = true;
            lbOldPwd.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbOldPwd.Location = new Point(221, 161);
            lbOldPwd.Name = "lbOldPwd";
            lbOldPwd.Size = new Size(170, 38);
            lbOldPwd.TabIndex = 1;
            lbOldPwd.Text = "Mật khẩu cũ";
            // 
            // txtOldPwd
            // 
            txtOldPwd.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtOldPwd.Location = new Point(221, 227);
            txtOldPwd.Name = "txtOldPwd";
            txtOldPwd.Size = new Size(519, 45);
            txtOldPwd.TabIndex = 0;
            txtOldPwd.UseSystemPasswordChar = true;
            // 
            // lbNewPwd
            // 
            lbNewPwd.AutoSize = true;
            lbNewPwd.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbNewPwd.Location = new Point(221, 379);
            lbNewPwd.Name = "lbNewPwd";
            lbNewPwd.Size = new Size(189, 38);
            lbNewPwd.TabIndex = 1;
            lbNewPwd.Text = "Mật khẩu mới";
            // 
            // txtNewPwd
            // 
            txtNewPwd.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNewPwd.Location = new Point(221, 445);
            txtNewPwd.Name = "txtNewPwd";
            txtNewPwd.Size = new Size(519, 45);
            txtNewPwd.TabIndex = 1;
            txtNewPwd.UseSystemPasswordChar = true;
            // 
            // lbNewPwd2
            // 
            lbNewPwd2.AutoSize = true;
            lbNewPwd2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbNewPwd2.Location = new Point(221, 528);
            lbNewPwd2.Name = "lbNewPwd2";
            lbNewPwd2.Size = new Size(299, 38);
            lbNewPwd2.TabIndex = 1;
            lbNewPwd2.Text = "Nhập lại mật khẩu mới";
            // 
            // txtNewPwd2
            // 
            txtNewPwd2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNewPwd2.Location = new Point(221, 594);
            txtNewPwd2.Name = "txtNewPwd2";
            txtNewPwd2.Size = new Size(519, 45);
            txtNewPwd2.TabIndex = 2;
            txtNewPwd2.UseSystemPasswordChar = true;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(590, 701);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(150, 69);
            btnSave.TabIndex = 3;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += BtnSave_Click;
            // 
            // UiChangePwd
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnSave);
            Controls.Add(txtNewPwd2);
            Controls.Add(txtNewPwd);
            Controls.Add(txtOldPwd);
            Controls.Add(lbNewPwd2);
            Controls.Add(lbNewPwd);
            Controls.Add(lbOldPwd);
            Controls.Add(_lbTitle);
            Name = "UiChangePwd";
            Size = new Size(945, 1015);
            ResumeLayout(false);
            PerformLayout();
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
    }
}
