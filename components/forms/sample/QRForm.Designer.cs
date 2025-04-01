namespace IdCard.Hanel
{
    partial class QRForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQRCodeVal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22F);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(109, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(506, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vui lòng đưa thẻ vào đầu đọc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 22F);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(28, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(740, 50);
            this.label2.TabIndex = 0;
            this.label2.Text = "(quay mặt trước có QRCode vào phía trong)";
            // 
            // txtQRCodeVal
            // 
            this.txtQRCodeVal.Location = new System.Drawing.Point(56, 188);
            this.txtQRCodeVal.Multiline = true;
            this.txtQRCodeVal.Name = "txtQRCodeVal";
            this.txtQRCodeVal.ReadOnly = true;
            this.txtQRCodeVal.Size = new System.Drawing.Size(667, 114);
            this.txtQRCodeVal.TabIndex = 1;
            // 
            // QRForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 362);
            this.Controls.Add(this.txtQRCodeVal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "QRForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "QRForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QRForm_FormClosing);
            this.Load += new System.EventHandler(this.QRForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtQRCodeVal;
    }
}