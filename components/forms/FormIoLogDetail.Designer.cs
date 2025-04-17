namespace IdCard.Hanel_obj.components.forms
{
    partial class FormIoLogDetail
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
            _cbManual = new ComboBox();
            lbSignInValue = new Label();
            lbSignOutValue = new Label();
            lbSignOutTime = new Label();
            lbSignInTime = new Label();
            _signIoStatus = new IdCard.Hanel_obj.forms.UiSignIOStatus();
            lbTitle = new Label();
            label2 = new Label();
            label3 = new Label();
            lbHoTenVal = new Label();
            lbCCCDVal = new Label();
            label4 = new Label();
            pnThongTin = new Panel();
            label1 = new Label();
            pImage = new PictureBox();
            pnImage = new Panel();
            pnFormField = new FlowLayoutPanel();
            panel1 = new Panel();
            label9 = new Label();
            pnFormContainer = new Panel();
            btnManuaSignOut = new Button();
            panel2 = new Panel();
            pnThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pImage).BeginInit();
            pnImage.SuspendLayout();
            panel1.SuspendLayout();
            pnFormContainer.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // _cbManual
            // 
            _cbManual.FormattingEnabled = true;
            _cbManual.Items.AddRange(new object[] { "Automatic", "Manual Signout" });
            _cbManual.Location = new Point(326, -122);
            _cbManual.Name = "_cbManual";
            _cbManual.Size = new Size(95, 33);
            _cbManual.TabIndex = 20;
            // 
            // lbSignInValue
            // 
            lbSignInValue.AutoSize = true;
            lbSignInValue.Location = new Point(327, 110);
            lbSignInValue.Name = "lbSignInValue";
            lbSignInValue.Size = new Size(44, 25);
            lbSignInValue.TabIndex = 18;
            lbSignInValue.Text = "--:--";
            // 
            // lbSignOutValue
            // 
            lbSignOutValue.AutoSize = true;
            lbSignOutValue.Location = new Point(517, 110);
            lbSignOutValue.Name = "lbSignOutValue";
            lbSignOutValue.Size = new Size(44, 25);
            lbSignOutValue.TabIndex = 19;
            lbSignOutValue.Text = "--:--";
            // 
            // lbSignOutTime
            // 
            lbSignOutTime.AutoSize = true;
            lbSignOutTime.Font = new Font("Segoe UI Variable Display", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbSignOutTime.Location = new Point(490, 33);
            lbSignOutTime.Name = "lbSignOutTime";
            lbSignOutTime.Size = new Size(121, 37);
            lbSignOutTime.TabIndex = 11;
            lbSignOutTime.Text = "Sign out";
            // 
            // lbSignInTime
            // 
            lbSignInTime.AutoSize = true;
            lbSignInTime.Font = new Font("Segoe UI Variable Display", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbSignInTime.Location = new Point(281, 33);
            lbSignInTime.Name = "lbSignInTime";
            lbSignInTime.Size = new Size(155, 37);
            lbSignInTime.TabIndex = 12;
            lbSignInTime.Text = "SignInTime";
            // 
            // _signIoStatus
            // 
            _signIoStatus.BackColor = Color.FromArgb(7, 148, 85);
            _signIoStatus.IsManual = false;
            _signIoStatus.IsSignIn = false;
            _signIoStatus.Location = new Point(196, -127);
            _signIoStatus.Margin = new Padding(1, 2, 1, 2);
            _signIoStatus.Name = "_signIoStatus";
            _signIoStatus.Size = new Size(124, 37);
            _signIoStatus.TabIndex = 10;
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Segoe UI Variable Display", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTitle.Location = new Point(313, -223);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(384, 64);
            lbTitle.TabIndex = 9;
            lbTitle.Text = "Chi tiết thông tin";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Display", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(29, 27);
            label2.Name = "label2";
            label2.Size = new Size(255, 37);
            label2.TabIndex = 0;
            label2.Text = "Thông tin cá nhân";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(29, 102);
            label3.Name = "label3";
            label3.Size = new Size(96, 28);
            label3.TabIndex = 2;
            label3.Text = "Họ và tên";
            // 
            // lbHoTenVal
            // 
            lbHoTenVal.AutoSize = true;
            lbHoTenVal.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbHoTenVal.Location = new Point(29, 157);
            lbHoTenVal.Name = "lbHoTenVal";
            lbHoTenVal.Size = new Size(104, 28);
            lbHoTenVal.TabIndex = 2;
            lbHoTenVal.Text = "Họ và tên";
            // 
            // lbCCCDVal
            // 
            lbCCCDVal.AutoSize = true;
            lbCCCDVal.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbCCCDVal.Location = new Point(254, 157);
            lbCCCDVal.Name = "lbCCCDVal";
            lbCCCDVal.Size = new Size(104, 28);
            lbCCCDVal.TabIndex = 2;
            lbCCCDVal.Text = "Họ và tên";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(254, 102);
            label4.Name = "label4";
            label4.Size = new Size(127, 28);
            label4.TabIndex = 2;
            label4.Text = "CCCD/CMND";
            // 
            // pnThongTin
            // 
            pnThongTin.BackColor = Color.White;
            pnThongTin.Controls.Add(label4);
            pnThongTin.Controls.Add(lbCCCDVal);
            pnThongTin.Controls.Add(lbHoTenVal);
            pnThongTin.Controls.Add(label3);
            pnThongTin.Controls.Add(label2);
            pnThongTin.Location = new Point(27, 587);
            pnThongTin.Name = "pnThongTin";
            pnThongTin.Padding = new Padding(23, 27, 23, 27);
            pnThongTin.Size = new Size(621, 243);
            pnThongTin.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Display", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(26, 27);
            label1.Name = "label1";
            label1.Size = new Size(247, 37);
            label1.TabIndex = 0;
            label1.Text = "Chi tiết thông tin";
            // 
            // pImage
            // 
            pImage.Location = new Point(110, 85);
            pImage.Name = "pImage";
            pImage.Size = new Size(393, 238);
            pImage.TabIndex = 2;
            pImage.TabStop = false;
            // 
            // pnImage
            // 
            pnImage.BackColor = Color.White;
            pnImage.Controls.Add(pImage);
            pnImage.Controls.Add(label1);
            pnImage.Location = new Point(30, 182);
            pnImage.Name = "pnImage";
            pnImage.Padding = new Padding(23, 27, 23, 27);
            pnImage.Size = new Size(619, 353);
            pnImage.TabIndex = 13;
            // 
            // pnFormField
            // 
            pnFormField.AutoSize = true;
            pnFormField.BackColor = SystemColors.Control;
            pnFormField.Dock = DockStyle.Fill;
            pnFormField.FlowDirection = FlowDirection.TopDown;
            pnFormField.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pnFormField.Location = new Point(0, 0);
            pnFormField.Name = "pnFormField";
            pnFormField.Padding = new Padding(0, 100, 0, 33);
            pnFormField.Size = new Size(619, 375);
            pnFormField.TabIndex = 1;
            pnFormField.WrapContents = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(label9);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(23, 27, 23, 27);
            panel1.Size = new Size(619, 100);
            panel1.TabIndex = 21;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Variable Display", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(23, 27);
            label9.Name = "label9";
            label9.Size = new Size(216, 37);
            label9.TabIndex = 0;
            label9.Text = "Form thông tin";
            // 
            // pnFormContainer
            // 
            pnFormContainer.AutoSize = true;
            pnFormContainer.BackColor = Color.White;
            pnFormContainer.Controls.Add(panel1);
            pnFormContainer.Controls.Add(pnFormField);
            pnFormContainer.Location = new Point(30, 877);
            pnFormContainer.Name = "pnFormContainer";
            pnFormContainer.Size = new Size(619, 375);
            pnFormContainer.TabIndex = 15;
            // 
            // btnManuaSignOut
            // 
            btnManuaSignOut.BackColor = Color.Red;
            btnManuaSignOut.FlatAppearance.BorderSize = 0;
            btnManuaSignOut.FlatStyle = FlatStyle.Flat;
            btnManuaSignOut.ForeColor = Color.White;
            btnManuaSignOut.Location = new Point(474, 20);
            btnManuaSignOut.Margin = new Padding(4, 5, 4, 5);
            btnManuaSignOut.Name = "btnManuaSignOut";
            btnManuaSignOut.Size = new Size(174, 53);
            btnManuaSignOut.TabIndex = 21;
            btnManuaSignOut.Text = "Manual Sign out";
            btnManuaSignOut.UseVisualStyleBackColor = false;
            btnManuaSignOut.Click += BtnManuaSignOut_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnManuaSignOut);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 1266);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(697, 93);
            panel2.TabIndex = 22;
            // 
            // FormIoLogDetail
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(250, 250, 250);
            ClientSize = new Size(681, 1385);
            Controls.Add(panel2);
            Controls.Add(pnFormContainer);
            Controls.Add(pnImage);
            Controls.Add(pnThongTin);
            Controls.Add(_cbManual);
            Controls.Add(lbSignInValue);
            Controls.Add(lbSignOutValue);
            Controls.Add(lbSignOutTime);
            Controls.Add(lbSignInTime);
            Controls.Add(_signIoStatus);
            Controls.Add(lbTitle);
            Name = "FormIoLogDetail";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chi tiết thông tin";
            pnThongTin.ResumeLayout(false);
            pnThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pImage).EndInit();
            pnImage.ResumeLayout(false);
            pnImage.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnFormContainer.ResumeLayout(false);
            pnFormContainer.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox _cbManual;
        private Label lbSignInValue;
        private Label lbSignOutValue;
        private Label lbSignOutTime;
        private Label lbSignInTime;
        private Hanel_obj.forms.UiSignIOStatus _signIoStatus;
        private Label lbTitle;
        private Label label2;
        private Label label3;
        private Label lbHoTenVal;
        private Label lbCCCDVal;
        private Label label4;
        private Panel pnThongTin;
        private Label label1;
        private PictureBox pImage;
        private Panel pnImage;
        private FlowLayoutPanel pnFormField;
        private Panel panel1;
        private Label label9;
        private Panel pnFormContainer;
        private Button btnManuaSignOut;
        private Panel panel2;
    }
}