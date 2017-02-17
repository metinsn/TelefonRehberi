//using DocumentFormat.OpenXml;
//using DocumentFormat.OpenXml.Spreadsheet;
//using DocumentFormat.OpenXml.Packaging;
using System.Data.SQLite;
using System;
using excel = Microsoft.Office.Interop.Excel;



namespace TelefonRehberi
{

    class Raporyaz
    {
        public void excelyaz(string dosyayolu)
        {
            // excel oluşturma ve baslıklaeı datagridview'den alma
            excel.Application dosya = new excel.Application();
            excel.Workbook kitap;
            excel.Worksheet sayfa;
            dosya.Visible = true;
            kitap = dosya.Workbooks.Add(Type.Missing);
            sayfa = kitap.Worksheets.Add(kitap.Worksheets[1], Type.Missing, Type.Missing, Type.Missing) as excel.Worksheet;
            sayfa.Name = "Telefon Listesi";

            formKayıt gridform = new formKayıt();
            for (int a = 0; a < gridform.dgrid.ColumnCount; a++)
            {
                excel.Range hucre = (excel.Range)sayfa.Cells[1, a + 1];
                hucre.Value2 = gridform.dgrid.Columns[a].HeaderText;
            }


            // data kısmı
            SQLiteConnection baglan = new SQLiteConnection();
            baglan.ConnectionString = ("Data Source=DatabaseSqlite/Musteriler_sqllite.db3;Compress=True;Version=3");
            SQLiteCommand komut = new SQLiteCommand("select * from musteri order by ID desc", baglan);
            baglan.Open();
            SQLiteDataReader Dataoku = komut.ExecuteReader();
            int i = 0;
            while (Dataoku.Read())            
            {
                for (int j = 0; j < Dataoku.FieldCount; j++)
                {
                    sayfa.Cells[i+2,j+1] = Dataoku.GetValue(j).ToString();
                }
                i++;
            }
            baglan.Cancel();

            kitap.SaveAs(@dosyayolu);


            ////    excel.Application dosya = new excel.Application();
            ////    excel.Workbook kitap;
            ////    excel.Worksheet sayfa;
            ////    dosya.Visible = true;
            ////    kitap = dosya.Workbooks.Add(Type.Missing);
            ////    sayfa = kitap.Worksheets.Add(kitap.Worksheets[1], Type.Missing, Type.Missing, Type.Missing) as excel.Worksheet;
            ////    sayfa.Name = "Telefon Listesi";

            ////    formKayıt gridform = new formKayıt();

            ////    //for (int i = 0; i < gridform.dgrid.ColumnCount; i++)
            ////    //{
            ////    //    excel.Range hucre = (excel.Range)sayfa.Cells[1, i + 1];
            ////    //    hucre.Value2 = gridform.dgrid.Columns[i].HeaderText;
            ////    //}

            ////    int satir = 1;
            ////    int sutun = 1;

            ////    for (int i = 0; i < gridform.dgrid.RowCount; i++)
            ////    {
            ////        for (int j = 0; j < gridform.dgrid.ColumnCount; j++)
            ////        {
            ////            if (satir == 1)
            ////            {
            ////                sayfa.Cells[satir,sutun] = gridform.dgrid.Columns[j].HeaderText;
            ////            }
            ////            else
            ////            {
            ////                sayfa.Cells[satir, sutun] = gridform.dgrid.Rows[i].Cells[j].Value.ToString();
            ////            }
            ////            sutun ++;
            ////        }
            ////        sutun = 1;
            ////        satir++;
        }

        ////    //kitap.SaveAs(@dosyayolu);

        ////    //kitap.SaveAs(@"dosyayolu",excel.XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing,false, false, excel.XlSaveAsAccessMode.xlNoChange, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
        ////}
        //////public SpreadsheetDocument excelolustur(string Dosyaadı)
        //////{
        //////    using (
        //////        SpreadsheetDocument dosya = SpreadsheetDocument.Create(@Dosyaadı, SpreadsheetDocumentType.Workbook, false))
        //////    {
        //////        WorkbookPart kitapbolum = dosya.AddWorkbookPart();
        //////        kitapbolum.Workbook = new Workbook();
        //////        return dosya;
        //////    }
        //////}
    }
}
