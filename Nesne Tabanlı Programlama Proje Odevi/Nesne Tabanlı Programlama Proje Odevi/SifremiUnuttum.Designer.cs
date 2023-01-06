namespace Nesne_Tabanlı_Programlama_Proje_Odevi
{
    partial class SifremiUnuttum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SifremiUnuttum));
            this.btnGonder = new System.Windows.Forms.Button();
            this.txtEskiPosta = new System.Windows.Forms.TextBox();
            this.btnGeri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGonder
            // 
            this.btnGonder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnGonder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnGonder.FlatAppearance.BorderSize = 0;
            this.btnGonder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGonder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGonder.Location = new System.Drawing.Point(269, 438);
            this.btnGonder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(243, 47);
            this.btnGonder.TabIndex = 1;
            this.btnGonder.Text = "Gönder";
            this.btnGonder.UseVisualStyleBackColor = false;
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // txtEskiPosta
            // 
            this.txtEskiPosta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.txtEskiPosta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEskiPosta.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEskiPosta.ForeColor = System.Drawing.SystemColors.Window;
            this.txtEskiPosta.Location = new System.Drawing.Point(168, 338);
            this.txtEskiPosta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEskiPosta.Multiline = true;
            this.txtEskiPosta.Name = "txtEskiPosta";
            this.txtEskiPosta.Size = new System.Drawing.Size(459, 42);
            this.txtEskiPosta.TabIndex = 0;
            this.txtEskiPosta.TextChanged += new System.EventHandler(this.txtEskiPosta_TextChanged);
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
            // SifremiUnuttum
            // 
            this.AcceptButton = this.btnGonder;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1280, 665);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.txtEskiPosta);
            this.Controls.Add(this.btnGonder);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "SifremiUnuttum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SifremiUnuttum";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SifremiUnuttum_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGonder;
        private System.Windows.Forms.TextBox txtEskiPosta;
        private System.Windows.Forms.Button btnGeri;
    }
}