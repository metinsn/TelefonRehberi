namespace TelefonRehberi
{
    partial class Form2
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
            this.txtboxSifre = new System.Windows.Forms.TextBox();
            this.label0 = new System.Windows.Forms.Label();
            this.txtboxKulAdi = new System.Windows.Forms.TextBox();
            this.lblYazı = new System.Windows.Forms.Label();
            this.btnGiris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(67, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Şifre :";
            // 
            // txtboxSifre
            // 
            this.txtboxSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtboxSifre.Location = new System.Drawing.Point(132, 54);
            this.txtboxSifre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxSifre.MaxLength = 30;
            this.txtboxSifre.Name = "txtboxSifre";
            this.txtboxSifre.Size = new System.Drawing.Size(148, 26);
            this.txtboxSifre.TabIndex = 5;
            // 
            // label0
            // 
            this.label0.AutoSize = true;
            this.label0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label0.Location = new System.Drawing.Point(8, 15);
            this.label0.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label0.Name = "label0";
            this.label0.Size = new System.Drawing.Size(116, 20);
            this.label0.TabIndex = 6;
            this.label0.Text = "Kullanıcı Adı :";
            // 
            // txtboxKulAdi
            // 
            this.txtboxKulAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtboxKulAdi.Location = new System.Drawing.Point(132, 12);
            this.txtboxKulAdi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxKulAdi.MaxLength = 30;
            this.txtboxKulAdi.Name = "txtboxKulAdi";
            this.txtboxKulAdi.Size = new System.Drawing.Size(148, 26);
            this.txtboxKulAdi.TabIndex = 4;
            // 
            // lblYazı
            // 
            this.lblYazı.AutoSize = true;
            this.lblYazı.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYazı.ForeColor = System.Drawing.Color.Red;
            this.lblYazı.Location = new System.Drawing.Point(128, 89);
            this.lblYazı.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYazı.Name = "lblYazı";
            this.lblYazı.Size = new System.Drawing.Size(0, 20);
            this.lblYazı.TabIndex = 8;
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.Color.DimGray;
            this.btnGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiris.Location = new System.Drawing.Point(309, 12);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(127, 68);
            this.btnGiris.TabIndex = 9;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(452, 129);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.lblYazı);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtboxSifre);
            this.Controls.Add(this.label0);
            this.Controls.Add(this.txtboxKulAdi);
            this.Name = "Form2";
            this.ShowIcon = false;
            this.Text = "Kullanıcı Girişi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtboxSifre;
        private System.Windows.Forms.Label label0;
        private System.Windows.Forms.TextBox txtboxKulAdi;
        private System.Windows.Forms.Label lblYazı;
        private System.Windows.Forms.Button btnGiris;
    }
}