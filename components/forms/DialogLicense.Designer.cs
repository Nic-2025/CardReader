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
            panel1 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lbActive
            // 
            lbActive.AutoSize = true;
            lbActive.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbActive.Location = new Point(19, 23);
            lbActive.Name = "lbActive";
            lbActive.Size = new Size(89, 19);
            lbActive.TabIndex = 0;
            lbActive.Text = "Mã kích hoạt";
            // 
            // txtActive
            // 
            txtActive.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtActive.Location = new Point(19, 45);
            txtActive.Name = "txtActive";
            txtActive.Size = new Size(507, 33);
            txtActive.TabIndex = 1;
            // 
            // btnActive
            // 
            btnActive.BackColor = Color.SteelBlue;
            btnActive.FlatAppearance.BorderSize = 0;
            btnActive.FlatStyle = FlatStyle.Flat;
            btnActive.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnActive.ForeColor = Color.White;
            btnActive.Location = new Point(397, 98);
            btnActive.Name = "btnActive";
            btnActive.Size = new Size(129, 40);
            btnActive.TabIndex = 2;
            btnActive.Text = "Xác nhận";
            btnActive.UseVisualStyleBackColor = false;
            btnActive.Click += BtnActive_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lbActive);
            panel1.Controls.Add(btnActive);
            panel1.Controls.Add(txtActive);
            panel1.Location = new Point(21, 58);
            panel1.Name = "panel1";
            panel1.Size = new Size(539, 159);
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(18, 19);
            label1.Name = "label1";
            label1.Size = new Size(209, 32);
            label1.TabIndex = 3;
            label1.Text = "Kích hoạt thiết bị";
            // 
            // DialogLicense
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 250, 250);
            ClientSize = new Size(583, 248);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "DialogLicense";
            Text = "DialogLicense";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbActive;
        private TextBox txtActive;
        private Button btnActive;
        private Panel panel1;
        private Label label1;
    }
}