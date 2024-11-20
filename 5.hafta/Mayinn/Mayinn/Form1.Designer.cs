namespace Mayinn
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_start_restart = new System.Windows.Forms.Button();
            this.lbl_scor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoScrollMargin = new System.Drawing.Size(20, 20);
            this.panel1.AutoScrollMinSize = new System.Drawing.Size(20, 20);
            this.panel1.Location = new System.Drawing.Point(40, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(880, 789);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_start_restart
            // 
            this.btn_start_restart.Location = new System.Drawing.Point(51, 12);
            this.btn_start_restart.Name = "btn_start_restart";
            this.btn_start_restart.Size = new System.Drawing.Size(170, 35);
            this.btn_start_restart.TabIndex = 1;
            this.btn_start_restart.Text = "Başlat/ Tekrar Başlat";
            this.btn_start_restart.UseVisualStyleBackColor = true;
            this.btn_start_restart.Click += new System.EventHandler(this.btn_start_restart_Click1);
            // 
            // lbl_scor
            // 
            this.lbl_scor.AutoSize = true;
            this.lbl_scor.Location = new System.Drawing.Point(554, 21);
            this.lbl_scor.Name = "lbl_scor";
            this.lbl_scor.Size = new System.Drawing.Size(55, 17);
            this.lbl_scor.TabIndex = 2;
            this.lbl_scor.Text = "SKOR :";
            this.lbl_scor.Click += new System.EventHandler(this.lbl_scor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 854);
            this.Controls.Add(this.lbl_scor);
            this.Controls.Add(this.btn_start_restart);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_start_restart;
        private System.Windows.Forms.Label lbl_scor;
    }
}

