namespace Nesne_Tabanlı_Programlama_Proje_Odevi
{
    partial class MailDogrulama
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MailDogrulama));
            this.txtDogrulamaKodu = new System.Windows.Forms.TextBox();
            this.btnDogrula = new System.Windows.Forms.Button();
            this.dakika = new System.Windows.Forms.Timer(this.components);
            this.saniye = new System.Windows.Forms.Timer(this.components);
            this.lblSüre = new System.Windows.Forms.Label();
            this.progressBarSure = new System.Windows.Forms.ProgressBar();
            this.btnGeri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDogrulamaKodu
            // 
            this.txtDogrulamaKodu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.txtDogrulamaKodu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDogrulamaKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDogrulamaKodu.ForeColor = System.Drawing.SystemColors.Window;
            this.txtDogrulamaKodu.Location = new System.Drawing.Point(289, 439);
            this.txtDogrulamaKodu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDogrulamaKodu.Name = "txtDogrulamaKodu";
            this.txtDogrulamaKodu.Size = new System.Drawing.Size(416, 42);
            this.txtDogrulamaKodu.TabIndex = 0;
            this.txtDogrulamaKodu.TextChanged += new System.EventHandler(this.txtDogrulamaKodu_TextChanged);
            // 
            // btnDogrula
            // 
            this.btnDogrula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnDogrula.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDogrula.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDogrula.FlatAppearance.BorderSize = 0;
            this.btnDogrula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDogrula.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDogrula.Location = new System.Drawing.Point(393, 537);
            this.btnDogrula.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDogrula.Name = "btnDogrula";
            this.btnDogrula.Size = new System.Drawing.Size(236, 54);
            this.btnDogrula.TabIndex = 1;
            this.btnDogrula.Text = "Doğrula";
            this.btnDogrula.UseVisualStyleBackColor = false;
            this.btnDogrula.Click += new System.EventHandler(this.btnDogrula_Click);
            // 
            // dakika
            // 
            this.dakika.Tick += new System.EventHandler(this.dakika_Tick);
            // 
            // saniye
            // 
            this.saniye.Tick += new System.EventHandler(this.saniye_Tick);
            // 
            // lblSüre
            // 
            this.lblSüre.Location = new System.Drawing.Point(423, 209);
            this.lblSüre.Name = "lblSüre";
            this.lblSüre.Size = new System.Drawing.Size(159, 30);
            this.lblSüre.TabIndex = 4;
            this.lblSüre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBarSure
            // 
            this.progressBarSure.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.progressBarSure.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.progressBarSure.Location = new System.Drawing.Point(383, 266);
            this.progressBarSure.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBarSure.Maximum = 180;
            this.progressBarSure.Name = "progressBarSure";
            this.progressBarSure.Size = new System.Drawing.Size(247, 38);
            this.progressBarSure.Step = 0;
            this.progressBarSure.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarSure.TabIndex = 5;
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
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click_1);
            // 
            // MailDogrulama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1280, 665);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.progressBarSure);
            this.Controls.Add(this.lblSüre);
            this.Controls.Add(this.btnDogrula);
            this.Controls.Add(this.txtDogrulamaKodu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MailDogrulama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MailDogrulama_FormClosing);
            this.Load += new System.EventHandler(this.MailDogrulama_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtDogrulamaKodu;
        private System.Windows.Forms.Button btnDogrula;
        private System.Windows.Forms.Timer dakika;
        private System.Windows.Forms.Timer saniye;
        private System.Windows.Forms.Label lblSüre;
        private System.Windows.Forms.ProgressBar progressBarSure;
        private System.Windows.Forms.Button btnGeri;
    }
}