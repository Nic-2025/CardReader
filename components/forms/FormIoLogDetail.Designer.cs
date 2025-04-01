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
            pnFormField = new FlowLayoutPanel();
            label9 = new Label();
            lbSignOutValue = new Label();
            pnFormContainer = new Panel();
            label4 = new Label();
            lbCCCDVal = new Label();
            lbHoTenVal = new Label();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            pImage = new PictureBox();
            pnThongTin = new Panel();
            pnImage = new Panel();
            lbSignOutTime = new Label();
            lbSignInTime = new Label();
            _signIoStatus = new IdCard.Hanel_obj.forms.UiSignIOStatus();
            lbTitle = new Label();
            pnFormContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pImage).BeginInit();
            pnThongTin.SuspendLayout();
            pnImage.SuspendLayout();
            SuspendLayout();
            // 
            // _cbManual
            // 
            _cbManual.FormattingEnabled = true;
            _cbManual.Items.AddRange(new object[] { "Automatic", "Manual Signout" });
            _cbManual.Location = new Point(326, -122);
            _cbManual.Name = "_cbManual";
            _cbManual.Size = new Size(96, 33);
            _cbManual.TabIndex = 20;
            // 
            // lbSignInValue
            // 
            lbSignInValue.AutoSize = true;
            lbSignInValue.Location = new Point(492, -75);
            lbSignInValue.Name = "lbSignInValue";
            lbSignInValue.Size = new Size(44, 25);
            lbSignInValue.TabIndex = 18;
            lbSignInValue.Text = "--:--";
            // 
            // pnFormField
            // 
            pnFormField.AutoScroll = true;
            pnFormField.BackColor = SystemColors.Control;
            pnFormField.Dock = DockStyle.Bottom;
            pnFormField.FlowDirection = FlowDirection.TopDown;
            pnFormField.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pnFormField.Location = new Point(0, 56);
            pnFormField.Name = "pnFormField";
            pnFormField.Size = new Size(543, 379);
            pnFormField.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Variable Display", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(3, 0);
            label9.Name = "label9";
            label9.Size = new Size(281, 53);
            label9.TabIndex = 0;
            label9.Text = "Form thông tin";
            // 
            // lbSignOutValue
            // 
            lbSignOutValue.AutoSize = true;
            lbSignOutValue.Location = new Point(694, -75);
            lbSignOutValue.Name = "lbSignOutValue";
            lbSignOutValue.Size = new Size(44, 25);
            lbSignOutValue.TabIndex = 19;
            lbSignOutValue.Text = "--:--";
            // 
            // pnFormContainer
            // 
            pnFormContainer.AutoScroll = true;
            pnFormContainer.Controls.Add(pnFormField);
            pnFormContainer.Controls.Add(label9);
            pnFormContainer.Location = new Point(24, 773);
            pnFormContainer.Name = "pnFormContainer";
            pnFormContainer.Size = new Size(543, 435);
            pnFormContainer.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(314, 145);
            label4.Name = "label4";
            label4.Size = new Size(180, 38);
            label4.TabIndex = 2;
            label4.Text = "CCCD/CMND";
            // 
            // lbCCCDVal
            // 
            lbCCCDVal.AutoSize = true;
            lbCCCDVal.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbCCCDVal.Location = new Point(314, 218);
            lbCCCDVal.Name = "lbCCCDVal";
            lbCCCDVal.Size = new Size(136, 38);
            lbCCCDVal.TabIndex = 2;
            lbCCCDVal.Text = "Họ và tên";
            // 
            // lbHoTenVal
            // 
            lbHoTenVal.AutoSize = true;
            lbHoTenVal.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbHoTenVal.Location = new Point(20, 218);
            lbHoTenVal.Name = "lbHoTenVal";
            lbHoTenVal.Size = new Size(136, 38);
            lbHoTenVal.TabIndex = 2;
            lbHoTenVal.Text = "Họ và tên";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Display", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(316, 53);
            label1.TabIndex = 0;
            label1.Text = "Chi tiết thông tin";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(20, 145);
            label3.Name = "label3";
            label3.Size = new Size(136, 38);
            label3.TabIndex = 2;
            label3.Text = "Họ và tên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Display", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(333, 53);
            label2.TabIndex = 0;
            label2.Text = "Thông tin cá nhân";
            // 
            // pImage
            // 
            pImage.Location = new Point(101, 78);
            pImage.Name = "pImage";
            pImage.Size = new Size(333, 239);
            pImage.TabIndex = 2;
            pImage.TabStop = false;
            // 
            // pnThongTin
            // 
            pnThongTin.Controls.Add(label4);
            pnThongTin.Controls.Add(lbCCCDVal);
            pnThongTin.Controls.Add(lbHoTenVal);
            pnThongTin.Controls.Add(label3);
            pnThongTin.Controls.Add(label2);
            pnThongTin.Location = new Point(24, 406);
            pnThongTin.Name = "pnThongTin";
            pnThongTin.Size = new Size(543, 331);
            pnThongTin.TabIndex = 14;
            // 
            // pnImage
            // 
            pnImage.Controls.Add(pImage);
            pnImage.Controls.Add(label1);
            pnImage.Location = new Point(27, 22);
            pnImage.Name = "pnImage";
            pnImage.Size = new Size(540, 353);
            pnImage.TabIndex = 13;
            // 
            // lbSignOutTime
            // 
            lbSignOutTime.AutoSize = true;
            lbSignOutTime.Font = new Font("Segoe UI Variable Display", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbSignOutTime.Location = new Point(662, -142);
            lbSignOutTime.Name = "lbSignOutTime";
            lbSignOutTime.Size = new Size(121, 37);
            lbSignOutTime.TabIndex = 11;
            lbSignOutTime.Text = "Sign out";
            // 
            // lbSignInTime
            // 
            lbSignInTime.AutoSize = true;
            lbSignInTime.Font = new Font("Segoe UI Variable Display", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbSignInTime.Location = new Point(465, -142);
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
            _signIoStatus.Location = new Point(196, -126);
            _signIoStatus.Name = "_signIoStatus";
            _signIoStatus.Size = new Size(124, 37);
            _signIoStatus.TabIndex = 10;
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Segoe UI Variable Display", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTitle.Location = new Point(313, -224);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(384, 64);
            lbTitle.TabIndex = 9;
            lbTitle.Text = "Chi tiết thông tin";
            // 
            // FormIoLogDetail
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(616, 1263);
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
            Text = "Chi tiết thông tin";
            pnFormContainer.ResumeLayout(false);
            pnFormContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pImage).EndInit();
            pnThongTin.ResumeLayout(false);
            pnThongTin.PerformLayout();
            pnImage.ResumeLayout(false);
            pnImage.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox _cbManual;
        private Label lbSignInValue;
        private FlowLayoutPanel pnFormField;
        private Label label9;
        private Label lbSignOutValue;
        private Panel pnFormContainer;
        private Label label4;
        private Label lbCCCDVal;
        private Label lbHoTenVal;
        private Label label1;
        private Label label3;
        private Label label2;
        private PictureBox pImage;
        private Panel pnThongTin;
        private Panel pnImage;
        private Label lbSignOutTime;
        private Label lbSignInTime;
        private Hanel_obj.forms.UiSignIOStatus _signIoStatus;
        private Label lbTitle;
    }
}