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
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(552, 308);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(150, 50);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += BtnLogin_Click;
            // 
            // txtPwd
            // 
            txtPwd.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPwd.Location = new Point(300, 209);
            txtPwd.Name = "txtPwd";
            txtPwd.Size = new Size(402, 45);
            txtPwd.TabIndex = 1;
            txtPwd.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(300, 93);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(402, 45);
            txtUsername.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(99, 216);
            label1.Name = "label1";
            label1.Size = new Size(132, 38);
            label1.TabIndex = 3;
            label1.Text = "Password";
            // 
            // lbUserName
            // 
            lbUserName.AutoSize = true;
            lbUserName.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbUserName.Location = new Point(99, 93);
            lbUserName.Name = "lbUserName";
            lbUserName.Size = new Size(142, 38);
            lbUserName.TabIndex = 4;
            lbUserName.Text = "Username";
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogin);
            Controls.Add(txtPwd);
            Controls.Add(txtUsername);
            Controls.Add(label1);
            Controls.Add(lbUserName);
            Name = "FormLogin";
            Text = "FormLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private TextBox txtPwd;
        private TextBox txtUsername;
        private Label label1;
        private Label lbUserName;
    }
}