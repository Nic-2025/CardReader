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
            panel1 = new Panel();
            label9 = new Label();
            pnFormField = new FlowLayoutPanel();
            btnSave = new Button();
            btnCancel = new Button();
            lbSignInValue = new Label();
            lbSignOutValue = new Label();
            _cbManual = new ComboBox();
            pnImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pImage).BeginInit();
            pnThongTin.SuspendLayout();
            pnFormContainer.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Segoe UI Variable Display", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTitle.Location = new Point(135, 16);
            lbTitle.Margin = new Padding(2, 0, 2, 0);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(196, 32);
            lbTitle.TabIndex = 0;
            lbTitle.Text = "Chi tiết thông tin";
            // 
            // _signIoStatus
            // 
            _signIoStatus.BackColor = Color.FromArgb(7, 148, 85);
            _signIoStatus.ForeColor = SystemColors.ActiveBorder;
            _signIoStatus.IsManual = false;
            _signIoStatus.IsSignIn = false;
            _signIoStatus.Location = new Point(17, 74);
            _signIoStatus.Margin = new Padding(1);
            _signIoStatus.Name = "_signIoStatus";
            _signIoStatus.Size = new Size(80, 26);
            _signIoStatus.TabIndex = 1;
            // 
            // lbSignInTime
            // 
            lbSignInTime.AutoSize = true;
            lbSignInTime.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbSignInTime.ForeColor = Color.FromArgb(102, 112, 133);
            lbSignInTime.Location = new Point(282, 74);
            lbSignInTime.Margin = new Padding(2, 0, 2, 0);
            lbSignInTime.Name = "lbSignInTime";
            lbSignInTime.Size = new Size(77, 19);
            lbSignInTime.TabIndex = 2;
            lbSignInTime.Text = "SignInTime";
            // 
            // lbSignOutTime
            // 
            lbSignOutTime.AutoSize = true;
            lbSignOutTime.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbSignOutTime.ForeColor = Color.FromArgb(102, 112, 133);
            lbSignOutTime.Location = new Point(379, 74);
            lbSignOutTime.Margin = new Padding(2, 0, 2, 0);
            lbSignOutTime.Name = "lbSignOutTime";
            lbSignOutTime.Size = new Size(60, 19);
            lbSignOutTime.TabIndex = 2;
            lbSignOutTime.Text = "Sign out";
            // 
            // pnImage
            // 
            pnImage.BackColor = Color.White;
            pnImage.Controls.Add(pImage);
            pnImage.Controls.Add(_verifyImage);
            pnImage.Controls.Add(label1);
            pnImage.Location = new Point(18, 152);
            pnImage.Margin = new Padding(2);
            pnImage.Name = "pnImage";
            pnImage.Padding = new Padding(16);
            pnImage.Size = new Size(421, 212);
            pnImage.TabIndex = 3;
            // 
            // pImage
            // 
            pImage.Location = new Point(108, 51);
            pImage.Margin = new Padding(2);
            pImage.Name = "pImage";
            pImage.Size = new Size(233, 143);
            pImage.TabIndex = 2;
            pImage.TabStop = false;
            // 
            // _verifyImage
            // 
            _verifyImage.AutoSize = true;
            _verifyImage.BackColor = Color.White;
            _verifyImage.IsVerified = false;
            _verifyImage.Location = new Point(286, 17);
            _verifyImage.Margin = new Padding(1);
            _verifyImage.Name = "_verifyImage";
            _verifyImage.Size = new Size(120, 21);
            _verifyImage.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Display", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 16);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(163, 26);
            label1.TabIndex = 0;
            label1.Text = "Chi tiết thông tin";
            // 
            // pnThongTin
            // 
            pnThongTin.BackColor = Color.White;
            pnThongTin.Controls.Add(label4);
            pnThongTin.Controls.Add(lbCCCDVal);
            pnThongTin.Controls.Add(lbHoTenVal);
            pnThongTin.Controls.Add(label3);
            pnThongTin.Controls.Add(_verifyCard);
            pnThongTin.Controls.Add(label2);
            pnThongTin.Font = new Font("Segoe UI", 9F);
            pnThongTin.Location = new Point(18, 386);
            pnThongTin.Margin = new Padding(2);
            pnThongTin.Name = "pnThongTin";
            pnThongTin.Padding = new Padding(16);
            pnThongTin.Size = new Size(421, 146);
            pnThongTin.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(198, 60);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(93, 19);
            label4.TabIndex = 2;
            label4.Text = "CCCD/CMND";
            // 
            // lbCCCDVal
            // 
            lbCCCDVal.AutoSize = true;
            lbCCCDVal.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbCCCDVal.Location = new Point(198, 91);
            lbCCCDVal.Margin = new Padding(2, 0, 2, 0);
            lbCCCDVal.Name = "lbCCCDVal";
            lbCCCDVal.Size = new Size(74, 19);
            lbCCCDVal.TabIndex = 2;
            lbCCCDVal.Text = "Họ và tên";
            // 
            // lbHoTenVal
            // 
            lbHoTenVal.AutoSize = true;
            lbHoTenVal.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbHoTenVal.Location = new Point(35, 91);
            lbHoTenVal.Margin = new Padding(2, 0, 2, 0);
            lbHoTenVal.Name = "lbHoTenVal";
            lbHoTenVal.Size = new Size(74, 19);
            lbHoTenVal.TabIndex = 2;
            lbHoTenVal.Text = "Họ và tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(35, 60);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(69, 19);
            label3.TabIndex = 2;
            label3.Text = "Họ và tên";
            // 
            // _verifyCard
            // 
            _verifyCard.BackColor = Color.White;
            _verifyCard.IsVerified = false;
            _verifyCard.Location = new Point(286, 16);
            _verifyCard.Margin = new Padding(1);
            _verifyCard.Name = "_verifyCard";
            _verifyCard.Size = new Size(118, 20);
            _verifyCard.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Display", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(14, 16);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(168, 26);
            label2.TabIndex = 0;
            label2.Text = "Thông tin cá nhân";
            // 
            // pnFormContainer
            // 
            pnFormContainer.AutoScroll = true;
            pnFormContainer.BackColor = Color.White;
            pnFormContainer.Controls.Add(panel1);
            pnFormContainer.Controls.Add(pnFormField);
            pnFormContainer.Location = new Point(17, 563);
            pnFormContainer.Margin = new Padding(2);
            pnFormContainer.Name = "pnFormContainer";
            pnFormContainer.Padding = new Padding(16);
            pnFormContainer.Size = new Size(422, 306);
            pnFormContainer.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.Controls.Add(label9);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(16, 16);
            panel1.Name = "panel1";
            panel1.Size = new Size(390, 49);
            panel1.TabIndex = 2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Variable Display", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(0, 0);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(145, 26);
            label9.TabIndex = 0;
            label9.Text = "Form thông tin";
            // 
            // pnFormField
            // 
            pnFormField.AutoScroll = true;
            pnFormField.BackColor = Color.FromArgb(250, 250, 250);
            pnFormField.Dock = DockStyle.Fill;
            pnFormField.FlowDirection = FlowDirection.TopDown;
            pnFormField.Location = new Point(16, 16);
            pnFormField.Name = "pnFormField";
            pnFormField.Size = new Size(390, 274);
            pnFormField.TabIndex = 1;
            pnFormField.WrapContents = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.SteelBlue;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 14F);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(334, 890);
            btnSave.Margin = new Padding(2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(105, 42);
            btnSave.TabIndex = 6;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += BtnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Red;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 14F);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(225, 890);
            btnCancel.Margin = new Padding(2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(105, 42);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += BtnCancel_Click;
            // 
            // lbSignInValue
            // 
            lbSignInValue.AutoSize = true;
            lbSignInValue.Location = new Point(301, 114);
            lbSignInValue.Margin = new Padding(2, 0, 2, 0);
            lbSignInValue.Name = "lbSignInValue";
            lbSignInValue.Size = new Size(30, 15);
            lbSignInValue.TabIndex = 7;
            lbSignInValue.Text = "--:--";
            // 
            // lbSignOutValue
            // 
            lbSignOutValue.AutoSize = true;
            lbSignOutValue.Location = new Point(396, 114);
            lbSignOutValue.Margin = new Padding(2, 0, 2, 0);
            lbSignOutValue.Name = "lbSignOutValue";
            lbSignOutValue.Size = new Size(30, 15);
            lbSignOutValue.TabIndex = 7;
            lbSignOutValue.Text = "--:--";
            // 
            // _cbManual
            // 
            _cbManual.FormattingEnabled = true;
            _cbManual.Items.AddRange(new object[] { "Automatic", "Manual Signout" });
            _cbManual.Location = new Point(107, 74);
            _cbManual.Margin = new Padding(2);
            _cbManual.Name = "_cbManual";
            _cbManual.Size = new Size(89, 23);
            _cbManual.TabIndex = 8;
            _cbManual.SelectedIndexChanged += CbManual_SelectedIndexChanged;
            // 
            // UiAuthen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
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
            Margin = new Padding(2);
            Name = "UiAuthen";
            Padding = new Padding(16);
            Size = new Size(457, 950);
            Load += UiAuthen_Load;
            pnImage.ResumeLayout(false);
            pnImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pImage).EndInit();
            pnThongTin.ResumeLayout(false);
            pnThongTin.PerformLayout();
            pnFormContainer.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Panel panel1;
    }
}
