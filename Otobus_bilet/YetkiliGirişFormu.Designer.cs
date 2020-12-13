namespace Otobus_bilet
{
    partial class YetkiliGirişFormu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YetkiliGirişFormu));
            this.lblsunucu = new System.Windows.Forms.Label();
            this.lblparola = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSunucu = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lbldbname = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtdbname = new System.Windows.Forms.TextBox();
            this.txtuserName = new System.Windows.Forms.TextBox();
            this.btnBaglan = new System.Windows.Forms.Button();
            this.lblHataMesajı = new System.Windows.Forms.Label();
            this.btnİptal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblsunucu
            // 
            this.lblsunucu.AutoSize = true;
            this.lblsunucu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblsunucu.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsunucu.ForeColor = System.Drawing.Color.Black;
            this.lblsunucu.Location = new System.Drawing.Point(29, 148);
            this.lblsunucu.Name = "lblsunucu";
            this.lblsunucu.Size = new System.Drawing.Size(131, 23);
            this.lblsunucu.TabIndex = 0;
            this.lblsunucu.Text = "Sunucu Adı :";
            // 
            // lblparola
            // 
            this.lblparola.AutoSize = true;
            this.lblparola.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblparola.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblparola.ForeColor = System.Drawing.Color.Black;
            this.lblparola.Location = new System.Drawing.Point(71, 313);
            this.lblparola.Name = "lblparola";
            this.lblparola.Size = new System.Drawing.Size(89, 23);
            this.lblparola.TabIndex = 1;
            this.lblparola.Text = "Parola : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.AliceBlue;
            this.label1.Font = new System.Drawing.Font("Mistral", 33F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(155, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 65);
            this.label1.TabIndex = 2;
            this.label1.Text = "KULELİ TURİZM";
            // 
            // txtSunucu
            // 
            this.txtSunucu.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSunucu.Location = new System.Drawing.Point(197, 141);
            this.txtSunucu.MaxLength = 11;
            this.txtSunucu.Multiline = true;
            this.txtSunucu.Name = "txtSunucu";
            this.txtSunucu.Size = new System.Drawing.Size(209, 37);
            this.txtSunucu.TabIndex = 0;
            this.txtSunucu.TextChanged += new System.EventHandler(this.txtSunucu_TextChanged);
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(197, 310);
            this.txtPass.MaxLength = 20;
            this.txtPass.Multiline = true;
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(209, 32);
            this.txtPass.TabIndex = 3;
            // 
            // lbldbname
            // 
            this.lbldbname.AutoSize = true;
            this.lbldbname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lbldbname.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldbname.ForeColor = System.Drawing.Color.Black;
            this.lbldbname.Location = new System.Drawing.Point(33, 203);
            this.lbldbname.Name = "lbldbname";
            this.lbldbname.Size = new System.Drawing.Size(127, 23);
            this.lbldbname.TabIndex = 5;
            this.lbldbname.Text = "Veritabanı : ";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblUser.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.Black;
            this.lblUser.Location = new System.Drawing.Point(19, 261);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(141, 23);
            this.lblUser.TabIndex = 5;
            this.lblUser.Text = "Kullanıcı Adı :";
            // 
            // txtdbname
            // 
            this.txtdbname.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtdbname.Location = new System.Drawing.Point(197, 196);
            this.txtdbname.Name = "txtdbname";
            this.txtdbname.Size = new System.Drawing.Size(209, 34);
            this.txtdbname.TabIndex = 1;
            // 
            // txtuserName
            // 
            this.txtuserName.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtuserName.Location = new System.Drawing.Point(197, 254);
            this.txtuserName.Name = "txtuserName";
            this.txtuserName.Size = new System.Drawing.Size(209, 34);
            this.txtuserName.TabIndex = 2;
            // 
            // btnBaglan
            // 
            this.btnBaglan.BackColor = System.Drawing.Color.Yellow;
            this.btnBaglan.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBaglan.Location = new System.Drawing.Point(300, 378);
            this.btnBaglan.Name = "btnBaglan";
            this.btnBaglan.Size = new System.Drawing.Size(106, 36);
            this.btnBaglan.TabIndex = 4;
            this.btnBaglan.Text = "BAĞLAN";
            this.btnBaglan.UseVisualStyleBackColor = false;
            this.btnBaglan.Click += new System.EventHandler(this.btnBaglan_Click);
            // 
            // lblHataMesajı
            // 
            this.lblHataMesajı.AutoSize = true;
            this.lblHataMesajı.Location = new System.Drawing.Point(23, 380);
            this.lblHataMesajı.Name = "lblHataMesajı";
            this.lblHataMesajı.Size = new System.Drawing.Size(0, 17);
            this.lblHataMesajı.TabIndex = 8;
            // 
            // btnİptal
            // 
            this.btnİptal.BackColor = System.Drawing.Color.OrangeRed;
            this.btnİptal.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnİptal.ForeColor = System.Drawing.Color.Black;
            this.btnİptal.Location = new System.Drawing.Point(197, 378);
            this.btnİptal.Name = "btnİptal";
            this.btnİptal.Size = new System.Drawing.Size(86, 36);
            this.btnİptal.TabIndex = 10;
            this.btnİptal.Text = "İPTAL";
            this.btnİptal.UseVisualStyleBackColor = false;
            this.btnİptal.Click += new System.EventHandler(this.btnİptal_Click);
            // 
            // YetkiliGirişFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(670, 432);
            this.Controls.Add(this.btnİptal);
            this.Controls.Add(this.lblHataMesajı);
            this.Controls.Add(this.btnBaglan);
            this.Controls.Add(this.txtuserName);
            this.Controls.Add(this.txtdbname);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lbldbname);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtSunucu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblparola);
            this.Controls.Add(this.lblsunucu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "YetkiliGirişFormu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yönetici Giriş Ekranı";
            this.Load += new System.EventHandler(this.YetkiliGirişFormu_Load);
            this.Shown += new System.EventHandler(this.YetkiliGirişFormu_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblsunucu;
        private System.Windows.Forms.Label lblparola;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSunucu;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lbldbname;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtdbname;
        private System.Windows.Forms.TextBox txtuserName;
        private System.Windows.Forms.Button btnBaglan;
        private System.Windows.Forms.Label lblHataMesajı;
        private System.Windows.Forms.Button btnİptal;
    }
}