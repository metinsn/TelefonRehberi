using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Packaging;

namespace TelefonRehberi
{
    class Rapor
    {
        public SpreadsheetDocument excelolustur(string Dosyaadı)
        {
            using (
                SpreadsheetDocument dosya = SpreadsheetDocument.Create(@Dosyaadı, SpreadsheetDocumentType.Workbook, false))
            {
                WorkbookPart kitapbolum = dosya.AddWorkbookPart();
                kitapbolum.Workbook = new Workbook();
                return dosya;
            }


        }
    }
}
