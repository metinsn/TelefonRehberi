using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelefonRehberi
{
    public partial class xlsxAl : Form
    {
        public xlsxAl()
        {
            InitializeComponent();
        }
        string klasorYolu="";
        private void btnSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog Dizin = new OpenFileDialog();
            Dizin.Filter = "Excel Dosyası(*.xlsx)|*.xlsx|Excel Dosyası(*.xls)|*.xls";
            Dizin.FilterIndex = 2;
            Dizin.Title = "Excel Dosyasını Seçiniz";
            Dizin.ShowDialog();
            klasorYolu = Dizin.FileName;
            txtboxDizin.Text = klasorYolu;
        }

        private void btnAl_Click(object sender, EventArgs e)
        {
            try
            {
                if (klasorYolu != "")
                {
                    RaporAl rapor = new RaporAl();
                    rapor.excelal(@klasorYolu);
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
                MessageBox.Show(klasorYolu + " içeri aktarıldı kontrol edin !");
                this.Close();
            }

        }
    }
}
