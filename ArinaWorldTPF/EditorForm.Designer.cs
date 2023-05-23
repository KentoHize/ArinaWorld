namespace ArinaWorldTPF
{
    partial class EditorForm
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

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditorForm));
            menuStrip = new MenuStrip();
            tmiFile = new ToolStripMenuItem();
            tmiNewMap = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator5 = new ToolStripSeparator();
            tmiQuit = new ToolStripMenuItem();
            tmiTest = new ToolStripMenuItem();
            tmiProducePangea = new ToolStripMenuItem();
            tmiTool = new ToolStripMenuItem();
            tmiZH_TW = new ToolStripMenuItem();
            tmiEN_US = new ToolStripMenuItem();
            tmiHelp = new ToolStripMenuItem();
            tmiAbout = new ToolStripMenuItem();
            statusStrip = new StatusStrip();
            toolStripStatusLabel = new ToolStripStatusLabel();
            toolTip = new ToolTip(components);
            saveFileDialog = new SaveFileDialog();
            openFileDialog = new OpenFileDialog();
            tmiDrawPicture = new ToolStripMenuItem();
            menuStrip.SuspendLayout();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { tmiFile, tmiTest, tmiTool, tmiHelp });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(9, 3, 0, 3);
            menuStrip.Size = new Size(1902, 30);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "MenuStrip";
            // 
            // tmiFile
            // 
            tmiFile.DropDownItems.AddRange(new ToolStripItem[] { tmiNewMap, openToolStripMenuItem, toolStripSeparator3, saveToolStripMenuItem, saveAsToolStripMenuItem, toolStripSeparator5, tmiQuit });
            tmiFile.ImageTransparentColor = SystemColors.ActiveBorder;
            tmiFile.Name = "tmiFile";
            tmiFile.Size = new Size(124, 24);
            tmiFile.Text = "AWE_TMI_FILE";
            // 
            // tmiNewMap
            // 
            tmiNewMap.Image = (Image)resources.GetObject("tmiNewMap.Image");
            tmiNewMap.ImageTransparentColor = Color.Black;
            tmiNewMap.Name = "tmiNewMap";
            tmiNewMap.ShortcutKeys = Keys.Control | Keys.N;
            tmiNewMap.Size = new Size(297, 26);
            tmiNewMap.Text = "AWE_TMI_NEW_MAP";
            tmiNewMap.Click += tmiNewMap_Click;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Image = (Image)resources.GetObject("openToolStripMenuItem.Image");
            openToolStripMenuItem.ImageTransparentColor = Color.Black;
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            openToolStripMenuItem.Size = new Size(297, 26);
            openToolStripMenuItem.Text = "開啟舊檔(&O)";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(294, 6);
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Image = (Image)resources.GetObject("saveToolStripMenuItem.Image");
            saveToolStripMenuItem.ImageTransparentColor = Color.Black;
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveToolStripMenuItem.Size = new Size(297, 26);
            saveToolStripMenuItem.Text = "儲存檔案(&S)";
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size(297, 26);
            saveAsToolStripMenuItem.Text = "另存新檔(&A)";
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(294, 6);
            // 
            // tmiQuit
            // 
            tmiQuit.Name = "tmiQuit";
            tmiQuit.Size = new Size(297, 26);
            tmiQuit.Text = "AWE_TMI_QUIT";
            tmiQuit.Click += tmiQuit_Click;
            // 
            // tmiTest
            // 
            tmiTest.DropDownItems.AddRange(new ToolStripItem[] { tmiProducePangea, tmiDrawPicture });
            tmiTest.Name = "tmiTest";
            tmiTest.Size = new Size(129, 24);
            tmiTest.Text = "AWE_TMI_TEST";
            // 
            // tmiProducePangea
            // 
            tmiProducePangea.Name = "tmiProducePangea";
            tmiProducePangea.Size = new Size(224, 26);
            tmiProducePangea.Text = "產生單一大陸";
            tmiProducePangea.Click += tmiProducePangea_Click;
            // 
            // tmiTool
            // 
            tmiTool.DropDownItems.AddRange(new ToolStripItem[] { tmiZH_TW, tmiEN_US });
            tmiTool.Name = "tmiTool";
            tmiTool.Size = new Size(136, 24);
            tmiTool.Text = "AWE_TMI_TOOL";
            // 
            // tmiZH_TW
            // 
            tmiZH_TW.Name = "tmiZH_TW";
            tmiZH_TW.Size = new Size(224, 26);
            tmiZH_TW.Text = "AWE_TMI_ZH_TW";
            tmiZH_TW.Click += tmiZH_TW_Click;
            // 
            // tmiEN_US
            // 
            tmiEN_US.Name = "tmiEN_US";
            tmiEN_US.Size = new Size(224, 26);
            tmiEN_US.Text = "AWE_TMI_EN_US";
            tmiEN_US.Click += tmiEN_US_Click;
            // 
            // tmiHelp
            // 
            tmiHelp.DropDownItems.AddRange(new ToolStripItem[] { tmiAbout });
            tmiHelp.Name = "tmiHelp";
            tmiHelp.Size = new Size(132, 24);
            tmiHelp.Text = "AWE_TMI_HELP";
            // 
            // tmiAbout
            // 
            tmiAbout.Name = "tmiAbout";
            tmiAbout.Size = new Size(224, 26);
            tmiAbout.Text = "AWE_ABOUT_AWE";
            tmiAbout.Click += tmiAbout_Click;
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(20, 20);
            statusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel });
            statusStrip.Location = new Point(0, 1008);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new Padding(2, 0, 21, 0);
            statusStrip.Size = new Size(1902, 25);
            statusStrip.TabIndex = 2;
            statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            toolStripStatusLabel.Name = "toolStripStatusLabel";
            toolStripStatusLabel.Size = new Size(39, 19);
            toolStripStatusLabel.Text = "狀態";
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog1";
            // 
            // tmiDrawPicture
            // 
            tmiDrawPicture.Name = "tmiDrawPicture";
            tmiDrawPicture.Size = new Size(224, 26);
            tmiDrawPicture.Text = "繪製圖片";
            tmiDrawPicture.Click += tmiDrawPicture_Click;
            // 
            // EditorForm
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(statusStrip);
            Controls.Add(menuStrip);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip;
            Margin = new Padding(4);
            Name = "EditorForm";
            Text = "Arina World Editor";
            FormClosing += EditorForm_FormClosing;
            Load += EditorForm_Load;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion


        private MenuStrip menuStrip;
        private StatusStrip statusStrip;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripStatusLabel toolStripStatusLabel;
        private ToolStripMenuItem tmiFile;
        private ToolStripMenuItem tmiNewMap;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripMenuItem tmiQuit;
        private ToolTip toolTip;
        private SaveFileDialog saveFileDialog;
        private OpenFileDialog openFileDialog;
        private ToolStripMenuItem tmiTest;
        private ToolStripMenuItem tmiProducePangea;
        private ToolStripMenuItem tmiHelp;
        private ToolStripMenuItem tmiAbout;
        private ToolStripMenuItem tmiTool;
        private ToolStripMenuItem tmiEN_US;
        private ToolStripMenuItem tmiZH_TW;
        private ToolStripMenuItem tmiDrawPicture;
    }
}



