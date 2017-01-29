namespace TelefonRehberi
{
    partial class formKulltanim
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
            this.btnEkle = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dgridKullanici = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtboxSIRA = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgridKullanici)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(70, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Şifre :";
            // 
            // txtboxSifre
            // 
            this.txtboxSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtboxSifre.Location = new System.Drawing.Point(135, 56);
            this.txtboxSifre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxSifre.MaxLength = 30;
            this.txtboxSifre.Name = "txtboxSifre";
            this.txtboxSifre.Size = new System.Drawing.Size(148, 26);
            this.txtboxSifre.TabIndex = 10;
            // 
            // label0
            // 
            this.label0.AutoSize = true;
            this.label0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label0.Location = new System.Drawing.Point(11, 17);
            this.label0.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label0.Name = "label0";
            this.label0.Size = new System.Drawing.Size(116, 20);
            this.label0.TabIndex = 11;
            this.label0.Text = "Kullanıcı Adı :";
            // 
            // txtboxKulAdi
            // 
            this.txtboxKulAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtboxKulAdi.Location = new System.Drawing.Point(135, 14);
            this.txtboxKulAdi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxKulAdi.MaxLength = 30;
            this.txtboxKulAdi.Name = "txtboxKulAdi";
            this.txtboxKulAdi.Size = new System.Drawing.Size(148, 26);
            this.txtboxKulAdi.TabIndex = 9;
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.DarkGray;
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnEkle.Location = new System.Drawing.Point(290, 14);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(94, 68);
            this.btnEkle.TabIndex = 13;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkGray;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(386, 14);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 68);
            this.button2.TabIndex = 14;
            this.button2.Text = "Sil";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgridKullanici
            // 
            this.dgridKullanici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridKullanici.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgridKullanici.Location = new System.Drawing.Point(16, 90);
            this.dgridKullanici.Name = "dgridKullanici";
            this.dgridKullanici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgridKullanici.Size = new System.Drawing.Size(464, 140);
            this.dgridKullanici.TabIndex = 15;
            this.dgridKullanici.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgridKullanici_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column1.FillWeight = 60F;
            this.Column1.HeaderText = "Sıra";
            this.Column1.MinimumWidth = 60;
            this.Column1.Name = "Column1";
            this.Column1.Width = 60;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column2.FillWeight = 180F;
            this.Column2.HeaderText = "Kullanıcı Adı";
            this.Column2.MinimumWidth = 180;
            this.Column2.Name = "Column2";
            this.Column2.Width = 180;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column3.FillWeight = 200F;
            this.Column3.HeaderText = "Şifre";
            this.Column3.MinimumWidth = 180;
            this.Column3.Name = "Column3";
            this.Column3.Width = 180;
            // 
            // txtboxSIRA
            // 
            this.txtboxSIRA.Enabled = false;
            this.txtboxSIRA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtboxSIRA.ForeColor = System.Drawing.Color.DarkRed;
            this.txtboxSIRA.Location = new System.Drawing.Point(16, 56);
            this.txtboxSIRA.Mask = "000000";
            this.txtboxSIRA.Name = "txtboxSIRA";
            this.txtboxSIRA.Size = new System.Drawing.Size(47, 26);
            this.txtboxSIRA.TabIndex = 30;
            this.txtboxSIRA.Visible = false;
            // 
            // formKulltanim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(494, 241);
            this.Controls.Add(this.txtboxSIRA);
            this.Controls.Add(this.dgridKullanici);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtboxSifre);
            this.Controls.Add(this.label0);
            this.Controls.Add(this.txtboxKulAdi);
            this.Name = "formKulltanim";
            this.Text = "Kullanıcı Kayıt";
            this.Load += new System.EventHandler(this.formKulltanim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgridKullanici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtboxSifre;
        private System.Windows.Forms.Label label0;
        private System.Windows.Forms.TextBox txtboxKulAdi;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgridKullanici;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.MaskedTextBox txtboxSIRA;
    }
}