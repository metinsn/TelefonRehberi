using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace TelefonRehberi
{
    public partial class formKulltanim : Form
    {
        public formKulltanim()
        {
            InitializeComponent();
        }
        MusteriKayit m = new MusteriKayit();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtboxKulAdi.Text != "")
            {
                SQLiteConnection baglan = new SQLiteConnection();
                baglan.ConnectionString = ("Data Source=DatabaseSqlite/Musteriler_sqllite.db3;Compress=True;Version=3");
                SQLiteCommand komut = new SQLiteCommand("insert into kullanici (adi,sifre) values(@kuladi,@sifre)", baglan);
                komut.Parameters.AddWithValue("@kuladi", txtboxKulAdi.Text);
                komut.Parameters.AddWithValue("@sifre", txtboxSifre.Text);
                baglan.Open();
                int kayit = komut.ExecuteNonQuery();
                if (kayit > 0)
                {
                    MessageBox.Show("  Kaydedildi");
                    txtboxKulAdi.Text = "";
                    txtboxSifre.Text = "";
                    txtboxSIRA.Text = "";

                }
                else
                {
                    MessageBox.Show("Kaydedildilemedi !!!", "HATA");
                }
                baglan.Cancel();
                gridyenile();
            }





        }
        private void gridyenile()
        {
            SQLiteConnection baglan = new SQLiteConnection();
            baglan.ConnectionString = ("Data Source=DatabaseSqlite/Musteriler_sqllite.db3;Compress=True;Version=3");
            SQLiteCommand komut = new SQLiteCommand("select * from kullanici order by SIRA desc", baglan);
            baglan.Open();
            dgridKullanici.Rows.Clear();
            SQLiteDataReader Dataoku = komut.ExecuteReader();
            while (Dataoku.Read())
            {
                dgridKullanici.Rows.Add(new object[] {
                        Dataoku.GetValue(0),
                        Dataoku.GetValue(1) ,
                        Dataoku.GetValue(2)
                    });
            }
            baglan.Cancel();

        }

        private void formKulltanim_Load(object sender, EventArgs e)
        {
            gridyenile();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtboxSIRA.Text != "")
            {
                SQLiteConnection baglan = new SQLiteConnection();
                baglan.ConnectionString = ("Data Source=DatabaseSqlite/Musteriler_sqllite.db3;Compress=True;Version=3");
                SQLiteCommand komut = new SQLiteCommand("delete from kullanici where SIRA=@SIRA", baglan);
                komut.Parameters.AddWithValue("@SIRA", txtboxSIRA.Text);
                baglan.Open();
                int kayit = komut.ExecuteNonQuery();
                if (kayit > 0)
                {
                    MessageBox.Show("   Silindi");
                }
                else
                {
                    MessageBox.Show("Silinemedi !!!", "HATA");
                }
                baglan.Cancel();
                gridyenile();
                txtboxKulAdi.Text = "";
                txtboxSifre.Text = "";
                txtboxSIRA.Text = "";
            }
            else
            {
                MessageBox.Show("Gridden seçiniz !!!");
            }
        }

        private void dgridKullanici_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < dgridKullanici.RowCount - 1)
            {
                m.ID = Convert.ToInt32(dgridKullanici.CurrentRow.Cells[0].Value);
                m.adi = dgridKullanici.CurrentRow.Cells[1].Value.ToString();
                m.sifre = dgridKullanici.CurrentRow.Cells[2].Value.ToString();

                txtboxSIRA.Text = m.ID.ToString();
                txtboxKulAdi.Text = m.adi;
                txtboxSifre.Text = m.sifre;
            }
        }
    }
}
