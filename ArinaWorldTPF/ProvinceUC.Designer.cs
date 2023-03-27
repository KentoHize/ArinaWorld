namespace ArinaWorldTPF
{
    partial class ProvinceUC
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            lblName = new Label();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(35, 74);
            lblName.Name = "lblName";
            lblName.Size = new Size(15, 19);
            lblName.TabIndex = 0;
            lblName.Text = "-";
            // 
            // ProvinceUC
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblName);
            Name = "ProvinceUC";
            Size = new Size(90, 105);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
    }
}
