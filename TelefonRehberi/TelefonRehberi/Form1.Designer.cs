namespace TelefonRehberi
{
    partial class formKayıt
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtboxAdi = new System.Windows.Forms.TextBox();
            this.lblAdi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtboxSoyAdi = new System.Windows.Forms.TextBox();
            this.Telefon = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgrid = new System.Windows.Forms.DataGridView();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.txtboxAdres = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtboxIl = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtboxAcıklama = new System.Windows.Forms.TextBox();
            this.txtboxCepTelefon1 = new System.Windows.Forms.MaskedTextBox();
            this.txtboxCepTelefon2 = new System.Windows.Forms.MaskedTextBox();
            this.txtboxTelefon2 = new System.Windows.Forms.MaskedTextBox();
            this.txtboxTelefon1 = new System.Windows.Forms.MaskedTextBox();
            this.txtboxIlce = new System.Windows.Forms.TextBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtboxId = new System.Windows.Forms.MaskedTextBox();
            this.rbtnArama = new System.Windows.Forms.RadioButton();
            this.rbtnKayıt = new System.Windows.Forms.RadioButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exceleAktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exceldenAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıŞifreTanımlamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtboxAdi
            // 
            this.txtboxAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtboxAdi.Location = new System.Drawing.Point(110, 43);
            this.txtboxAdi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxAdi.MaxLength = 30;
            this.txtboxAdi.Name = "txtboxAdi";
            this.txtboxAdi.Size = new System.Drawing.Size(148, 26);
            this.txtboxAdi.TabIndex = 0;
            this.txtboxAdi.TextChanged += new System.EventHandler(this.txtboxAdi_TextChanged);
            // 
            // lblAdi
            // 
            this.lblAdi.AutoSize = true;
            this.lblAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblAdi.Location = new System.Drawing.Point(11, 46);
            this.lblAdi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdi.Name = "lblAdi";
            this.lblAdi.Size = new System.Drawing.Size(90, 20);
            this.lblAdi.TabIndex = 1;
            this.lblAdi.Text = "Adı          :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(11, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Soyadı    :";
            // 
            // txtboxSoyAdi
            // 
            this.txtboxSoyAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtboxSoyAdi.Location = new System.Drawing.Point(110, 83);
            this.txtboxSoyAdi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxSoyAdi.MaxLength = 30;
            this.txtboxSoyAdi.Name = "txtboxSoyAdi";
            this.txtboxSoyAdi.Size = new System.Drawing.Size(148, 26);
            this.txtboxSoyAdi.TabIndex = 1;
            // 
            // Telefon
            // 
            this.Telefon.AutoSize = true;
            this.Telefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Telefon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Telefon.Location = new System.Drawing.Point(351, 47);
            this.Telefon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Telefon.Name = "Telefon";
            this.Telefon.Size = new System.Drawing.Size(114, 20);
            this.Telefon.TabIndex = 5;
            this.Telefon.Text = "Telefon        :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(351, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Telefon 2     :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(728, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Cep Telefon 2 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(728, 47);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cep Telefon    :";
            // 
            // dgrid
            // 
            this.dgrid.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column11,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.dgrid.Location = new System.Drawing.Point(12, 229);
            this.dgrid.MultiSelect = false;
            this.dgrid.Name = "dgrid";
            this.dgrid.ReadOnly = true;
            this.dgrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrid.Size = new System.Drawing.Size(982, 426);
            this.dgrid.TabIndex = 12;
            this.dgrid.TabStop = false;
            this.dgrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_CellDoubleClick);
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Sıra";
            this.Column11.MinimumWidth = 30;
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Width = 40;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Adı";
            this.Column1.MinimumWidth = 100;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Soyadı";
            this.Column2.MinimumWidth = 100;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 120;
            // 
            // Column3
            // 
            dataGridViewCellStyle2.NullValue = null;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column3.HeaderText = "Telefon";
            this.Column3.MinimumWidth = 80;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 80;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Telefon 2";
            this.Column4.MinimumWidth = 80;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 110;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Cep Tel.";
            this.Column5.MinimumWidth = 100;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Cep Tel. 2";
            this.Column6.MinimumWidth = 100;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 110;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Adres";
            this.Column7.MinimumWidth = 100;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "İl";
            this.Column8.MinimumWidth = 100;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "İlçe";
            this.Column9.MinimumWidth = 100;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Açıklama";
            this.Column10.MinimumWidth = 100;
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(12, 158);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Adres      :";
            // 
            // txtboxAdres
            // 
            this.txtboxAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtboxAdres.Location = new System.Drawing.Point(110, 155);
            this.txtboxAdres.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxAdres.MaxLength = 100;
            this.txtboxAdres.Name = "txtboxAdres";
            this.txtboxAdres.Size = new System.Drawing.Size(526, 26);
            this.txtboxAdres.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(352, 122);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "İlçe              :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label7.Location = new System.Drawing.Point(12, 122);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "İl             :";
            // 
            // txtboxIl
            // 
            this.txtboxIl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtboxIl.Location = new System.Drawing.Point(110, 119);
            this.txtboxIl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxIl.MaxLength = 30;
            this.txtboxIl.Name = "txtboxIl";
            this.txtboxIl.Size = new System.Drawing.Size(148, 26);
            this.txtboxIl.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label8.Location = new System.Drawing.Point(11, 197);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Açıklama :";
            // 
            // txtboxAcıklama
            // 
            this.txtboxAcıklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtboxAcıklama.Location = new System.Drawing.Point(110, 194);
            this.txtboxAcıklama.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxAcıklama.MaxLength = 100;
            this.txtboxAcıklama.Name = "txtboxAcıklama";
            this.txtboxAcıklama.Size = new System.Drawing.Size(526, 26);
            this.txtboxAcıklama.TabIndex = 9;
            // 
            // txtboxCepTelefon1
            // 
            this.txtboxCepTelefon1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtboxCepTelefon1.Location = new System.Drawing.Point(879, 44);
            this.txtboxCepTelefon1.Mask = "0000000000";
            this.txtboxCepTelefon1.Name = "txtboxCepTelefon1";
            this.txtboxCepTelefon1.Size = new System.Drawing.Size(115, 26);
            this.txtboxCepTelefon1.TabIndex = 4;
            this.txtboxCepTelefon1.TextChanged += new System.EventHandler(this.txtboxCepTelefon1_TextChanged);
            // 
            // txtboxCepTelefon2
            // 
            this.txtboxCepTelefon2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtboxCepTelefon2.Location = new System.Drawing.Point(879, 83);
            this.txtboxCepTelefon2.Mask = "0000000000";
            this.txtboxCepTelefon2.Name = "txtboxCepTelefon2";
            this.txtboxCepTelefon2.Size = new System.Drawing.Size(115, 26);
            this.txtboxCepTelefon2.TabIndex = 5;
            // 
            // txtboxTelefon2
            // 
            this.txtboxTelefon2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtboxTelefon2.Location = new System.Drawing.Point(467, 83);
            this.txtboxTelefon2.Mask = "0000000000";
            this.txtboxTelefon2.Name = "txtboxTelefon2";
            this.txtboxTelefon2.Size = new System.Drawing.Size(111, 26);
            this.txtboxTelefon2.TabIndex = 3;
            // 
            // txtboxTelefon1
            // 
            this.txtboxTelefon1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtboxTelefon1.Location = new System.Drawing.Point(468, 43);
            this.txtboxTelefon1.Mask = "0000000000";
            this.txtboxTelefon1.Name = "txtboxTelefon1";
            this.txtboxTelefon1.Size = new System.Drawing.Size(110, 26);
            this.txtboxTelefon1.TabIndex = 2;
            this.txtboxTelefon1.TextChanged += new System.EventHandler(this.txtboxTelefon1_TextChanged);
            // 
            // txtboxIlce
            // 
            this.txtboxIlce.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtboxIlce.Location = new System.Drawing.Point(467, 119);
            this.txtboxIlce.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxIlce.MaxLength = 30;
            this.txtboxIlce.Name = "txtboxIlce";
            this.txtboxIlce.Size = new System.Drawing.Size(169, 26);
            this.txtboxIlce.TabIndex = 7;
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Tomato;
            this.btnSil.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.Color.Black;
            this.btnSil.Location = new System.Drawing.Point(839, 155);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(155, 68);
            this.btnSil.TabIndex = 11;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.DarkRed;
            this.label9.Location = new System.Drawing.Point(847, 125);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 22);
            this.label9.TabIndex = 28;
            this.label9.Text = "SIRA  :";
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.Tomato;
            this.btnKaydet.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.ForeColor = System.Drawing.Color.Black;
            this.btnKaydet.Location = new System.Drawing.Point(678, 155);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(155, 68);
            this.btnKaydet.TabIndex = 10;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtboxId
            // 
            this.txtboxId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtboxId.ForeColor = System.Drawing.Color.DarkRed;
            this.txtboxId.Location = new System.Drawing.Point(921, 122);
            this.txtboxId.Mask = "000000";
            this.txtboxId.Name = "txtboxId";
            this.txtboxId.Size = new System.Drawing.Size(73, 26);
            this.txtboxId.TabIndex = 29;
            // 
            // rbtnArama
            // 
            this.rbtnArama.AutoSize = true;
            this.rbtnArama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbtnArama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.rbtnArama.Location = new System.Drawing.Point(753, 125);
            this.rbtnArama.Name = "rbtnArama";
            this.rbtnArama.Size = new System.Drawing.Size(79, 24);
            this.rbtnArama.TabIndex = 32;
            this.rbtnArama.Text = "Arama";
            this.toolTip1.SetToolTip(this.rbtnArama, "Adı,Telefon,Cep Telefon alanlarında arama yapılır.\r\nBüyük küçük harf duyarlıdır !" +
        "");
            this.rbtnArama.UseVisualStyleBackColor = true;
            // 
            // rbtnKayıt
            // 
            this.rbtnKayıt.AutoSize = true;
            this.rbtnKayıt.Checked = true;
            this.rbtnKayıt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbtnKayıt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.rbtnKayıt.Location = new System.Drawing.Point(681, 125);
            this.rbtnKayıt.Name = "rbtnKayıt";
            this.rbtnKayıt.Size = new System.Drawing.Size(66, 24);
            this.rbtnKayıt.TabIndex = 33;
            this.rbtnKayıt.TabStop = true;
            this.rbtnKayıt.Text = "Kayıt";
            this.rbtnKayıt.UseVisualStyleBackColor = true;
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 250;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.kullanıcıİşlemleriToolStripMenuItem,
            this.hakkındaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1004, 24);
            this.menuStrip1.TabIndex = 34;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exceleAktarToolStripMenuItem,
            this.exceldenAlToolStripMenuItem,
            this.çıkışToolStripMenuItem1});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // exceleAktarToolStripMenuItem
            // 
            this.exceleAktarToolStripMenuItem.Name = "exceleAktarToolStripMenuItem";
            this.exceleAktarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exceleAktarToolStripMenuItem.Text = "Excel\'e aktar";
            this.exceleAktarToolStripMenuItem.Click += new System.EventHandler(this.exceleAktarToolStripMenuItem_Click);
            // 
            // exceldenAlToolStripMenuItem
            // 
            this.exceldenAlToolStripMenuItem.Name = "exceldenAlToolStripMenuItem";
            this.exceldenAlToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exceldenAlToolStripMenuItem.Text = "Excel\'den al";
            this.exceldenAlToolStripMenuItem.Click += new System.EventHandler(this.exceldenAlToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem1
            // 
            this.çıkışToolStripMenuItem1.Name = "çıkışToolStripMenuItem1";
            this.çıkışToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.çıkışToolStripMenuItem1.Text = "Çıkış";
            this.çıkışToolStripMenuItem1.Click += new System.EventHandler(this.çıkışToolStripMenuItem1_Click);
            // 
            // kullanıcıİşlemleriToolStripMenuItem
            // 
            this.kullanıcıİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kullanıcıŞifreTanımlamaToolStripMenuItem});
            this.kullanıcıİşlemleriToolStripMenuItem.Name = "kullanıcıİşlemleriToolStripMenuItem";
            this.kullanıcıİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.kullanıcıİşlemleriToolStripMenuItem.Text = "Kullanıcı İşlemleri";
            // 
            // kullanıcıŞifreTanımlamaToolStripMenuItem
            // 
            this.kullanıcıŞifreTanımlamaToolStripMenuItem.Name = "kullanıcıŞifreTanımlamaToolStripMenuItem";
            this.kullanıcıŞifreTanımlamaToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.kullanıcıŞifreTanımlamaToolStripMenuItem.Text = "Kullanıcı ve Şifre Tanımlama";
            this.kullanıcıŞifreTanımlamaToolStripMenuItem.Click += new System.EventHandler(this.kullanıcıŞifreTanımlamaToolStripMenuItem_Click);
            // 
            // hakkındaToolStripMenuItem
            // 
            this.hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            this.hakkındaToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.hakkındaToolStripMenuItem.Text = "Hakkında";
            this.hakkındaToolStripMenuItem.Click += new System.EventHandler(this.hakkındaToolStripMenuItem_Click);
            // 
            // formKayıt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(1004, 664);
            this.Controls.Add(this.rbtnKayıt);
            this.Controls.Add(this.rbtnArama);
            this.Controls.Add(this.txtboxId);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.txtboxIlce);
            this.Controls.Add(this.txtboxTelefon2);
            this.Controls.Add(this.txtboxTelefon1);
            this.Controls.Add(this.txtboxCepTelefon2);
            this.Controls.Add(this.txtboxCepTelefon1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtboxAcıklama);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtboxIl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtboxAdres);
            this.Controls.Add(this.dgrid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Telefon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtboxSoyAdi);
            this.Controls.Add(this.lblAdi);
            this.Controls.Add(this.txtboxAdi);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(1020, 700);
            this.MinimumSize = new System.Drawing.Size(1020, 700);
            this.Name = "formKayıt";
            this.ShowIcon = false;
            this.Text = "Telefon Rehberi";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgrid)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxAdi;
        private System.Windows.Forms.Label lblAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtboxSoyAdi;
        private System.Windows.Forms.Label Telefon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtboxAdres;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtboxIl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtboxAcıklama;
        private System.Windows.Forms.MaskedTextBox txtboxCepTelefon1;
        private System.Windows.Forms.MaskedTextBox txtboxCepTelefon2;
        private System.Windows.Forms.MaskedTextBox txtboxTelefon2;
        private System.Windows.Forms.MaskedTextBox txtboxTelefon1;
        private System.Windows.Forms.TextBox txtboxIlce;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.MaskedTextBox txtboxId;
        internal System.Windows.Forms.DataGridView dgrid;
        private System.Windows.Forms.RadioButton rbtnArama;
        private System.Windows.Forms.RadioButton rbtnKayıt;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exceleAktarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exceldenAlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıŞifreTanımlamaToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
    }
}

