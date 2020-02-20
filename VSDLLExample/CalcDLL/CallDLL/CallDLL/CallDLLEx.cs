using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallDLL
{
    public class CallDLLEx
    {
        public int OgrenciNo, Vize, Final, But;
        public string Adi, Soyadi;

        public float OrtalamaHesapla(int vize, int final, int but)
        {
            return (vize + final + but) / 3;
        }

        public string HarfNotuHesapla(float OrtalamaNotu)
        {
            
            if (OrtalamaNotu < 45)
            {
                return "FF";
            } else 

            if (OrtalamaNotu >= 45 && OrtalamaNotu <= 55)
            {
                return "DD";
            } else

            if (OrtalamaNotu >= 56 && OrtalamaNotu <= 65)
            {
                return "CC";
            } else

            if (OrtalamaNotu >= 66 && OrtalamaNotu <= 85)
            {
                return "BB";
            } else

            if (OrtalamaNotu >= 86 && OrtalamaNotu <= 100)
            {
                return "AA";
            } else
            {
                return "0x0"; //0x0 100 veya - değerli üzeri not girilmiş demektir.
            }
        }
    }


}
