namespace IdCard.Hanel_obj.forms
{
    partial class UiVerifiedStatus
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
            lbStatus.BackColor = SystemColors.ActiveCaption;
            lbStatus.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbStatus.ForeColor = SystemColors.MenuHighlight;
            lbStatus.Location = new Point(0, 0);
            lbStatus.Margin = new Padding(2, 0, 2, 0);
            lbStatus.Name = "lbStatus";
            lbStatus.Size = new Size(42, 19);
            lbStatus.TabIndex = 0;
            lbStatus.Text = "None";
            lbStatus.Click += lbStatus_Click;
            // 
            // UiVerifiedStatus
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(lbStatus);
            Margin = new Padding(2, 2, 2, 2);
            Name = "UiVerifiedStatus";
            Size = new Size(131, 21);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbStatus;
    }
}
