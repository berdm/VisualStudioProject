namespace BG_Odev3
{
    partial class frmOdev
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btn2Beksen = new System.Windows.Forms.Button();
            this.btn3Beksen = new System.Windows.Forms.Button();
            this.btnİzoizDusumu = new System.Windows.Forms.Button();
            this.btnOtele = new System.Windows.Forms.Button();
            this.btnDondur = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btn2Beksen
            // 
            this.btn2Beksen.Location = new System.Drawing.Point(31, 45);
            this.btn2Beksen.Name = "btn2Beksen";
            this.btn2Beksen.Size = new System.Drawing.Size(110, 38);
            this.btn2Beksen.TabIndex = 1;
            this.btn2Beksen.Text = "2B eksen Çiz";
            this.btn2Beksen.UseVisualStyleBackColor = true;
            this.btn2Beksen.Click += new System.EventHandler(this.btn2Beksen_Click);
            // 
            // btn3Beksen
            // 
            this.btn3Beksen.Location = new System.Drawing.Point(31, 89);
            this.btn3Beksen.Name = "btn3Beksen";
            this.btn3Beksen.Size = new System.Drawing.Size(110, 39);
            this.btn3Beksen.TabIndex = 2;
            this.btn3Beksen.Text = "3B eksen";
            this.btn3Beksen.UseVisualStyleBackColor = true;
          
            // 
            // btnİzoizDusumu
            // 
            this.btnİzoizDusumu.Location = new System.Drawing.Point(31, 134);
            this.btnİzoizDusumu.Name = "btnİzoizDusumu";
            this.btnİzoizDusumu.Size = new System.Drawing.Size(110, 46);
            this.btnİzoizDusumu.TabIndex = 3;
            this.btnİzoizDusumu.Text = "izomterik İzdüşümü Al";
            this.btnİzoizDusumu.UseVisualStyleBackColor = true;
            this.btnİzoizDusumu.Click += new System.EventHandler(this.btnİzoizDusumu_Click);
            // 
            // btnOtele
            // 
            this.btnOtele.Location = new System.Drawing.Point(31, 186);
            this.btnOtele.Name = "btnOtele";
            this.btnOtele.Size = new System.Drawing.Size(110, 45);
            this.btnOtele.TabIndex = 4;
            this.btnOtele.Text = "Ötele";
            this.btnOtele.UseVisualStyleBackColor = true;
            this.btnOtele.Click += new System.EventHandler(this.btnOtele_Click);
            // 
            // btnDondur
            // 
            this.btnDondur.Location = new System.Drawing.Point(31, 237);
            this.btnDondur.Name = "btnDondur";
            this.btnDondur.Size = new System.Drawing.Size(110, 50);
            this.btnDondur.TabIndex = 5;
            this.btnDondur.Text = "Döndür";
            this.btnDondur.UseVisualStyleBackColor = true;
            this.btnDondur.Click += new System.EventHandler(this.btnDondur_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(31, 293);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(110, 43);
            this.btnTemizle.TabIndex = 6;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmOdev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnDondur);
            this.Controls.Add(this.btnOtele);
            this.Controls.Add(this.btnİzoizDusumu);
            this.Controls.Add(this.btn3Beksen);
            this.Controls.Add(this.btn2Beksen);
            this.Name = "frmOdev";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ödev";
            this.Load += new System.EventHandler(this.frmOdev_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btn2Beksen;
        private System.Windows.Forms.Button btn3Beksen;
        private System.Windows.Forms.Button btnİzoizDusumu;
        private System.Windows.Forms.Button btnOtele;
        private System.Windows.Forms.Button btnDondur;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

