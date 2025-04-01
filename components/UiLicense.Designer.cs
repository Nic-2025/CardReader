namespace IdCard.Hanel_obj.components
{
    partial class UiLicense
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
            _lbLicenseMessage = new Label();
            btnActive = new Button();
            SuspendLayout();
            // 
            // _lbTitle
            // 
            _lbTitle.AutoSize = true;
            _lbTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            _lbTitle.Location = new Point(25, 0);
            _lbTitle.Margin = new Padding(2, 0, 2, 0);
            _lbTitle.Name = "_lbTitle";
            _lbTitle.Size = new Size(110, 37);
            _lbTitle.TabIndex = 0;
            _lbTitle.Text = "License";
            // 
            // _lbLicenseMessage
            // 
            _lbLicenseMessage.AutoSize = true;
            _lbLicenseMessage.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            _lbLicenseMessage.Location = new Point(25, 54);
            _lbLicenseMessage.Name = "_lbLicenseMessage";
            _lbLicenseMessage.Size = new Size(63, 25);
            _lbLicenseMessage.TabIndex = 1;
            _lbLicenseMessage.Text = "label1";
            // 
            // btnActive
            // 
            btnActive.BackColor = SystemColors.ActiveCaption;
            btnActive.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnActive.Location = new Point(25, 140);
            btnActive.Name = "btnActive";
            btnActive.Size = new Size(294, 38);
            btnActive.TabIndex = 2;
            btnActive.Text = "Kích hoạt mới";
            btnActive.UseVisualStyleBackColor = false;
            btnActive.Click += BtnActive_Click_1;
            // 
            // UiLicense
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnActive);
            Controls.Add(_lbLicenseMessage);
            Controls.Add(_lbTitle);
            Margin = new Padding(2);
            Name = "UiLicense";
            Size = new Size(1194, 611);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label _lbTitle;
        private Label _lbLicenseMessage;
        private Button btnActive;
    }
}
