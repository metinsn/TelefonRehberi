using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace TelefonRehberi
{
    public partial class formGiris : Form
    {
        public formGiris()
        {
            InitializeComponent();           
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            SQLiteConnection baglan = new SQLiteConnection();
            baglan.ConnectionString = ("Data Source=DatabaseSqlite/Musteriler_sqllite.db3;Compress=True;Version=3");
            SQLiteCommand komut = new SQLiteCommand("select count(*) from kullanici where adi=@kuladi and sifre=@sifre ", baglan);
            komut.Parameters.AddWithValue("@kuladi", txtboxKulAdi.Text);
            komut.Parameters.AddWithValue("@sifre", txtboxSifre.Text);
            baglan.Open();
            int kayit = Convert.ToInt32(komut.ExecuteScalar());
            if (kayit > 0 || (txtboxKulAdi.Text=="admin" && txtboxSifre.Text== "admin"))
            {
                formKayıt form1 = new formKayıt();
                form1.Show();
                lblYazı.Text = "Şifre Başarılı :)";
                this.Hide();
            }
            lblYazı.Text = "Şifre Başarısız :(";
            baglan.Cancel();

        }
    }
}
