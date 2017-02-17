using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Data.SQLite;

namespace TelefonRehberi
{
    public class RaporAl
    {
        public void excelal(string dosyayolu)
        {
            OleDbConnection excelbaglanti = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source =" + dosyayolu + ";Extended Properties =\"Excel 8.0;HDR=Yes;\";");
            DataTable tablo = new DataTable();
            OleDbDataAdapter data = new OleDbDataAdapter("select * from [Sayfa1$]", excelbaglanti);
            excelbaglanti.Open();
            data.Fill(tablo);
            excelbaglanti.Close();
            SQLiteConnection baglan = new SQLiteConnection();
            baglan.ConnectionString = ("Data Source=DatabaseSqlite/Musteriler_sqllite.db3;Compress=True;Version=3");
            baglan.Open();

            for (int i = 0; i < tablo.Rows.Count; i++)
            {
                SQLiteCommand komut = new SQLiteCommand("insert into musteri (adi,soyadi,telefon1,telefon2,ceptel1,ceptel2,adres,il,ilce,aciklama) values(@adi,@soyadi,replace(replace(@telefon1,' ',''),'-',''),replace(replace(@telefon2,' ',''),'-',''),replace(replace(@ceptel1,' ',''),'-',''),replace(replace(@ceptel2,' ',''),'-',''),@adres,@il,@ilce,@aciklama)", baglan);
                komut.Parameters.AddWithValue("@adi", tablo.Rows[i][0].ToString());
                komut.Parameters.AddWithValue("@soyadi", tablo.Rows[i][1].ToString());
                komut.Parameters.AddWithValue("@telefon1",Convert.ToInt64(tablo.Rows[i][2]));
                komut.Parameters.AddWithValue("@telefon2", Convert.ToInt64(tablo.Rows[i][3]));
                komut.Parameters.AddWithValue("@ceptel1", Convert.ToInt64(tablo.Rows[i][4]));
                komut.Parameters.AddWithValue("@ceptel2", Convert.ToInt64(tablo.Rows[i][5]));
                komut.Parameters.AddWithValue("@adres", tablo.Rows[i][6].ToString());
                komut.Parameters.AddWithValue("@ilce", tablo.Rows[i][7].ToString());
                komut.Parameters.AddWithValue("@il", tablo.Rows[i][8].ToString());
                komut.Parameters.AddWithValue("@aciklama", tablo.Rows[i][9].ToString());
                komut.ExecuteNonQuery();
            }
            baglan.Close();

        }
    }
}
