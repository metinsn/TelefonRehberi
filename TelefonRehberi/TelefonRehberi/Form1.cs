using System.Windows.Forms;
using System.Data.SQLite;
using System;

namespace TelefonRehberi
{
    public partial class Form1 : Form 
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, System.EventArgs e)
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
                        Dataoku.GetValue(10)
                    });
                }
        
              
               

            }
            catch (Exception hata)
            {

                MessageBox.Show("Sqlite Hatası :" + hata);
            }
        }

       
    }
}
