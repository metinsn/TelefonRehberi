using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelefonRehberi
{
    class MusteriKayit
    {
        public int ID { get; set; }
        public string adi { get; set; }
        public string soyadi { get; set; }
        public int tel1 { get; set; }
        public int tel2 { get; set; }
        public int ceptel1 { get; set; }
        public int ceptel2 { get; set; }
        public string adres { get; set; }
        public string il { get; set; }
        public string ilce { get; set; }
        public string not { get; set; }
    }


}
