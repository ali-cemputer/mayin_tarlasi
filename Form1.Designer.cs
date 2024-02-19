
namespace Ders_6_Mayın_Tarlası
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnuret = new System.Windows.Forms.Button();
            this.lblskor = new System.Windows.Forms.Label();
            this.lblmayın = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(554, 426);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnuret
            // 
            this.btnuret.Location = new System.Drawing.Point(572, 12);
            this.btnuret.Name = "btnuret";
            this.btnuret.Size = new System.Drawing.Size(103, 110);
            this.btnuret.TabIndex = 1;
            this.btnuret.Text = "ÜRET";
            this.btnuret.UseVisualStyleBackColor = true;
            this.btnuret.Click += new System.EventHandler(this.btnuret_Click);
            // 
            // lblskor
            // 
            this.lblskor.AutoSize = true;
            this.lblskor.Location = new System.Drawing.Point(580, 143);
            this.lblskor.Name = "lblskor";
            this.lblskor.Size = new System.Drawing.Size(37, 17);
            this.lblskor.TabIndex = 2;
            this.lblskor.Text = "Skor";
            // 
            // lblmayın
            // 
            this.lblmayın.AutoSize = true;
            this.lblmayın.Location = new System.Drawing.Point(628, 185);
            this.lblmayın.Name = "lblmayın";
            this.lblmayın.Size = new System.Drawing.Size(16, 17);
            this.lblmayın.TabIndex = 3;
            this.lblmayın.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(572, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mayın";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblmayın);
            this.Controls.Add(this.lblskor);
            this.Controls.Add(this.btnuret);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnuret;
        private System.Windows.Forms.Label lblskor;
        private System.Windows.Forms.Label lblmayın;
        private System.Windows.Forms.Label label1;
    }
}

