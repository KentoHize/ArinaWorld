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
            txtMapName = new TextBox();
            txtWidth = new TextBox();
            txtHeight = new TextBox();
            SuspendLayout();
            // 
            // btnOK
            // 
            btnOK.Location = new Point(101, 124);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(144, 51);
            btnOK.TabIndex = 0;
            btnOK.Text = "AWE_BTN_OK";
            btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(318, 124);
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
            lblHeight.Location = new Point(328, 74);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new Size(134, 19);
            lblHeight.TabIndex = 3;
            lblHeight.Text = "AWE_LBL_HEIGHT";
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
            // txtMapName
            // 
            txtMapName.Location = new Point(242, 29);
            txtMapName.Name = "txtMapName";
            txtMapName.Size = new Size(327, 27);
            txtMapName.TabIndex = 5;
            // 
            // txtWidth
            // 
            txtWidth.Location = new Point(211, 71);
            txtWidth.Name = "txtWidth";
            txtWidth.Size = new Size(88, 27);
            txtWidth.TabIndex = 6;
            // 
            // txtHeight
            // 
            txtHeight.Location = new Point(481, 71);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(88, 27);
            txtHeight.TabIndex = 7;
            // 
            // NewMapForm
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(604, 201);
            Controls.Add(txtHeight);
            Controls.Add(txtWidth);
            Controls.Add(txtMapName);
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
        private TextBox txtMapName;
        private TextBox txtWidth;
        private TextBox txtHeight;
    }
}