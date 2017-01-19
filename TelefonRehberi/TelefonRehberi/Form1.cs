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

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            try
            {
                SQLiteConnection baglan = new SQLiteConnection();
                baglan.ConnectionString = ("Data Source=DatabaseSqlite/Musteriler_sqllite.db3;Compress=True;Version=3");
                SQLiteCommand komut = new SQLiteCommand("select * from musteri", baglan);
                baglan.Open();
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
            }
            catch (Exception hata)
            {
                MessageBox.Show("Sqlite Hatası :" + hata);
            }
        }

        private void dgrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int ID = Convert.ToInt32(dgrid.CurrentRow.Cells[0].Value);
            string adi = dgrid.CurrentRow.Cells[1].Value.ToString();
            string soyadi = dgrid.CurrentRow.Cells[2].Value.ToString();
            int tel1 = Convert.ToInt32(dgrid.CurrentRow.Cells[3].Value);
            int tel2 = Convert.ToInt32(dgrid.CurrentRow.Cells[4].Value);
            int ceptel1 = Convert.ToInt32(dgrid.CurrentRow.Cells[5].Value);
            int ceptel2 = Convert.ToInt32(dgrid.CurrentRow.Cells[6].Value);
            string il = dgrid.CurrentRow.Cells[7].Value.ToString();
            string ilce = dgrid.CurrentRow.Cells[8].Value.ToString();
            string adres = dgrid.CurrentRow.Cells[9].Value.ToString();
            string not = dgrid.CurrentRow.Cells[10].Value.ToString();

            txtboxID.Text = ID.ToString();
            txtboxAdi.Text = adi;
            txtboxSoyAdi.Text = soyadi;
            txtboxTelefon1.Text = tel1.ToString();
            txtboxTelefon2.Text = tel2.ToString();
            txtboxCepTelefon1.Text = ceptel1.ToString();
            txtboxCepTelefon2.Text = ceptel2.ToString();
            txtboxIl.Text = il;
            txtboxIlce.Text = ilce;
            txtboxAdres.Text = adres;
            txtboxAcıklama.Text = not;
        }
    }
}
