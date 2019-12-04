namespace ImageClassificationByKeras
{
    partial class Main
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
            this.ctlPicture = new System.Windows.Forms.PictureBox();
            this.ctlOpenDialog = new System.Windows.Forms.OpenFileDialog();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnExcute = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ctlPicture)).BeginInit();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctlPicture
            // 
            this.ctlPicture.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctlPicture.Location = new System.Drawing.Point(0, 0);
            this.ctlPicture.Name = "ctlPicture";
            this.ctlPicture.Size = new System.Drawing.Size(624, 380);
            this.ctlPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ctlPicture.TabIndex = 0;
            this.ctlPicture.TabStop = false;
            // 
            // ctlOpenDialog
            // 
            this.ctlOpenDialog.FileName = "openFileDialog1";
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btnExcute);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlButtons.Location = new System.Drawing.Point(0, 380);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(624, 61);
            this.pnlButtons.TabIndex = 1;
            // 
            // btnExcute
            // 
            this.btnExcute.Location = new System.Drawing.Point(276, 26);
            this.btnExcute.Name = "btnExcute";
            this.btnExcute.Size = new System.Drawing.Size(75, 23);
            this.btnExcute.TabIndex = 0;
            this.btnExcute.Text = "Open";
            this.btnExcute.UseVisualStyleBackColor = true;
            this.btnExcute.Click += new System.EventHandler(this.btnExcute_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.ctlPicture);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(640, 480);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.ctlPicture)).EndInit();
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ctlPicture;
        private System.Windows.Forms.OpenFileDialog ctlOpenDialog;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnExcute;
    }
}

