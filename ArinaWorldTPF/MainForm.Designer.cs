namespace ArinaWorldTPF
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            puc1 = new ProvinceUC();
            menuStrip1 = new MenuStrip();
            tsmAbout = new ToolStripMenuItem();
            tsmRun1 = new ToolStripMenuItem();
            tsmTest = new ToolStripMenuItem();
            tsmLoadData = new ToolStripMenuItem();
            pnlAreaMap = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // puc1
            // 
            puc1.Location = new Point(33, 52);
            puc1.Name = "puc1";
            puc1.Province = null;
            puc1.Size = new Size(112, 131);
            puc1.TabIndex = 0;
            puc1.Load += puc1_Load;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tsmAbout, tsmTest });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1184, 27);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // tsmAbout
            // 
            tsmAbout.DropDownItems.AddRange(new ToolStripItem[] { tsmRun1 });
            tsmAbout.Name = "tsmAbout";
            tsmAbout.Size = new Size(53, 23);
            tsmAbout.Text = "關於";
            // 
            // tsmRun1
            // 
            tsmRun1.Name = "tsmRun1";
            tsmRun1.Size = new Size(152, 26);
            tsmRun1.Text = "產生檔案";
            tsmRun1.Click += tsmRun1_Click;
            // 
            // tsmTest
            // 
            tsmTest.DropDownItems.AddRange(new ToolStripItem[] { tsmLoadData });
            tsmTest.Name = "tsmTest";
            tsmTest.Size = new Size(53, 23);
            tsmTest.Text = "測試";
            // 
            // tsmLoadData
            // 
            tsmLoadData.Name = "tsmLoadData";
            tsmLoadData.Size = new Size(152, 26);
            tsmLoadData.Text = "載入資料";
            tsmLoadData.Click += tsmLoadData_Click;
            // 
            // pnlAreaMap
            // 
            pnlAreaMap.AutoScroll = true;
            pnlAreaMap.Location = new Point(12, 43);
            pnlAreaMap.Name = "pnlAreaMap";
            pnlAreaMap.Size = new Size(1046, 810);
            pnlAreaMap.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 865);
            Controls.Add(pnlAreaMap);
            Controls.Add(puc1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProvinceUC puc1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem tsmAbout;
        private ToolStripMenuItem tsmRun1;
        private ToolStripMenuItem tsmTest;
        private ToolStripMenuItem tsmLoadData;
        private Panel pnlAreaMap;
    }
}