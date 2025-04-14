namespace IdCard.Hanel_obj.components.forms
{
    partial class FormLogin
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
            btnLogin = new Button();
            txtPwd = new TextBox();
            txtUsername = new TextBox();
            label1 = new Label();
            lbUserName = new Label();
            label2 = new Label();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(546, 477);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(232, 62);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += BtnLogin_Click;
            // 
            // txtPwd
            // 
            txtPwd.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPwd.Location = new Point(254, 377);
            txtPwd.Name = "txtPwd";
            txtPwd.Size = new Size(524, 45);
            txtPwd.TabIndex = 1;
            txtPwd.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(254, 243);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(524, 45);
            txtUsername.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(254, 332);
            label1.Name = "label1";
            label1.Size = new Size(132, 38);
            label1.TabIndex = 3;
            label1.Text = "Password";
            // 
            // lbUserName
            // 
            lbUserName.AutoSize = true;
            lbUserName.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbUserName.Location = new Point(254, 198);
            lbUserName.Name = "lbUserName";
            lbUserName.Size = new Size(142, 38);
            lbUserName.TabIndex = 4;
            lbUserName.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label2.Location = new Point(406, 73);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(230, 54);
            label2.TabIndex = 5;
            label2.Text = "Đăng nhập";
            // 
            // btnCancel
            // 
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(254, 477);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(167, 62);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += BtnCancel_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1056, 677);
            Controls.Add(label2);
            Controls.Add(btnCancel);
            Controls.Add(btnLogin);
            Controls.Add(txtPwd);
            Controls.Add(txtUsername);
            Controls.Add(label1);
            Controls.Add(lbUserName);
            Name = "FormLogin";
            Text = "FormLogin";
            Load += FormLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private TextBox txtPwd;
        private TextBox txtUsername;
        private Label label1;
        private Label lbUserName;
        private Label label2;
        private Button btnCancel;
    }
}