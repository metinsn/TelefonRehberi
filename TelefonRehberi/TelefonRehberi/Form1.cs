using System.Windows.Forms;
using System.Data.SQLite;
using System;

namespace TelefonRehberi

{
    public partial class Form1 : Form
    {

        MusteriKayit m = new MusteriKayit();

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnKaydet_Click(object sender, System.EventArgs e)
        {
            SQLiteConnection baglan = new SQLiteConnection();
            baglan.ConnectionString = ("Data Source=DatabaseSqlite/Musteriler_sqllite.db3;Compress=True;Version=3");
            SQLiteCommand komut = new SQLiteCommand("insert into musteri (adi,soyadi,telefon1,telefon2,ceptel1,ceptel2,adres,il,ilce,aciklama) values(@adi,@soyadi,@telefon1,@telefon2,@ceptel1,@ceptel2,@adres,@il,@ilce,@aciklama)", baglan);
            komut.Parameters.AddWithValue("@adi", txtboxAdi.Text);
            komut.Parameters.AddWithValue("@soyadi", txtboxSoyAdi.Text);
            komut.Parameters.AddWithValue("@telefon1", txtboxTelefon1.Text);
            komut.Parameters.AddWithValue("@telefon2", txtboxTelefon2.Text);
            komut.Parameters.AddWithValue("@ceptel1", txtboxCepTelefon1.Text);
            komut.Parameters.AddWithValue("@ceptel2", txtboxCepTelefon2.Text);
            komut.Parameters.AddWithValue("@adres", txtboxIl.Text);
            komut.Parameters.AddWithValue("@il", txtboxIlce.Text);
            komut.Parameters.AddWithValue("@ilce", txtboxAdres.Text);
            komut.Parameters.AddWithValue("@aciklama", txtboxAcıklama.Text);
            baglan.Open();
            int kayit = komut.ExecuteNonQuery();
            if (kayit>0)
            {
                MessageBox.Show("Kaydedildi");
            }
            else
            {
                MessageBox.Show("Kaydedildilemedi !!!","HATA");
            }
            baglan.Cancel();
            gridyenile();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            gridyenile();            
        }

        private void dgrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            m.ID = Convert.ToInt32(dgrid.CurrentRow.Cells[0].Value);
            m.adi = dgrid.CurrentRow.Cells[1].Value.ToString();
            m.soyadi = dgrid.CurrentRow.Cells[2].Value.ToString();
            m.tel1 = Convert.ToInt32(dgrid.CurrentRow.Cells[3].Value);
            m.tel2 = Convert.ToInt32(dgrid.CurrentRow.Cells[4].Value);
            m.ceptel1 = Convert.ToInt32(dgrid.CurrentRow.Cells[5].Value);
            m.ceptel2 = Convert.ToInt32(dgrid.CurrentRow.Cells[6].Value);
            m.il = dgrid.CurrentRow.Cells[7].Value.ToString();
            m.ilce = dgrid.CurrentRow.Cells[8].Value.ToString();
            m.adres = dgrid.CurrentRow.Cells[9].Value.ToString();
            m.not = dgrid.CurrentRow.Cells[10].Value.ToString();

            txtboxID.Text = m.ID.ToString();
            txtboxAdi.Text = m.adi;
            txtboxSoyAdi.Text = m.soyadi;
            txtboxTelefon1.Text = m.tel1.ToString();
            txtboxTelefon2.Text = m.tel2.ToString();
            txtboxCepTelefon1.Text = m.ceptel1.ToString();
            txtboxCepTelefon2.Text = m.ceptel2.ToString();
            txtboxIl.Text = m.il;
            txtboxIlce.Text = m.ilce;
            txtboxAdres.Text = m.adres;
            txtboxAcıklama.Text = m.not;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SQLiteConnection baglan = new SQLiteConnection();
            baglan.ConnectionString = ("Data Source=DatabaseSqlite/Musteriler_sqllite.db3;Compress=True;Version=3");
            SQLiteCommand komut = new SQLiteCommand("delete from musteri where ID=@ID", baglan);
            komut.Parameters.AddWithValue("@Id", txtboxID.Text);
            baglan.Open();
            int kayit = komut.ExecuteNonQuery();
            if (kayit > 0)
            {
                MessageBox.Show("Silindi");
            }
            else
            {
                MessageBox.Show("Silinemedi !!!", "HATA");
            }
            baglan.Cancel();
            gridyenile();

        }
        private void gridyenile()
        {
            try
            {
                SQLiteConnection baglan = new SQLiteConnection();
                baglan.ConnectionString = ("Data Source=DatabaseSqlite/Musteriler_sqllite.db3;Compress=True;Version=3");
                SQLiteCommand komut = new SQLiteCommand("select * from musteri", baglan);
                baglan.Open();
                dgrid.Rows.Clear();
                SQLiteDataReader Dataoku = komut.ExecuteReader();
                while (Dataoku.Read())
                {
                    dgrid.Rows.Add(new object[] {
                        Dataoku.GetValue(0),
                        Dataoku.GetValue(1),
                        Dataoku.GetValue(2),
                        Dataoku.GetValue(3),
                        Dataoku.GetValue(4),
                        Dataoku.GetValue(5),
                        Dataoku.GetValue(6),
                        Dataoku.GetValue(7),
                        Dataoku.GetValue(8),
                        Dataoku.GetValue(9),
                        Dataoku.GetValue(10)
                    });
                }
                baglan.Cancel();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Sqlite Hatası :" + hata);
            }
            
        }
    }
}
