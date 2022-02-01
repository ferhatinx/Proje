using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje1
{
    class Kisi
    {
        private string isim;
        private string soyisim;
        private string telno;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public string Telno { get => telno; set => telno = value; }

        public Kisi(string Isim, string Soyisim, string Telno)
        {
            this.Isim = isim;
            this.Soyisim = soyisim;
            this.Telno = telno;
        }

        
    }
}