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
            if (txtboxAdi.Text != "" && txtboxTelefon1.Text != "")
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
                komut.Parameters.AddWithValue("@adres", txtboxAdres.Text);
                komut.Parameters.AddWithValue("@ilce", txtboxIlce.Text);
                komut.Parameters.AddWithValue("@il", txtboxIl.Text);
                komut.Parameters.AddWithValue("@aciklama", txtboxAcıklama.Text);
                baglan.Open();
                int kayit = komut.ExecuteNonQuery();
                if (kayit > 0)
                {
                    MessageBox.Show("  Kaydedildi");
                }
                else
                {
                    MessageBox.Show("Kaydedildilemedi !!!", "HATA");
                }
                baglan.Cancel();
                gridyenile();
                temizle();
            }
            else
            {
                MessageBox.Show("Alanları doldurun !!!");
            }


        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            gridyenile();
        }


        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtboxID.Text != "")
            {
                SQLiteConnection baglan = new SQLiteConnection();
                baglan.ConnectionString = ("Data Source=DatabaseSqlite/Musteriler_sqllite.db3;Compress=True;Version=3");
                SQLiteCommand komut = new SQLiteCommand("delete from musteri where ID=@ID", baglan);
                komut.Parameters.AddWithValue("@Id", txtboxID.Text);
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
                temizle();
            }
            else
            {
                MessageBox.Show("Gridden seçiniz yada sıra no giriniz !!!");
            }

        }

        private void dgrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < dgrid.RowCount - 1)
            {
                m.ID = Convert.ToInt32(dgrid.CurrentRow.Cells[0].Value);
                m.adi = dgrid.CurrentRow.Cells[1].Value.ToString();
                m.soyadi = dgrid.CurrentRow.Cells[2].Value.ToString();
                m.tel1 = Convert.ToInt32(dgrid.CurrentRow.Cells[3].Value);
                m.tel2 = Convert.ToInt32(dgrid.CurrentRow.Cells[4].Value);
                m.ceptel1 = Convert.ToInt32(dgrid.CurrentRow.Cells[5].Value);
                m.ceptel2 = Convert.ToInt32(dgrid.CurrentRow.Cells[6].Value);
                m.adres = dgrid.CurrentRow.Cells[7].Value.ToString();
                m.il = dgrid.CurrentRow.Cells[8].Value.ToString();
                m.ilce = dgrid.CurrentRow.Cells[9].Value.ToString();
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



        }
        private void gridyenile()
        {
            try
            {
                SQLiteConnection baglan = new SQLiteConnection();
                baglan.ConnectionString = ("Data Source=DatabaseSqlite/Musteriler_sqllite.db3;Compress=True;Version=3");
                SQLiteCommand komut = new SQLiteCommand("select * from musteri order by ID desc", baglan);
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
                dgrid.AutoResizeColumns();
            }
            catch (Exception e)
            {

                MessageBox.Show("Hata Uyarısı :" + e.Message);
            }

        }

        private void temizle()
        {
            txtboxID.Text = "";
            txtboxAdi.Text = "";
            txtboxSoyAdi.Text = "";
            txtboxTelefon1.Text = "";
            txtboxTelefon2.Text = "";
            txtboxCepTelefon1.Text = "";
            txtboxCepTelefon2.Text = "";
            txtboxIl.Text = "";
            txtboxIlce.Text = "";
            txtboxAdres.Text = "";
            txtboxAcıklama.Text = "";
        }

        private void txtboxAdi_TextChanged(object sender, EventArgs e)
        {
            if (txtboxAdi.Text != "" && rbtnArama.Checked==true)
            {
                SQLiteConnection baglan = new SQLiteConnection();
                baglan.ConnectionString = ("Data Source=DatabaseSqlite/Musteriler_sqllite.db3;Compress=True;Version=3");
                SQLiteCommand komut = new SQLiteCommand("select * from musteri where adi like @isimara order by ID desc", baglan);
                komut.Parameters.AddWithValue("@isimara", '%' + txtboxAdi.Text + '%');
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
                dgrid.AutoResizeColumns();
            }
            else
            {
                gridyenile();
            }
        }

        private void txtboxTelefon1_TextChanged(object sender, EventArgs e)
        {
            if (txtboxTelefon1.Text != "" && rbtnArama.Checked == true)
            {
                SQLiteConnection baglan = new SQLiteConnection();
                baglan.ConnectionString = ("Data Source=DatabaseSqlite/Musteriler_sqllite.db3;Compress=True;Version=3");
                SQLiteCommand komut = new SQLiteCommand("select * from musteri where telefon1 like @telara order by ID desc", baglan);
                komut.Parameters.AddWithValue("@telara", '%' + txtboxTelefon1.Text + '%');
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
                dgrid.AutoResizeColumns();
            }
            else
            {
                gridyenile();
            }
        }

        private void txtboxCepTelefon1_TextChanged(object sender, EventArgs e)
        {
            if (txtboxCepTelefon1.Text != "" && rbtnArama.Checked == true)
            {
                SQLiteConnection baglan = new SQLiteConnection();
                baglan.ConnectionString = ("Data Source=DatabaseSqlite/Musteriler_sqllite.db3;Compress=True;Version=3");
                SQLiteCommand komut = new SQLiteCommand("select * from musteri where ceptel1 like @ceptelara order by ID desc", baglan);
                komut.Parameters.AddWithValue("@ceptelara", '%' + txtboxCepTelefon1.Text + '%');
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
                dgrid.AutoResizeColumns();
            }
            else
            {
                gridyenile();
            }
        }
    }
    
}
