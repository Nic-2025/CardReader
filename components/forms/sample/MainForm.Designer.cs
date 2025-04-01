namespace IdCard.Hanel
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            txtDSCert = new TextBox();
            txtMRZ = new TextBox();
            txtPreviousNumber = new Label();
            txtSex = new Label();
            txtIssueDate = new Label();
            txtName = new Label();
            txtPartnerName = new Label();
            txtMotherName = new Label();
            txtFatherName = new Label();
            txtExpiredDate = new Label();
            txtCharacter = new Label();
            txtAddress = new Label();
            txtHometown = new Label();
            txtReligion = new Label();
            txtNation = new Label();
            txtNationality = new Label();
            txtDateOfBirth = new Label();
            txtDocumentNumber = new Label();
            pictureIdcardBack = new PictureBox();
            picIdcardFront = new PictureBox();
            picChipImage = new PictureBox();
            label3 = new Label();
            lbReaderStatus = new Label();
            label4 = new Label();
            lbCardStatus = new Label();
            label6 = new Label();
            lbTimeLb = new Label();
            lbTime = new Label();
            groupBox2 = new GroupBox();
            cbProcessStep = new ComboBox();
            btnRejectCard = new Button();
            cbReaderTypes = new ComboBox();
            chkAutoRead = new CheckBox();
            label2 = new Label();
            label1 = new Label();
            picCamera = new PictureBox();
            btnFaceMatching = new Button();
            btnClearForm = new Button();
            chkDelteForm = new CheckBox();
            lbFaceMatching = new Label();
            btnReadQR = new Button();
            txtFastRead = new CheckBox();
            groupBox3 = new GroupBox();
            cbAntiSpoofing = new ComboBox();
            btnCompare = new Button();
            btnRefreshCamera = new Button();
            numFaceDurationTime = new NumericUpDown();
            label9 = new Label();
            numFaceTimeout = new NumericUpDown();
            label8 = new Label();
            chkAutocapture = new CheckBox();
            cbFaceCameras = new ComboBox();
            label7 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            chkPaused = new CheckBox();
            label5 = new Label();
            cbOcrMode = new ComboBox();
            btnTest = new Button();
            btnCompareTest = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureIdcardBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picIdcardFront).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picChipImage).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCamera).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numFaceDurationTime).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numFaceTimeout).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtDSCert);
            groupBox1.Controls.Add(txtMRZ);
            groupBox1.Controls.Add(txtPreviousNumber);
            groupBox1.Controls.Add(txtSex);
            groupBox1.Controls.Add(txtIssueDate);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(txtPartnerName);
            groupBox1.Controls.Add(txtMotherName);
            groupBox1.Controls.Add(txtFatherName);
            groupBox1.Controls.Add(txtExpiredDate);
            groupBox1.Controls.Add(txtCharacter);
            groupBox1.Controls.Add(txtAddress);
            groupBox1.Controls.Add(txtHometown);
            groupBox1.Controls.Add(txtReligion);
            groupBox1.Controls.Add(txtNation);
            groupBox1.Controls.Add(txtNationality);
            groupBox1.Controls.Add(txtDateOfBirth);
            groupBox1.Controls.Add(txtDocumentNumber);
            groupBox1.Controls.Add(pictureIdcardBack);
            groupBox1.Controls.Add(picIdcardFront);
            groupBox1.Controls.Add(picChipImage);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 165);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(727, 633);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dữ liệu thẻ";
            // 
            // txtDSCert
            // 
            txtDSCert.Location = new Point(215, 504);
            txtDSCert.Multiline = true;
            txtDSCert.Name = "txtDSCert";
            txtDSCert.ReadOnly = true;
            txtDSCert.Size = new Size(477, 74);
            txtDSCert.TabIndex = 3;
            // 
            // txtMRZ
            // 
            txtMRZ.Location = new Point(215, 410);
            txtMRZ.Multiline = true;
            txtMRZ.Name = "txtMRZ";
            txtMRZ.ReadOnly = true;
            txtMRZ.Size = new Size(477, 78);
            txtMRZ.TabIndex = 3;
            // 
            // txtPreviousNumber
            // 
            txtPreviousNumber.AutoSize = true;
            txtPreviousNumber.Location = new Point(460, 61);
            txtPreviousNumber.Name = "txtPreviousNumber";
            txtPreviousNumber.Size = new Size(119, 25);
            txtPreviousNumber.TabIndex = 0;
            txtPreviousNumber.Text = "Số CMND cũ";
            // 
            // txtSex
            // 
            txtSex.AutoSize = true;
            txtSex.Location = new Point(215, 104);
            txtSex.Name = "txtSex";
            txtSex.Size = new Size(84, 25);
            txtSex.TabIndex = 0;
            txtSex.Text = "Giới tính";
            // 
            // txtIssueDate
            // 
            txtIssueDate.AutoSize = true;
            txtIssueDate.Location = new Point(460, 201);
            txtIssueDate.Name = "txtIssueDate";
            txtIssueDate.Size = new Size(91, 25);
            txtIssueDate.TabIndex = 0;
            txtIssueDate.Text = "Ngày cấp";
            // 
            // txtName
            // 
            txtName.AutoSize = true;
            txtName.Location = new Point(215, 26);
            txtName.Name = "txtName";
            txtName.Size = new Size(92, 25);
            txtName.TabIndex = 0;
            txtName.Text = "Họ và tên";
            // 
            // txtPartnerName
            // 
            txtPartnerName.AutoSize = true;
            txtPartnerName.Location = new Point(460, 26);
            txtPartnerName.Name = "txtPartnerName";
            txtPartnerName.Size = new Size(98, 25);
            txtPartnerName.TabIndex = 0;
            txtPartnerName.Text = "Vợ/Chồng";
            // 
            // txtMotherName
            // 
            txtMotherName.AutoSize = true;
            txtMotherName.Location = new Point(460, 166);
            txtMotherName.Name = "txtMotherName";
            txtMotherName.Size = new Size(39, 25);
            txtMotherName.TabIndex = 0;
            txtMotherName.Text = "Mẹ";
            // 
            // txtFatherName
            // 
            txtFatherName.AutoSize = true;
            txtFatherName.Location = new Point(215, 166);
            txtFatherName.Name = "txtFatherName";
            txtFatherName.Size = new Size(34, 25);
            txtFatherName.TabIndex = 0;
            txtFatherName.Text = "Bố";
            // 
            // txtExpiredDate
            // 
            txtExpiredDate.AutoSize = true;
            txtExpiredDate.Location = new Point(215, 143);
            txtExpiredDate.Name = "txtExpiredDate";
            txtExpiredDate.Size = new Size(78, 25);
            txtExpiredDate.TabIndex = 0;
            txtExpiredDate.Text = "Hết hạn";
            // 
            // txtCharacter
            // 
            txtCharacter.AutoSize = true;
            txtCharacter.Location = new Point(215, 260);
            txtCharacter.Name = "txtCharacter";
            txtCharacter.Size = new Size(123, 25);
            txtCharacter.TabIndex = 0;
            txtCharacter.Text = "Đặc điểm ND";
            // 
            // txtAddress
            // 
            txtAddress.AutoSize = true;
            txtAddress.Location = new Point(215, 338);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(70, 25);
            txtAddress.TabIndex = 0;
            txtAddress.Text = "Địa chỉ";
            // 
            // txtHometown
            // 
            txtHometown.AutoSize = true;
            txtHometown.Location = new Point(215, 299);
            txtHometown.Name = "txtHometown";
            txtHometown.Size = new Size(95, 25);
            txtHometown.TabIndex = 0;
            txtHometown.Text = "Quê quán";
            // 
            // txtReligion
            // 
            txtReligion.AutoSize = true;
            txtReligion.Location = new Point(460, 131);
            txtReligion.Name = "txtReligion";
            txtReligion.Size = new Size(84, 25);
            txtReligion.TabIndex = 0;
            txtReligion.Text = "Tôn giáo";
            // 
            // txtNation
            // 
            txtNation.AutoSize = true;
            txtNation.Location = new Point(215, 221);
            txtNation.Name = "txtNation";
            txtNation.Size = new Size(77, 25);
            txtNation.TabIndex = 0;
            txtNation.Text = "Dân tộc";
            // 
            // txtNationality
            // 
            txtNationality.AutoSize = true;
            txtNationality.Location = new Point(460, 96);
            txtNationality.Name = "txtNationality";
            txtNationality.Size = new Size(93, 25);
            txtNationality.TabIndex = 0;
            txtNationality.Text = "Quốc tịch";
            // 
            // txtDateOfBirth
            // 
            txtDateOfBirth.AutoSize = true;
            txtDateOfBirth.Location = new Point(215, 182);
            txtDateOfBirth.Name = "txtDateOfBirth";
            txtDateOfBirth.Size = new Size(96, 25);
            txtDateOfBirth.TabIndex = 0;
            txtDateOfBirth.Text = "Ngày sinh";
            // 
            // txtDocumentNumber
            // 
            txtDocumentNumber.AutoSize = true;
            txtDocumentNumber.Location = new Point(215, 65);
            txtDocumentNumber.Name = "txtDocumentNumber";
            txtDocumentNumber.Size = new Size(85, 25);
            txtDocumentNumber.TabIndex = 0;
            txtDocumentNumber.Text = "Số CCCD";
            // 
            // pictureIdcardBack
            // 
            pictureIdcardBack.BorderStyle = BorderStyle.FixedSingle;
            pictureIdcardBack.Location = new Point(9, 401);
            pictureIdcardBack.Name = "pictureIdcardBack";
            pictureIdcardBack.Size = new Size(152, 109);
            pictureIdcardBack.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureIdcardBack.TabIndex = 1;
            pictureIdcardBack.TabStop = false;
            pictureIdcardBack.Visible = false;
            // 
            // picIdcardFront
            // 
            picIdcardFront.BorderStyle = BorderStyle.FixedSingle;
            picIdcardFront.Location = new Point(6, 283);
            picIdcardFront.Name = "picIdcardFront";
            picIdcardFront.Size = new Size(152, 93);
            picIdcardFront.SizeMode = PictureBoxSizeMode.StretchImage;
            picIdcardFront.TabIndex = 1;
            picIdcardFront.TabStop = false;
            picIdcardFront.Visible = false;
            // 
            // picChipImage
            // 
            picChipImage.BorderStyle = BorderStyle.FixedSingle;
            picChipImage.Location = new Point(9, 61);
            picChipImage.Name = "picChipImage";
            picChipImage.Size = new Size(149, 198);
            picChipImage.SizeMode = PictureBoxSizeMode.StretchImage;
            picChipImage.TabIndex = 1;
            picChipImage.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 33);
            label3.Name = "label3";
            label3.Size = new Size(90, 25);
            label3.TabIndex = 2;
            label3.Text = "Ảnh Chip";
            // 
            // lbReaderStatus
            // 
            lbReaderStatus.AutoSize = true;
            lbReaderStatus.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lbReaderStatus.ForeColor = Color.Red;
            lbReaderStatus.Location = new Point(87, 64);
            lbReaderStatus.Name = "lbReaderStatus";
            lbReaderStatus.Size = new Size(125, 35);
            lbReaderStatus.TabIndex = 4;
            lbReaderStatus.Text = "Không có";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(14, 64);
            label4.Name = "label4";
            label4.Size = new Size(67, 35);
            label4.TabIndex = 5;
            label4.Text = "Imei";
            // 
            // lbCardStatus
            // 
            lbCardStatus.AutoSize = true;
            lbCardStatus.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lbCardStatus.ForeColor = Color.Red;
            lbCardStatus.Location = new Point(530, 64);
            lbCardStatus.Name = "lbCardStatus";
            lbCardStatus.Size = new Size(125, 35);
            lbCardStatus.TabIndex = 4;
            lbCardStatus.Text = "Không có";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(455, 64);
            label6.Name = "label6";
            label6.Size = new Size(69, 35);
            label6.TabIndex = 5;
            label6.Text = "Card";
            // 
            // lbTimeLb
            // 
            lbTimeLb.AutoSize = true;
            lbTimeLb.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lbTimeLb.Location = new Point(18, 106);
            lbTimeLb.Name = "lbTimeLb";
            lbTimeLb.Size = new Size(125, 35);
            lbTimeLb.TabIndex = 5;
            lbTimeLb.Text = "Thời gian";
            // 
            // lbTime
            // 
            lbTime.AutoSize = true;
            lbTime.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lbTime.ForeColor = Color.Blue;
            lbTime.Location = new Point(140, 99);
            lbTime.Name = "lbTime";
            lbTime.Size = new Size(153, 46);
            lbTime.TabIndex = 4;
            lbTime.Text = "00.000 s";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cbProcessStep);
            groupBox2.Controls.Add(btnRejectCard);
            groupBox2.Controls.Add(cbReaderTypes);
            groupBox2.Controls.Add(chkAutoRead);
            groupBox2.Controls.Add(lbReaderStatus);
            groupBox2.Controls.Add(lbTimeLb);
            groupBox2.Controls.Add(lbCardStatus);
            groupBox2.Controls.Add(lbTime);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(12, 1);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(727, 153);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            // 
            // cbProcessStep
            // 
            cbProcessStep.DropDownStyle = ComboBoxStyle.DropDownList;
            cbProcessStep.FormattingEnabled = true;
            cbProcessStep.Items.AddRange(new object[] { "Chỉ đọc thẻ", "Đọc thẻ => Xác minh khuôn mặt" });
            cbProcessStep.Location = new Point(460, 28);
            cbProcessStep.Name = "cbProcessStep";
            cbProcessStep.Size = new Size(245, 28);
            cbProcessStep.TabIndex = 9;
            cbProcessStep.SelectedIndexChanged += cbProcessStep_SelectedIndexChanged;
            // 
            // btnRejectCard
            // 
            btnRejectCard.Location = new Point(314, 28);
            btnRejectCard.Name = "btnRejectCard";
            btnRejectCard.Size = new Size(94, 29);
            btnRejectCard.TabIndex = 8;
            btnRejectCard.Text = "Reject card";
            btnRejectCard.UseVisualStyleBackColor = true;
            btnRejectCard.Visible = false;
            btnRejectCard.Click += btnRejectCard_Click;
            // 
            // cbReaderTypes
            // 
            cbReaderTypes.DropDownStyle = ComboBoxStyle.DropDownList;
            cbReaderTypes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbReaderTypes.FormattingEnabled = true;
            cbReaderTypes.Items.AddRange(new object[] { "HN212", "SCAN" });
            cbReaderTypes.Location = new Point(92, 23);
            cbReaderTypes.Name = "cbReaderTypes";
            cbReaderTypes.Size = new Size(151, 36);
            cbReaderTypes.TabIndex = 7;
            cbReaderTypes.SelectedIndexChanged += CbReaderTypes_SelectedIndexChanged;
            // 
            // chkAutoRead
            // 
            chkAutoRead.AutoSize = true;
            chkAutoRead.Checked = true;
            chkAutoRead.CheckState = CheckState.Checked;
            chkAutoRead.Location = new Point(543, 118);
            chkAutoRead.Name = "chkAutoRead";
            chkAutoRead.Size = new Size(184, 24);
            chkAutoRead.TabIndex = 6;
            chkAutoRead.Text = "Tự động đọc khi có thẻ";
            chkAutoRead.UseVisualStyleBackColor = true;
            chkAutoRead.CheckedChanged += chkAutoRead_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(14, 20);
            label2.Name = "label2";
            label2.Size = new Size(72, 35);
            label2.TabIndex = 5;
            label2.Text = "Type";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 24);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 2;
            label1.Text = "Ảnh camera";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // picCamera
            // 
            picCamera.BorderStyle = BorderStyle.FixedSingle;
            picCamera.Location = new Point(21, 62);
            picCamera.Name = "picCamera";
            picCamera.Size = new Size(164, 219);
            picCamera.SizeMode = PictureBoxSizeMode.StretchImage;
            picCamera.TabIndex = 1;
            picCamera.TabStop = false;
            // 
            // btnFaceMatching
            // 
            btnFaceMatching.Location = new Point(21, 540);
            btnFaceMatching.Name = "btnFaceMatching";
            btnFaceMatching.Size = new Size(153, 38);
            btnFaceMatching.TabIndex = 7;
            btnFaceMatching.Text = "Chụp ảnh";
            btnFaceMatching.UseVisualStyleBackColor = true;
            btnFaceMatching.Click += btnFaceMatching_Click;
            // 
            // btnClearForm
            // 
            btnClearForm.Location = new Point(772, 717);
            btnClearForm.Name = "btnClearForm";
            btnClearForm.Size = new Size(150, 29);
            btnClearForm.TabIndex = 7;
            btnClearForm.Text = "Xóa dữ liệu";
            btnClearForm.UseVisualStyleBackColor = true;
            btnClearForm.Click += btnClearForm_Click;
            // 
            // chkDelteForm
            // 
            chkDelteForm.AutoSize = true;
            chkDelteForm.Checked = true;
            chkDelteForm.CheckState = CheckState.Checked;
            chkDelteForm.Location = new Point(942, 717);
            chkDelteForm.Name = "chkDelteForm";
            chkDelteForm.Size = new Size(127, 24);
            chkDelteForm.TabIndex = 8;
            chkDelteForm.Text = "Xóa khi rút thẻ";
            chkDelteForm.UseVisualStyleBackColor = true;
            // 
            // lbFaceMatching
            // 
            lbFaceMatching.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lbFaceMatching.ForeColor = Color.Red;
            lbFaceMatching.Location = new Point(7, 284);
            lbFaceMatching.Name = "lbFaceMatching";
            lbFaceMatching.Size = new Size(196, 35);
            lbFaceMatching.TabIndex = 4;
            lbFaceMatching.Text = "Không có";
            lbFaceMatching.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnReadQR
            // 
            btnReadQR.Location = new Point(1108, 717);
            btnReadQR.Name = "btnReadQR";
            btnReadQR.Size = new Size(53, 29);
            btnReadQR.TabIndex = 9;
            btnReadQR.Text = "Đọc QRCode";
            btnReadQR.UseVisualStyleBackColor = true;
            btnReadQR.Visible = false;
            btnReadQR.Click += btnReadQR_Click;
            // 
            // txtFastRead
            // 
            txtFastRead.AutoSize = true;
            txtFastRead.Checked = true;
            txtFastRead.CheckState = CheckState.Checked;
            txtFastRead.Location = new Point(759, 24);
            txtFastRead.Name = "txtFastRead";
            txtFastRead.Size = new Size(102, 24);
            txtFastRead.TabIndex = 10;
            txtFastRead.Text = "Đọc nhanh";
            txtFastRead.UseVisualStyleBackColor = true;
            txtFastRead.CheckedChanged += TxtFastRead_CheckedChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(cbAntiSpoofing);
            groupBox3.Controls.Add(btnCompare);
            groupBox3.Controls.Add(btnRefreshCamera);
            groupBox3.Controls.Add(numFaceDurationTime);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(numFaceTimeout);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(chkAutocapture);
            groupBox3.Controls.Add(cbFaceCameras);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(picCamera);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(lbFaceMatching);
            groupBox3.Controls.Add(btnFaceMatching);
            groupBox3.Location = new Point(745, 169);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(341, 584);
            groupBox3.TabIndex = 11;
            groupBox3.TabStop = false;
            groupBox3.Text = "Đối sánh khuôn mặt";
            // 
            // cbAntiSpoofing
            // 
            cbAntiSpoofing.DropDownStyle = ComboBoxStyle.DropDownList;
            cbAntiSpoofing.FormattingEnabled = true;
            cbAntiSpoofing.Items.AddRange(new object[] { "Tắt", "Thấp", "Trung bình", "Cao" });
            cbAntiSpoofing.Location = new Point(218, 496);
            cbAntiSpoofing.Name = "cbAntiSpoofing";
            cbAntiSpoofing.Size = new Size(115, 28);
            cbAntiSpoofing.TabIndex = 15;
            cbAntiSpoofing.SelectedIndexChanged += cbAntiSpoofing_SelectedIndexChanged;
            // 
            // btnCompare
            // 
            btnCompare.Location = new Point(193, 153);
            btnCompare.Name = "btnCompare";
            btnCompare.Size = new Size(94, 42);
            btnCompare.TabIndex = 14;
            btnCompare.Text = "So sánh";
            btnCompare.UseVisualStyleBackColor = true;
            btnCompare.Click += btnCompare_Click;
            // 
            // btnRefreshCamera
            // 
            btnRefreshCamera.Location = new Point(262, 345);
            btnRefreshCamera.Name = "btnRefreshCamera";
            btnRefreshCamera.Size = new Size(71, 29);
            btnRefreshCamera.TabIndex = 13;
            btnRefreshCamera.Text = "Refresh";
            btnRefreshCamera.UseVisualStyleBackColor = true;
            btnRefreshCamera.Click += btnRefreshCamera_Click;
            // 
            // numFaceDurationTime
            // 
            numFaceDurationTime.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            numFaceDurationTime.Location = new Point(256, 461);
            numFaceDurationTime.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            numFaceDurationTime.Name = "numFaceDurationTime";
            numFaceDurationTime.Size = new Size(77, 27);
            numFaceDurationTime.TabIndex = 12;
            numFaceDurationTime.Value = new decimal(new int[] { 200, 0, 0, 0 });
            numFaceDurationTime.ValueChanged += numFaceDurationTime_ValueChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(24, 465);
            label9.Name = "label9";
            label9.Size = new Size(224, 20);
            label9.TabIndex = 11;
            label9.Text = "Thời gian duy trì khuôn mặt (ms)";
            // 
            // numFaceTimeout
            // 
            numFaceTimeout.Increment = new decimal(new int[] { 1000, 0, 0, 0 });
            numFaceTimeout.Location = new Point(256, 401);
            numFaceTimeout.Maximum = new decimal(new int[] { 30000, 0, 0, 0 });
            numFaceTimeout.Name = "numFaceTimeout";
            numFaceTimeout.Size = new Size(77, 27);
            numFaceTimeout.TabIndex = 12;
            numFaceTimeout.Value = new decimal(new int[] { 10000, 0, 0, 0 });
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(24, 499);
            label8.Name = "label8";
            label8.Size = new Size(111, 20);
            label8.TabIndex = 11;
            label8.Text = "Chống giả mạo";
            // 
            // chkAutocapture
            // 
            chkAutocapture.AutoSize = true;
            chkAutocapture.Checked = true;
            chkAutocapture.CheckState = CheckState.Checked;
            chkAutocapture.Location = new Point(24, 435);
            chkAutocapture.Name = "chkAutocapture";
            chkAutocapture.Size = new Size(150, 24);
            chkAutocapture.TabIndex = 10;
            chkAutocapture.Text = "Chụp ảnh tự động";
            chkAutocapture.UseVisualStyleBackColor = true;
            chkAutocapture.CheckedChanged += chkAutocapture_CheckedChanged;
            // 
            // cbFaceCameras
            // 
            cbFaceCameras.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFaceCameras.FormattingEnabled = true;
            cbFaceCameras.Location = new Point(80, 348);
            cbFaceCameras.Name = "cbFaceCameras";
            cbFaceCameras.Size = new Size(168, 28);
            cbFaceCameras.TabIndex = 9;
            cbFaceCameras.SelectedIndexChanged += cbFaceCameras_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 356);
            label7.Name = "label7";
            label7.Size = new Size(60, 20);
            label7.TabIndex = 8;
            label7.Text = "Camera";
            // 
            // chkPaused
            // 
            chkPaused.AutoSize = true;
            chkPaused.Location = new Point(937, 25);
            chkPaused.Name = "chkPaused";
            chkPaused.Size = new Size(68, 24);
            chkPaused.TabIndex = 12;
            chkPaused.Text = "Pause";
            chkPaused.UseVisualStyleBackColor = true;
            chkPaused.CheckedChanged += chkPaused_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(759, 65);
            label5.Name = "label5";
            label5.Size = new Size(81, 20);
            label5.TabIndex = 13;
            label5.Text = "OCR Mode";
            // 
            // cbOcrMode
            // 
            cbOcrMode.DropDownStyle = ComboBoxStyle.DropDownList;
            cbOcrMode.FormattingEnabled = true;
            cbOcrMode.Items.AddRange(new object[] { "FAST", "MID", "SLOW", "AUTO" });
            cbOcrMode.Location = new Point(851, 63);
            cbOcrMode.Name = "cbOcrMode";
            cbOcrMode.Size = new Size(151, 28);
            cbOcrMode.TabIndex = 14;
            cbOcrMode.SelectedIndexChanged += cbOcrMode_SelectedIndexChanged;
            // 
            // btnTest
            // 
            btnTest.Location = new Point(759, 107);
            btnTest.Name = "btnTest";
            btnTest.Size = new Size(94, 29);
            btnTest.TabIndex = 15;
            btnTest.Text = "Waken";
            btnTest.UseVisualStyleBackColor = true;
            btnTest.Click += btnTest_Click;
            // 
            // btnCompareTest
            // 
            btnCompareTest.Location = new Point(859, 107);
            btnCompareTest.Name = "btnCompareTest";
            btnCompareTest.Size = new Size(92, 29);
            btnCompareTest.TabIndex = 16;
            btnCompareTest.Text = "Cmp";
            btnCompareTest.UseVisualStyleBackColor = true;
            btnCompareTest.Visible = false;
            btnCompareTest.Click += btnCompareTest_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1094, 791);
            Controls.Add(btnCompareTest);
            Controls.Add(btnTest);
            Controls.Add(cbOcrMode);
            Controls.Add(label5);
            Controls.Add(chkPaused);
            Controls.Add(groupBox3);
            Controls.Add(txtFastRead);
            Controls.Add(btnReadQR);
            Controls.Add(chkDelteForm);
            Controls.Add(btnClearForm);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Xác thực Căn Cước";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureIdcardBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)picIdcardFront).EndInit();
            ((System.ComponentModel.ISupportInitialize)picChipImage).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picCamera).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numFaceDurationTime).EndInit();
            ((System.ComponentModel.ISupportInitialize)numFaceTimeout).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label txtSex;
        private Label txtName;
        private Label txtNationality;
        private Label txtDocumentNumber;
        private PictureBox picChipImage;
        private Label label3;
        private Label lbReaderStatus;
        private Label label4;
        private Label lbCardStatus;
        private Label label6;
        private Label lbTimeLb;
        private Label lbTime;
        private Label txtReligion;
        private Label txtDateOfBirth;
        private Label txtIssueDate;
        private Label txtPreviousNumber;
        private Label txtNation;
        private Label txtPartnerName;
        private Label txtMotherName;
        private Label txtFatherName;
        private Label txtExpiredDate;
        private Label txtCharacter;
        private Label txtAddress;
        private Label txtHometown;
        private GroupBox groupBox2;
        private TextBox txtMRZ;
        private PictureBox picCamera;
        private Label label1;
        private Button btnFaceMatching;
        private Button btnClearForm;
        private CheckBox chkDelteForm;
        private Label lbFaceMatching;
        private Button btnReadQR;
        private TextBox txtDSCert;
        private CheckBox txtFastRead;
        private GroupBox groupBox3;
        private ComboBox cbFaceCameras;
        private Label label7;
        private CheckBox chkAutocapture;
        private NumericUpDown numFaceTimeout;
        private Label label8;
        private Button btnRefreshCamera;
        private NumericUpDown numFaceDurationTime;
        private Label label9;
        private Button btnCompare;
        private CheckBox chkAutoRead;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureIdcardBack;
        private PictureBox picIdcardFront;
        private ComboBox cbReaderTypes;
        private Label label2;
        private Button btnRejectCard;
        private ComboBox cbAntiSpoofing;
        private ComboBox cbProcessStep;
        private CheckBox chkPaused;
        private Label label5;
        private ComboBox cbOcrMode;
        private Button btnTest;
        private Button btnCompareTest;
    }
}