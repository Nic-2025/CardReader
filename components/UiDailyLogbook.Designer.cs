namespace IdCard.Hanel_obj.components
{
    partial class UiDailyLogbook
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
            cbStatus = new ComboBox();
            lbDate = new Label();
            SuspendLayout();
            // 
            // _lbTitle
            // 
            _lbTitle.AutoSize = true;
            _lbTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            _lbTitle.Location = new Point(26, 13);
            _lbTitle.Name = "_lbTitle";
            _lbTitle.Size = new Size(294, 54);
            _lbTitle.TabIndex = 0;
            _lbTitle.Text = "Daily Logbook";
            // 
            // uiioLogTable1
            // 
            uiioLogTable1.From = null;
            uiioLogTable1.Limit = 10;
            uiioLogTable1.Location = new Point(26, 187);
            uiioLogTable1.Name = "uiioLogTable1";
            uiioLogTable1.Size = new Size(1505, 774);
            uiioLogTable1.Status = null;
            uiioLogTable1.TabIndex = 1;
            uiioLogTable1.To = null;
            // 
            // cbStatus
            // 
            cbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStatus.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbStatus.FormattingEnabled = true;
            cbStatus.Items.AddRange(new object[] { "None", "Signed In", "Signed Out" });
            cbStatus.Location = new Point(26, 110);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(182, 46);
            cbStatus.TabIndex = 2;
            cbStatus.SelectedIndexChanged += CbStatus_SelectedIndexChanged;
            // 
            // lbDate
            // 
            lbDate.AutoSize = true;
            lbDate.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbDate.Location = new Point(1236, 102);
            lbDate.Name = "lbDate";
            lbDate.Size = new Size(102, 54);
            lbDate.TabIndex = 4;
            lbDate.Text = "time";
            // 
            // UiDailyLogbook
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lbDate);
            Controls.Add(cbStatus);
            Controls.Add(uiioLogTable1);
            Controls.Add(_lbTitle);
            Name = "UiDailyLogbook";
            Size = new Size(1579, 989);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label _lbTitle;
        private common.UiIOLogTable uiioLogTable1;
        private ComboBox cbStatus;
        private Label lbDate;
    }
}
