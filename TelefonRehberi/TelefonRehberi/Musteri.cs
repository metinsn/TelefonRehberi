﻿using System;
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
        public Int64 tel1 { get; set; }
        public Int64 tel2 { get; set; }
        public Int64 ceptel1 { get; set; }
        public Int64 ceptel2 { get; set; }
        public string adres { get; set; }
        public string il { get; set; }
        public string ilce { get; set; }
        public string not { get; set; }
        public string sifre { get; set; }
    }


}
