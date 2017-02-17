namespace TelefonRehberi
{
    partial class xlsxAl
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
            this.btnSec = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnAl = new System.Windows.Forms.Button();
            this.txtboxDizin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSec
            // 
            this.btnSec.BackColor = System.Drawing.Color.Tomato;
            this.btnSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnSec.Location = new System.Drawing.Point(12, 9);
            this.btnSec.Name = "btnSec";
            this.btnSec.Size = new System.Drawing.Size(77, 40);
            this.btnSec.TabIndex = 14;
            this.btnSec.Text = "Seç";
            this.btnSec.UseVisualStyleBackColor = false;
            this.btnSec.Click += new System.EventHandler(this.btnSec_Click);
            // 
            // btnAl
            // 
            this.btnAl.BackColor = System.Drawing.Color.Tomato;
            this.btnAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnAl.Location = new System.Drawing.Point(446, 9);
            this.btnAl.Name = "btnAl";
            this.btnAl.Size = new System.Drawing.Size(94, 40);
            this.btnAl.TabIndex = 15;
            this.btnAl.Text = "Aktar";
            this.btnAl.UseVisualStyleBackColor = false;
            this.btnAl.Click += new System.EventHandler(this.btnAl_Click);
            // 
            // txtboxDizin
            // 
            this.txtboxDizin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtboxDizin.Location = new System.Drawing.Point(95, 21);
            this.txtboxDizin.Name = "txtboxDizin";
            this.txtboxDizin.Size = new System.Drawing.Size(345, 22);
            this.txtboxDizin.TabIndex = 16;
            // 
            // xlsxAl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(558, 62);
            this.Controls.Add(this.txtboxDizin);
            this.Controls.Add(this.btnAl);
            this.Controls.Add(this.btnSec);
            this.Name = "xlsxAl";
            this.ShowIcon = false;
            this.Text = "Excel\'den Programa Yükleme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSec;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnAl;
        private System.Windows.Forms.TextBox txtboxDizin;
    }
}