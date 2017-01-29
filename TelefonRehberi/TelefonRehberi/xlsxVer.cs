using System;
using System.Windows.Forms;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Packaging;
namespace TelefonRehberi
{
    public partial class xlsxVer : Form
    {
        public xlsxVer()
        {
            InitializeComponent();
        }
        string klasorYolu="";

        private void btnSec_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog Dizin = new FolderBrowserDialog();
            Dizin.ShowDialog();
            klasorYolu = Dizin.SelectedPath + "/Telefon Listesi.xls";
            txtboxDizin.Text = klasorYolu;

        }

        private void btnAl_Click(object sender, EventArgs e)
        {
            try
            {
                if (klasorYolu != "")
                {
                    Rapor rapor = new Rapor();
                    rapor.excelolustur(@klasorYolu);
                }
                else
                {
                    MessageBox.Show("Dizin Giriniz !");
                }
            }
            catch (Exception hata)
            {

                MessageBox.Show("Hata :" + hata.Message);
            }
            finally
            {
                MessageBox.Show(klasorYolu + " Dizinine Kaydedildi.");
            }
           
           
        }
    }
}
