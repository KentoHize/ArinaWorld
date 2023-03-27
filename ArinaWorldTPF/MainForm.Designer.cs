namespace ArinaWorldTPF
{
    partial class Form1
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
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // puc1
            // 
            puc1.Location = new Point(34, 12);
            puc1.Name = "puc1";
            puc1.Province = null;
            puc1.Size = new Size(112, 131);
            puc1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tsmAbout });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // tsmAbout
            // 
            tsmAbout.DropDownItems.AddRange(new ToolStripItem[] { tsmRun1 });
            tsmAbout.Name = "tsmAbout";
            tsmAbout.Size = new Size(53, 24);
            tsmAbout.Text = "關於";
            // 
            // tsmRun1
            // 
            tsmRun1.Name = "tsmRun1";
            tsmRun1.Size = new Size(224, 26);
            tsmRun1.Text = "產生檔案";
            tsmRun1.Click += tsmRun1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(puc1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
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
    }
}