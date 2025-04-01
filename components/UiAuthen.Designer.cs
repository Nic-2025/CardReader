namespace IdCard.Hanel_obj.forms
{
    partial class UiAuthen
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
            lbTitle = new Label();
            _signIoStatus = new UiSignIOStatus();
            lbSignInTime = new Label();
            lbSignOutTime = new Label();
            pnImage = new Panel();
            pImage = new PictureBox();
            _verifyImage = new UiVerifiedStatus();
            label1 = new Label();
            pnThongTin = new Panel();
            label4 = new Label();
            lbCCCDVal = new Label();
            lbHoTenVal = new Label();
            label3 = new Label();
            _verifyCard = new UiVerifiedStatus();
            label2 = new Label();
            pnFormContainer = new Panel();
            pnFormField = new FlowLayoutPanel();
            label9 = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            lbSignInValue = new Label();
            lbSignOutValue = new Label();
            _cbManual = new ComboBox();
            pnImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pImage).BeginInit();
            pnThongTin.SuspendLayout();
            pnFormContainer.SuspendLayout();
            SuspendLayout();
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Segoe UI Variable Display", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTitle.Location = new Point(150, 0);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(384, 64);
            lbTitle.TabIndex = 0;
            lbTitle.Text = "Chi tiết thông tin";
            // 
            // _signIoStatus
            // 
            _signIoStatus.BackColor = Color.FromArgb(7, 148, 85);
            _signIoStatus.IsManual = false;
            _signIoStatus.IsSignIn = false;
            _signIoStatus.Location = new Point(33, 98);
            _signIoStatus.Name = "_signIoStatus";
            _signIoStatus.Size = new Size(124, 37);
            _signIoStatus.TabIndex = 1;
            // 
            // lbSignInTime
            // 
            lbSignInTime.AutoSize = true;
            lbSignInTime.Font = new Font("Segoe UI Variable Display", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbSignInTime.Location = new Point(302, 82);
            lbSignInTime.Name = "lbSignInTime";
            lbSignInTime.Size = new Size(155, 37);
            lbSignInTime.TabIndex = 2;
            lbSignInTime.Text = "SignInTime";
            // 
            // lbSignOutTime
            // 
            lbSignOutTime.AutoSize = true;
            lbSignOutTime.Font = new Font("Segoe UI Variable Display", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbSignOutTime.Location = new Point(499, 82);
            lbSignOutTime.Name = "lbSignOutTime";
            lbSignOutTime.Size = new Size(121, 37);
            lbSignOutTime.TabIndex = 2;
            lbSignOutTime.Text = "Sign out";
            // 
            // pnImage
            // 
            pnImage.Controls.Add(pImage);
            pnImage.Controls.Add(_verifyImage);
            pnImage.Controls.Add(label1);
            pnImage.Location = new Point(49, 226);
            pnImage.Name = "pnImage";
            pnImage.Size = new Size(543, 353);
            pnImage.TabIndex = 3;
            // 
            // pImage
            // 
            pImage.Location = new Point(101, 78);
            pImage.Name = "pImage";
            pImage.Size = new Size(333, 239);
            pImage.TabIndex = 2;
            pImage.TabStop = false;
            // 
            // _verifyImage
            // 
            _verifyImage.BackColor = Color.White;
            _verifyImage.IsVerified = false;
            _verifyImage.Location = new Point(368, 3);
            _verifyImage.Name = "_verifyImage";
            _verifyImage.Size = new Size(172, 35);
            _verifyImage.TabIndex = 1;
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
            // pnThongTin
            // 
            pnThongTin.Controls.Add(label4);
            pnThongTin.Controls.Add(lbCCCDVal);
            pnThongTin.Controls.Add(lbHoTenVal);
            pnThongTin.Controls.Add(label3);
            pnThongTin.Controls.Add(_verifyCard);
            pnThongTin.Controls.Add(label2);
            pnThongTin.Location = new Point(49, 613);
            pnThongTin.Name = "pnThongTin";
            pnThongTin.Size = new Size(543, 331);
            pnThongTin.TabIndex = 4;
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
            // _verifyCard
            // 
            _verifyCard.BackColor = Color.White;
            _verifyCard.IsVerified = false;
            _verifyCard.Location = new Point(371, 3);
            _verifyCard.Name = "_verifyCard";
            _verifyCard.Size = new Size(169, 33);
            _verifyCard.TabIndex = 1;
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
            // pnFormContainer
            // 
            pnFormContainer.AutoScroll = true;
            pnFormContainer.Controls.Add(pnFormField);
            pnFormContainer.Controls.Add(label9);
            pnFormContainer.Location = new Point(49, 978);
            pnFormContainer.Name = "pnFormContainer";
            pnFormContainer.Size = new Size(543, 435);
            pnFormContainer.TabIndex = 5;
            // 
            // pnFormField
            // 
            pnFormField.AutoScroll = true;
            pnFormField.BackColor = SystemColors.ActiveCaption;
            pnFormField.Dock = DockStyle.Bottom;
            pnFormField.FlowDirection = FlowDirection.TopDown;
            pnFormField.Location = new Point(0, 76);
            pnFormField.Name = "pnFormField";
            pnFormField.Size = new Size(543, 359);
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
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(442, 1447);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(150, 70);
            btnSave.TabIndex = 6;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += BtnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(231, 1447);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(150, 70);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += BtnCancel_Click;
            // 
            // lbSignInValue
            // 
            lbSignInValue.AutoSize = true;
            lbSignInValue.Location = new Point(329, 149);
            lbSignInValue.Name = "lbSignInValue";
            lbSignInValue.Size = new Size(44, 25);
            lbSignInValue.TabIndex = 7;
            lbSignInValue.Text = "--:--";
            // 
            // lbSignOutValue
            // 
            lbSignOutValue.AutoSize = true;
            lbSignOutValue.Location = new Point(531, 149);
            lbSignOutValue.Name = "lbSignOutValue";
            lbSignOutValue.Size = new Size(44, 25);
            lbSignOutValue.TabIndex = 7;
            lbSignOutValue.Text = "--:--";
            // 
            // _cbManual
            // 
            _cbManual.FormattingEnabled = true;
            _cbManual.Items.AddRange(new object[] { "Automatic", "Manual Signout" });
            _cbManual.Location = new Point(163, 102);
            _cbManual.Name = "_cbManual";
            _cbManual.Size = new Size(96, 33);
            _cbManual.TabIndex = 8;
            _cbManual.SelectedIndexChanged += CbManual_SelectedIndexChanged;
            // 
            // UiAuthen
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(_cbManual);
            Controls.Add(lbSignOutValue);
            Controls.Add(lbSignInValue);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(pnFormContainer);
            Controls.Add(pnThongTin);
            Controls.Add(pnImage);
            Controls.Add(lbSignOutTime);
            Controls.Add(lbSignInTime);
            Controls.Add(_signIoStatus);
            Controls.Add(lbTitle);
            Name = "UiAuthen";
            Size = new Size(653, 1548);
            pnImage.ResumeLayout(false);
            pnImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pImage).EndInit();
            pnThongTin.ResumeLayout(false);
            pnThongTin.PerformLayout();
            pnFormContainer.ResumeLayout(false);
            pnFormContainer.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTitle;
        private UiSignIOStatus _signIoStatus;
        private Label lbSignInTime;
        private Label lbSignOutTime;
        private Panel pnImage;
        private UiVerifiedStatus _verifyImage;
        private Label label1;
        private Panel pnThongTin;
        private UiVerifiedStatus _verifyCard;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lbCCCDVal;
        private Label lbHoTenVal;
        private Panel pnFormContainer;
        private Label label9;
        private PictureBox pImage;
        private Button btnSave;
        private Button btnCancel;
        private Label lbSignInValue;
        private Label lbSignOutValue;
        private FlowLayoutPanel pnFormField;
        private ComboBox _cbManual;
    }
}
