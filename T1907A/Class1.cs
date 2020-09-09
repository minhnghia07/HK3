using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1907A
{
    class Class1
    {
        public string nameEmail { get; set; }
        public string tieude { get; set; }
        public string noidung { get; set; }

        public Class1(string nameEmail, string tieude, string noidung)
        {
            this.nameEmail = nameEmail;
            this.tieude = tieude;
            this.noidung = noidung;
        }
        public override string ToString()
        {
            return nameEmail + "\n" + tieude  + "\n" + noidung;
        }


    }
}
