namespace ArinaWorldTPF
{
    partial class NewMapForm
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
            btnOK = new Button();
            btnCancel = new Button();
            lblWidth = new Label();
            lblHeight = new Label();
            lblMapName = new Label();
            SuspendLayout();
            // 
            // btnOK
            // 
            btnOK.Location = new Point(85, 235);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(144, 51);
            btnOK.TabIndex = 0;
            btnOK.Text = "AWE_BTN_OK";
            btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(305, 235);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(144, 51);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "AWE_BTN_CANCEL";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblWidth
            // 
            lblWidth.AutoSize = true;
            lblWidth.Location = new Point(62, 74);
            lblWidth.Name = "lblWidth";
            lblWidth.Size = new Size(130, 19);
            lblWidth.TabIndex = 2;
            lblWidth.Text = "AWE_LBL_WIDTH";
            // 
            // lblHeight
            // 
            lblHeight.AutoSize = true;
            lblHeight.Location = new Point(305, 74);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new Size(130, 19);
            lblHeight.TabIndex = 3;
            lblHeight.Text = "AWE_LBL_WIDTH";
            // 
            // lblMapName
            // 
            lblMapName.AutoSize = true;
            lblMapName.Location = new Point(62, 32);
            lblMapName.Name = "lblMapName";
            lblMapName.Size = new Size(165, 19);
            lblMapName.TabIndex = 4;
            lblMapName.Text = "AWE_LBL_MAP_NAME";
            // 
            // NewMapForm
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(604, 321);
            Controls.Add(lblMapName);
            Controls.Add(lblHeight);
            Controls.Add(lblWidth);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "NewMapForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOK;
        private Button btnCancel;
        private Label lblWidth;
        private Label lblHeight;
        private Label lblMapName;
    }
}