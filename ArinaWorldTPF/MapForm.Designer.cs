namespace ArinaWorldTPF
{
    partial class MapForm
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
            pibMain = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pibMain).BeginInit();
            SuspendLayout();
            // 
            // pibMain
            // 
            pibMain.Dock = DockStyle.Fill;
            pibMain.Location = new Point(0, 0);
            pibMain.Name = "pibMain";
            pibMain.Size = new Size(721, 560);
            pibMain.TabIndex = 0;
            pibMain.TabStop = false;
            pibMain.Paint += pibMain_Paint;
            pibMain.MouseMove += pibMain_MouseMove;
            pibMain.MouseUp += pibMain_MouseUp;
            // 
            // MapForm
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(721, 560);
            Controls.Add(pibMain);
            DoubleBuffered = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MapForm";
            Text = "MapForm";
            WindowState = FormWindowState.Maximized;
            Load += MapForm_Load;
            Paint += MapForm_Paint;
            KeyPress += MapForm_KeyPress;
            ((System.ComponentModel.ISupportInitialize)pibMain).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pibMain;
    }
}