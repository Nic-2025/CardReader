namespace IdCard.Hanel_obj.components.forms
{
    partial class DialogLicense
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
            lbActive = new Label();
            txtActive = new TextBox();
            btnActive = new Button();
            SuspendLayout();
            // 
            // lbActive
            // 
            lbActive.AutoSize = true;
            lbActive.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbActive.Location = new Point(31, 73);
            lbActive.Name = "lbActive";
            lbActive.Size = new Size(121, 25);
            lbActive.TabIndex = 0;
            lbActive.Text = "Mã kích hoạt";
            // 
            // txtActive
            // 
            txtActive.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtActive.Location = new Point(31, 117);
            txtActive.Name = "txtActive";
            txtActive.Size = new Size(523, 33);
            txtActive.TabIndex = 1;
            // 
            // btnActive
            // 
            btnActive.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnActive.Location = new Point(425, 199);
            btnActive.Name = "btnActive";
            btnActive.Size = new Size(129, 40);
            btnActive.TabIndex = 2;
            btnActive.Text = "Xác nhận";
            btnActive.UseVisualStyleBackColor = true;
            btnActive.Click += BtnActive_Click;
            // 
            // DialogLicense
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(594, 284);
            Controls.Add(btnActive);
            Controls.Add(txtActive);
            Controls.Add(lbActive);
            Name = "DialogLicense";
            Text = "DialogLicense";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbActive;
        private TextBox txtActive;
        private Button btnActive;
    }
}