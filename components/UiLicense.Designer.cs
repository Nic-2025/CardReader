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
            _lbLicenseMessage = new Label();
            btnActive = new Button();
            panel1 = new Panel();
            horizo = new Panel();
            _lbTitle = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // _lbLicenseMessage
            // 
            _lbLicenseMessage.AutoSize = true;
            _lbLicenseMessage.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            _lbLicenseMessage.Location = new Point(3, 47);
            _lbLicenseMessage.Name = "_lbLicenseMessage";
            _lbLicenseMessage.Size = new Size(45, 19);
            _lbLicenseMessage.TabIndex = 1;
            _lbLicenseMessage.Text = "label1";
            // 
            // btnActive
            // 
            btnActive.BackColor = Color.SteelBlue;
            btnActive.FlatAppearance.BorderSize = 0;
            btnActive.FlatStyle = FlatStyle.Flat;
            btnActive.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnActive.ForeColor = Color.White;
            btnActive.Location = new Point(32, 160);
            btnActive.Name = "btnActive";
            btnActive.Size = new Size(294, 38);
            btnActive.TabIndex = 2;
            btnActive.Text = "Kích hoạt mới";
            btnActive.UseVisualStyleBackColor = false;
            btnActive.Click += BtnActive_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(horizo);
            panel1.Controls.Add(_lbLicenseMessage);
            panel1.Controls.Add(_lbTitle);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(32, 32);
            panel1.Name = "panel1";
            panel1.Size = new Size(1130, 104);
            panel1.TabIndex = 6;
            // 
            // horizo
            // 
            horizo.BackColor = Color.FromArgb(20, 0, 0, 0);
            horizo.Dock = DockStyle.Bottom;
            horizo.Location = new Point(0, 102);
            horizo.Name = "horizo";
            horizo.Size = new Size(1130, 2);
            horizo.TabIndex = 4;
            // 
            // _lbTitle
            // 
            _lbTitle.AutoSize = true;
            _lbTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            _lbTitle.Location = new Point(0, 0);
            _lbTitle.Margin = new Padding(2, 0, 2, 0);
            _lbTitle.Name = "_lbTitle";
            _lbTitle.Size = new Size(110, 37);
            _lbTitle.TabIndex = 0;
            _lbTitle.Text = "License";
            // 
            // UiLicense
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(btnActive);
            Margin = new Padding(2);
            Name = "UiLicense";
            Padding = new Padding(32);
            Size = new Size(1194, 611);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label _lbLicenseMessage;
        private Button btnActive;
        private Panel panel1;
        private Panel horizo;
        private Label _lbTitle;
    }
}
