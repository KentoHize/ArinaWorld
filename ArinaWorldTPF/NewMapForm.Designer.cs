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
            components = new System.ComponentModel.Container();
            btnOK = new Button();
            btnCancel = new Button();
            lblWidth = new Label();
            lblHeight = new Label();
            lblMapName = new Label();
            txtMapName = new TextBox();
            txtWidth = new TextBox();
            txtHeight = new TextBox();
            errWidth = new ErrorProvider(components);
            errHeight = new ErrorProvider(components);
            errMapName = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errWidth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errHeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errMapName).BeginInit();
            SuspendLayout();
            // 
            // btnOK
            // 
            btnOK.Enabled = false;
            btnOK.Location = new Point(90, 120);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(143, 51);
            btnOK.TabIndex = 0;
            btnOK.Text = "AWE_BTN_OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(296, 120);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(135, 51);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "AWE_BTN_CANCEL";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblWidth
            // 
            lblWidth.AutoSize = true;
            lblWidth.Location = new Point(30, 64);
            lblWidth.Name = "lblWidth";
            lblWidth.Size = new Size(130, 19);
            lblWidth.TabIndex = 2;
            lblWidth.Text = "AWE_LBL_WIDTH";
            // 
            // lblHeight
            // 
            lblHeight.AutoSize = true;
            lblHeight.Location = new Point(296, 64);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new Size(134, 19);
            lblHeight.TabIndex = 3;
            lblHeight.Text = "AWE_LBL_HEIGHT";
            // 
            // lblMapName
            // 
            lblMapName.AutoSize = true;
            lblMapName.Location = new Point(30, 22);
            lblMapName.Name = "lblMapName";
            lblMapName.Size = new Size(165, 19);
            lblMapName.TabIndex = 4;
            lblMapName.Text = "AWE_LBL_MAP_NAME";
            // 
            // txtMapName
            // 
            txtMapName.Location = new Point(210, 19);
            txtMapName.Name = "txtMapName";
            txtMapName.Size = new Size(326, 27);
            txtMapName.TabIndex = 5;
            txtMapName.TextChanged += txtMapName_TextChanged;
            // 
            // txtWidth
            // 
            txtWidth.Location = new Point(179, 61);
            txtWidth.Name = "txtWidth";
            txtWidth.Size = new Size(87, 27);
            txtWidth.TabIndex = 6;
            txtWidth.TextChanged += txtWidth_TextChanged;
            // 
            // txtHeight
            // 
            txtHeight.Location = new Point(449, 61);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(87, 27);
            txtHeight.TabIndex = 7;
            txtHeight.TextChanged += txtHeight_TextChanged;
            // 
            // errWidth
            // 
            errWidth.ContainerControl = this;
            // 
            // errHeight
            // 
            errHeight.ContainerControl = this;
            // 
            // errMapName
            // 
            errMapName.ContainerControl = this;
            // 
            // NewMapForm
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 201);
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
            StartPosition = FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)errWidth).EndInit();
            ((System.ComponentModel.ISupportInitialize)errHeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)errMapName).EndInit();
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
        private ErrorProvider errWidth;
        private ErrorProvider errHeight;
        private ErrorProvider errMapName;
    }
}