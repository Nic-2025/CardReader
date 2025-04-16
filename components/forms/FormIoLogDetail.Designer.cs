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
            manuaSignOut = new Button();
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
            _cbManual.Location = new Point(228, -73);
            _cbManual.Margin = new Padding(2);
            _cbManual.Name = "_cbManual";
            _cbManual.Size = new Size(68, 23);
            _cbManual.TabIndex = 20;
            // 
            // lbSignInValue
            // 
            lbSignInValue.AutoSize = true;
            lbSignInValue.Location = new Point(229, 66);
            lbSignInValue.Margin = new Padding(2, 0, 2, 0);
            lbSignInValue.Name = "lbSignInValue";
            lbSignInValue.Size = new Size(30, 15);
            lbSignInValue.TabIndex = 18;
            lbSignInValue.Text = "--:--";
            // 
            // lbSignOutValue
            // 
            lbSignOutValue.AutoSize = true;
            lbSignOutValue.Location = new Point(362, 66);
            lbSignOutValue.Margin = new Padding(2, 0, 2, 0);
            lbSignOutValue.Name = "lbSignOutValue";
            lbSignOutValue.Size = new Size(30, 15);
            lbSignOutValue.TabIndex = 19;
            lbSignOutValue.Text = "--:--";
            // 
            // lbSignOutTime
            // 
            lbSignOutTime.AutoSize = true;
            lbSignOutTime.Font = new Font("Segoe UI Variable Display", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbSignOutTime.Location = new Point(343, 20);
            lbSignOutTime.Margin = new Padding(2, 0, 2, 0);
            lbSignOutTime.Name = "lbSignOutTime";
            lbSignOutTime.Size = new Size(82, 26);
            lbSignOutTime.TabIndex = 11;
            lbSignOutTime.Text = "Sign out";
            // 
            // lbSignInTime
            // 
            lbSignInTime.AutoSize = true;
            lbSignInTime.Font = new Font("Segoe UI Variable Display", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbSignInTime.Location = new Point(197, 20);
            lbSignInTime.Margin = new Padding(2, 0, 2, 0);
            lbSignInTime.Name = "lbSignInTime";
            lbSignInTime.Size = new Size(105, 26);
            lbSignInTime.TabIndex = 12;
            lbSignInTime.Text = "SignInTime";
            // 
            // _signIoStatus
            // 
            _signIoStatus.BackColor = Color.FromArgb(7, 148, 85);
            _signIoStatus.IsManual = false;
            _signIoStatus.IsSignIn = false;
            _signIoStatus.Location = new Point(137, -76);
            _signIoStatus.Margin = new Padding(1);
            _signIoStatus.Name = "_signIoStatus";
            _signIoStatus.Size = new Size(87, 22);
            _signIoStatus.TabIndex = 10;
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Segoe UI Variable Display", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTitle.Location = new Point(219, -134);
            lbTitle.Margin = new Padding(2, 0, 2, 0);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(257, 43);
            lbTitle.TabIndex = 9;
            lbTitle.Text = "Chi tiết thông tin";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Display", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(20, 16);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(168, 26);
            label2.TabIndex = 0;
            label2.Text = "Thông tin cá nhân";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(20, 61);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(69, 19);
            label3.TabIndex = 2;
            label3.Text = "Họ và tên";
            // 
            // lbHoTenVal
            // 
            lbHoTenVal.AutoSize = true;
            lbHoTenVal.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbHoTenVal.Location = new Point(20, 94);
            lbHoTenVal.Margin = new Padding(2, 0, 2, 0);
            lbHoTenVal.Name = "lbHoTenVal";
            lbHoTenVal.Size = new Size(74, 19);
            lbHoTenVal.TabIndex = 2;
            lbHoTenVal.Text = "Họ và tên";
            // 
            // lbCCCDVal
            // 
            lbCCCDVal.AutoSize = true;
            lbCCCDVal.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbCCCDVal.Location = new Point(178, 94);
            lbCCCDVal.Margin = new Padding(2, 0, 2, 0);
            lbCCCDVal.Name = "lbCCCDVal";
            lbCCCDVal.Size = new Size(74, 19);
            lbCCCDVal.TabIndex = 2;
            lbCCCDVal.Text = "Họ và tên";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(178, 61);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(93, 19);
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
            pnThongTin.Location = new Point(19, 352);
            pnThongTin.Margin = new Padding(2);
            pnThongTin.Name = "pnThongTin";
            pnThongTin.Padding = new Padding(16);
            pnThongTin.Size = new Size(435, 146);
            pnThongTin.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Display", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(18, 16);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(163, 26);
            label1.TabIndex = 0;
            label1.Text = "Chi tiết thông tin";
            // 
            // pImage
            // 
            pImage.Location = new Point(77, 51);
            pImage.Margin = new Padding(2);
            pImage.Name = "pImage";
            pImage.Size = new Size(275, 143);
            pImage.TabIndex = 2;
            pImage.TabStop = false;
            // 
            // pnImage
            // 
            pnImage.BackColor = Color.White;
            pnImage.Controls.Add(pImage);
            pnImage.Controls.Add(label1);
            pnImage.Location = new Point(21, 109);
            pnImage.Margin = new Padding(2);
            pnImage.Name = "pnImage";
            pnImage.Padding = new Padding(16);
            pnImage.Size = new Size(433, 212);
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
            pnFormField.Margin = new Padding(2);
            pnFormField.Name = "pnFormField";
            pnFormField.Padding = new Padding(0, 60, 0, 20);
            pnFormField.Size = new Size(433, 225);
            pnFormField.TabIndex = 1;
            pnFormField.WrapContents = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(label9);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(16);
            panel1.Size = new Size(433, 60);
            panel1.TabIndex = 21;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Variable Display", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(16, 16);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(145, 26);
            label9.TabIndex = 0;
            label9.Text = "Form thông tin";
            // 
            // pnFormContainer
            // 
            pnFormContainer.AutoSize = true;
            pnFormContainer.BackColor = Color.White;
            pnFormContainer.Controls.Add(panel1);
            pnFormContainer.Controls.Add(pnFormField);
            pnFormContainer.Location = new Point(21, 526);
            pnFormContainer.Margin = new Padding(2);
            pnFormContainer.Name = "pnFormContainer";
            pnFormContainer.Size = new Size(433, 225);
            pnFormContainer.TabIndex = 15;
            // 
            // manuaSignOut
            // 
            manuaSignOut.BackColor = Color.Red;
            manuaSignOut.FlatAppearance.BorderSize = 0;
            manuaSignOut.FlatStyle = FlatStyle.Flat;
            manuaSignOut.ForeColor = Color.White;
            manuaSignOut.Location = new Point(332, 12);
            manuaSignOut.Name = "manuaSignOut";
            manuaSignOut.Size = new Size(122, 32);
            manuaSignOut.TabIndex = 21;
            manuaSignOut.Text = "Manual Sign out";
            manuaSignOut.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(manuaSignOut);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 775);
            panel2.Name = "panel2";
            panel2.Size = new Size(477, 56);
            panel2.TabIndex = 22;
            // 
            // FormIoLogDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(250, 250, 250);
            ClientSize = new Size(477, 831);
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
            Margin = new Padding(2);
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
        private Button manuaSignOut;
        private Panel panel2;
    }
}