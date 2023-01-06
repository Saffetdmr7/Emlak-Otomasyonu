namespace Nesne_Tabanlı_Programlama_Proje_Odevi
{
    partial class fotoDeğiş
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fotoDeğiş));
            this.btnGeri = new System.Windows.Forms.Button();
            this.btnFotoSeç = new System.Windows.Forms.Button();
            this.pictureBoxSonrakiEv = new System.Windows.Forms.PictureBox();
            this.pictureBoxOncekiEv = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSonrakiEv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOncekiEv)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.Color.Transparent;
            this.btnGeri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGeri.BackgroundImage")));
            this.btnGeri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGeri.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnGeri.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnGeri.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btnGeri.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnGeri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeri.Location = new System.Drawing.Point(12, 11);
            this.btnGeri.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(89, 71);
            this.btnGeri.TabIndex = 1;
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // btnFotoSeç
            // 
            this.btnFotoSeç.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnFotoSeç.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnFotoSeç.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFotoSeç.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFotoSeç.Location = new System.Drawing.Point(504, 478);
            this.btnFotoSeç.Margin = new System.Windows.Forms.Padding(4);
            this.btnFotoSeç.Name = "btnFotoSeç";
            this.btnFotoSeç.Size = new System.Drawing.Size(285, 56);
            this.btnFotoSeç.TabIndex = 0;
            this.btnFotoSeç.Text = "Seç";
            this.btnFotoSeç.UseVisualStyleBackColor = false;
            this.btnFotoSeç.Click += new System.EventHandler(this.btnFotoSeç_Click);
            // 
            // pictureBoxSonrakiEv
            // 
            this.pictureBoxSonrakiEv.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxSonrakiEv.Location = new System.Drawing.Point(742, 116);
            this.pictureBoxSonrakiEv.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxSonrakiEv.Name = "pictureBoxSonrakiEv";
            this.pictureBoxSonrakiEv.Size = new System.Drawing.Size(273, 254);
            this.pictureBoxSonrakiEv.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSonrakiEv.TabIndex = 0;
            this.pictureBoxSonrakiEv.TabStop = false;
            // 
            // pictureBoxOncekiEv
            // 
            this.pictureBoxOncekiEv.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxOncekiEv.Location = new System.Drawing.Point(251, 116);
            this.pictureBoxOncekiEv.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxOncekiEv.Name = "pictureBoxOncekiEv";
            this.pictureBoxOncekiEv.Size = new System.Drawing.Size(275, 254);
            this.pictureBoxOncekiEv.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxOncekiEv.TabIndex = 36;
            this.pictureBoxOncekiEv.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // fotoDeğiş
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1280, 665);
            this.Controls.Add(this.pictureBoxOncekiEv);
            this.Controls.Add(this.btnFotoSeç);
            this.Controls.Add(this.pictureBoxSonrakiEv);
            this.Controls.Add(this.btnGeri);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fotoDeğiş";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fotoDeğiş";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fotoDeğiş_FormClosing);
            this.Load += new System.EventHandler(this.fotoDeğiş_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSonrakiEv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOncekiEv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Button btnFotoSeç;
        private System.Windows.Forms.PictureBox pictureBoxSonrakiEv;
        private System.Windows.Forms.PictureBox pictureBoxOncekiEv;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}