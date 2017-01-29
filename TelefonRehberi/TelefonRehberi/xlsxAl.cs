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

        private void btnSec_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog Dizin = new FolderBrowserDialog();
            Dizin.ShowDialog();
            string klasorYolu = Dizin.SelectedPath;
            txtboxDizin.Text = klasorYolu;
        }
    }
}
