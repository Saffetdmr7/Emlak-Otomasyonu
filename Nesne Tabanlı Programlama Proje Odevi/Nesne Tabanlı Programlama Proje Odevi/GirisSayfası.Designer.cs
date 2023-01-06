namespace Nesne_Tabanlı_Programlama_Proje_Odevi
{
    partial class GirisSayfası
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisSayfası));
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.checkPassword = new System.Windows.Forms.CheckBox();
            this.lblPosta = new System.Windows.Forms.Label();
            this.lblsifre = new System.Windows.Forms.Label();
            this.btnSifreUnuttum = new System.Windows.Forms.Button();
            this.btnHesapOlustur = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnCıkıs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPassword.ForeColor = System.Drawing.SystemColors.Window;
            this.txtPassword.Location = new System.Drawing.Point(76, 258);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(337, 26);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.BackColor = System.Drawing.Color.Brown;
            this.btnGirisYap.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGirisYap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGirisYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGirisYap.ForeColor = System.Drawing.SystemColors.Window;
            this.btnGirisYap.Location = new System.Drawing.Point(146, 346);
            this.btnGirisYap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(232, 42);
            this.btnGirisYap.TabIndex = 3;
            this.btnGirisYap.Text = "Giriş Yap";
            this.btnGirisYap.UseVisualStyleBackColor = false;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // checkPassword
            // 
            this.checkPassword.AutoSize = true;
            this.checkPassword.BackColor = System.Drawing.Color.Transparent;
            this.checkPassword.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.checkPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkPassword.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkPassword.Location = new System.Drawing.Point(434, 259);
            this.checkPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkPassword.Name = "checkPassword";
            this.checkPassword.Size = new System.Drawing.Size(114, 24);
            this.checkPassword.TabIndex = 2;
            this.checkPassword.Text = "Sifre Göster";
            this.checkPassword.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkPassword.UseVisualStyleBackColor = false;
            this.checkPassword.CheckedChanged += new System.EventHandler(this.checkPassword_CheckedChanged);
            // 
            // lblPosta
            // 
            this.lblPosta.AutoSize = true;
            this.lblPosta.BackColor = System.Drawing.Color.Transparent;
            this.lblPosta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPosta.ForeColor = System.Drawing.SystemColors.Window;
            this.lblPosta.Location = new System.Drawing.Point(74, 168);
            this.lblPosta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPosta.Name = "lblPosta";
            this.lblPosta.Size = new System.Drawing.Size(126, 20);
            this.lblPosta.TabIndex = 4;
            this.lblPosta.Text = "E-Posta Giriniz : ";
            this.lblPosta.Visible = false;
            // 
            // lblsifre
            // 
            this.lblsifre.AutoSize = true;
            this.lblsifre.BackColor = System.Drawing.Color.Transparent;
            this.lblsifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsifre.ForeColor = System.Drawing.SystemColors.Window;
            this.lblsifre.Location = new System.Drawing.Point(74, 234);
            this.lblsifre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblsifre.Name = "lblsifre";
            this.lblsifre.Size = new System.Drawing.Size(102, 20);
            this.lblsifre.TabIndex = 5;
            this.lblsifre.Text = "Şifre Giriniz : ";
            this.lblsifre.Visible = false;
            // 
            // btnSifreUnuttum
            // 
            this.btnSifreUnuttum.BackColor = System.Drawing.Color.Brown;
            this.btnSifreUnuttum.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSifreUnuttum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSifreUnuttum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSifreUnuttum.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSifreUnuttum.Location = new System.Drawing.Point(78, 435);
            this.btnSifreUnuttum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSifreUnuttum.Name = "btnSifreUnuttum";
            this.btnSifreUnuttum.Size = new System.Drawing.Size(148, 42);
            this.btnSifreUnuttum.TabIndex = 4;
            this.btnSifreUnuttum.Text = "Sifremi Unuttum";
            this.btnSifreUnuttum.UseVisualStyleBackColor = false;
            this.btnSifreUnuttum.Click += new System.EventHandler(this.btnSifreUnuttum_Click);
            // 
            // btnHesapOlustur
            // 
            this.btnHesapOlustur.BackColor = System.Drawing.Color.Brown;
            this.btnHesapOlustur.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnHesapOlustur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHesapOlustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapOlustur.ForeColor = System.Drawing.SystemColors.Window;
            this.btnHesapOlustur.Location = new System.Drawing.Point(278, 435);
            this.btnHesapOlustur.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHesapOlustur.Name = "btnHesapOlustur";
            this.btnHesapOlustur.Size = new System.Drawing.Size(135, 42);
            this.btnHesapOlustur.TabIndex = 5;
            this.btnHesapOlustur.Text = "Hesap Olustur";
            this.btnHesapOlustur.UseVisualStyleBackColor = false;
            this.btnHesapOlustur.Click += new System.EventHandler(this.btnHesapOlustur_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEmail.ForeColor = System.Drawing.SystemColors.Window;
            this.txtEmail.Location = new System.Drawing.Point(76, 200);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(337, 26);
            this.txtEmail.TabIndex = 0;
            this.txtEmail.Enter += new System.EventHandler(this.txtEmail_Enter);
            // 
            // btnCıkıs
            // 
            this.btnCıkıs.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCıkıs.BackgroundImage")));
            this.btnCıkıs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCıkıs.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCıkıs.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnCıkıs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btnCıkıs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnCıkıs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCıkıs.Location = new System.Drawing.Point(554, 9);
            this.btnCıkıs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCıkıs.Name = "btnCıkıs";
            this.btnCıkıs.Size = new System.Drawing.Size(67, 58);
            this.btnCıkıs.TabIndex = 6;
            this.btnCıkıs.UseVisualStyleBackColor = true;
            this.btnCıkıs.Click += new System.EventHandler(this.btnCıkıs_Click);
            // 
            // GirisSayfası
            // 
            this.AcceptButton = this.btnGirisYap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(960, 540);
            this.Controls.Add(this.btnCıkıs);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnHesapOlustur);
            this.Controls.Add(this.btnSifreUnuttum);
            this.Controls.Add(this.lblsifre);
            this.Controls.Add(this.lblPosta);
            this.Controls.Add(this.checkPassword);
            this.Controls.Add(this.btnGirisYap);
            this.Controls.Add(this.txtPassword);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "GirisSayfası";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GirisSayfası_FormClosing);
            this.Load += new System.EventHandler(this.GirisSayfası_Load);
            this.Click += new System.EventHandler(this.GirisSayfası_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnGirisYap;
        private System.Windows.Forms.CheckBox checkPassword;
        private System.Windows.Forms.Label lblPosta;
        private System.Windows.Forms.Label lblsifre;
        private System.Windows.Forms.Button btnSifreUnuttum;
        private System.Windows.Forms.Button btnHesapOlustur;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnCıkıs;
    }
}

