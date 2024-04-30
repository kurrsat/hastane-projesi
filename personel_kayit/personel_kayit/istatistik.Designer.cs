namespace personel_kayit
{
    partial class istatistik
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbltoplam = new System.Windows.Forms.Label();
            this.lblevli = new System.Windows.Forms.Label();
            this.lblmaaş = new System.Windows.Forms.Label();
            this.lblortalama = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "toplam personel sayısı ; ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "evli personel sayısı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "toplam maaş:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "ortalama maaş";
            // 
            // lbltoplam
            // 
            this.lbltoplam.AutoSize = true;
            this.lbltoplam.Location = new System.Drawing.Point(219, 23);
            this.lbltoplam.Name = "lbltoplam";
            this.lbltoplam.Size = new System.Drawing.Size(14, 16);
            this.lbltoplam.TabIndex = 4;
            this.lbltoplam.Text = "0";
            this.lbltoplam.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblevli
            // 
            this.lblevli.AutoSize = true;
            this.lblevli.Location = new System.Drawing.Point(219, 55);
            this.lblevli.Name = "lblevli";
            this.lblevli.Size = new System.Drawing.Size(14, 16);
            this.lblevli.TabIndex = 5;
            this.lblevli.Text = "0";
            // 
            // lblmaaş
            // 
            this.lblmaaş.AutoSize = true;
            this.lblmaaş.Location = new System.Drawing.Point(165, 103);
            this.lblmaaş.Name = "lblmaaş";
            this.lblmaaş.Size = new System.Drawing.Size(14, 16);
            this.lblmaaş.TabIndex = 6;
            this.lblmaaş.Text = "0";
            // 
            // lblortalama
            // 
            this.lblortalama.AutoSize = true;
            this.lblortalama.Location = new System.Drawing.Point(156, 150);
            this.lblortalama.Name = "lblortalama";
            this.lblortalama.Size = new System.Drawing.Size(14, 16);
            this.lblortalama.TabIndex = 7;
            this.lblortalama.Text = "0";
            // 
            // istatistik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 294);
            this.Controls.Add(this.lblortalama);
            this.Controls.Add(this.lblmaaş);
            this.Controls.Add(this.lblevli);
            this.Controls.Add(this.lbltoplam);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "istatistik";
            this.Text = "istatistik";
            this.Load += new System.EventHandler(this.istatistik_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbltoplam;
        private System.Windows.Forms.Label lblevli;
        private System.Windows.Forms.Label lblmaaş;
        private System.Windows.Forms.Label lblortalama;
    }
}