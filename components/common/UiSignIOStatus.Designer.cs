namespace IdCard.Hanel_obj.forms
{
    partial class UiSignIOStatus
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
            lbStatus = new Label();
            SuspendLayout();
            // 
            // lbStatus
            // 
            lbStatus.AutoSize = true;
            lbStatus.Dock = DockStyle.Fill;
            lbStatus.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbStatus.Location = new Point(0, 0);
            lbStatus.Name = "lbStatus";
            lbStatus.Size = new Size(91, 38);
            lbStatus.TabIndex = 0;
            lbStatus.Text = "label1";
            // 
            // UiSignIOStatus
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lbStatus);
            Name = "UiSignIOStatus";
            Size = new Size(209, 48);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbStatus;
    }
}
