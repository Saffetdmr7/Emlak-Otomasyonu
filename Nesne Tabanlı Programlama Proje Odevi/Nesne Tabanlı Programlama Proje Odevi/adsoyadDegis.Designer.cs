namespace Nesne_Tabanlı_Programlama_Proje_Odevi
{
    partial class adsoyadDegis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adsoyadDegis));
            this.txtYeniAdSoyad = new System.Windows.Forms.TextBox();
            this.btnOnayla = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtYeniAdSoyad
            // 
            this.txtYeniAdSoyad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.txtYeniAdSoyad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtYeniAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYeniAdSoyad.ForeColor = System.Drawing.SystemColors.Window;
            this.txtYeniAdSoyad.Location = new System.Drawing.Point(273, 388);
            this.txtYeniAdSoyad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtYeniAdSoyad.Name = "txtYeniAdSoyad";
            this.txtYeniAdSoyad.Size = new System.Drawing.Size(484, 42);
            this.txtYeniAdSoyad.TabIndex = 0;
            this.txtYeniAdSoyad.TextChanged += new System.EventHandler(this.txtYeniAdSoyad_TextChanged);
            // 
            // btnOnayla
            // 
            this.btnOnayla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnOnayla.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnOnayla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOnayla.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOnayla.Location = new System.Drawing.Point(401, 492);
            this.btnOnayla.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(229, 57);
            this.btnOnayla.TabIndex = 1;
            this.btnOnayla.Text = "Onayla";
            this.btnOnayla.UseVisualStyleBackColor = false;
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
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
            this.btnGeri.Location = new System.Drawing.Point(15, 14);
            this.btnGeri.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(89, 71);
            this.btnGeri.TabIndex = 2;
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // adsoyadDegis
            // 
            this.AcceptButton = this.btnOnayla;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnGeri;
            this.ClientSize = new System.Drawing.Size(1280, 665);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.txtYeniAdSoyad);
            this.Controls.Add(this.btnOnayla);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "adsoyadDegis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "adsoyadDegis";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.adsoyadDegis_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtYeniAdSoyad;
        private System.Windows.Forms.Button btnOnayla;
        private System.Windows.Forms.Button btnGeri;
    }
}