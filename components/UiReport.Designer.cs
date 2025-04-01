namespace IdCard.Hanel_obj.components
{
    partial class UiReport
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
            uiioLogTable1 = new IdCard.Hanel_obj.components.common.UiIOLogTable();
            panel1 = new Panel();
            dateTimePicker1 = new DateTimePicker();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // _lbTitle
            // 
            _lbTitle.AutoSize = true;
            _lbTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            _lbTitle.Location = new Point(46, 15);
            _lbTitle.Name = "_lbTitle";
            _lbTitle.Size = new Size(152, 54);
            _lbTitle.TabIndex = 0;
            _lbTitle.Text = "Report";
            // 
            // uiioLogTable1
            // 
            uiioLogTable1.From = null;
            uiioLogTable1.Limit = 10;
            uiioLogTable1.Location = new Point(46, 175);
            uiioLogTable1.Name = "uiioLogTable1";
            uiioLogTable1.Size = new Size(1682, 744);
            uiioLogTable1.Status = null;
            uiioLogTable1.TabIndex = 1;
            uiioLogTable1.To = null;
            // 
            // panel1
            // 
            panel1.Controls.Add(dateTimePicker1);
            panel1.Location = new Point(46, 72);
            panel1.Name = "panel1";
            panel1.Size = new Size(1663, 81);
            panel1.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(1338, 11);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 45);
            dateTimePicker1.TabIndex = 0;
            dateTimePicker1.ValueChanged += DateTimePicker1_ValueChanged;
            // 
            // UiReport
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(uiioLogTable1);
            Controls.Add(_lbTitle);
            Name = "UiReport";
            Padding = new Padding(24, 0, 24, 0);
            Size = new Size(1859, 1125);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label _lbTitle;
        private common.UiIOLogTable uiioLogTable1;
        private Panel panel1;
        private DateTimePicker dateTimePicker1;
    }
}
