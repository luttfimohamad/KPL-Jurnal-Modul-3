using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul3_1302204066
{
    internal class KodeBuah
    {
        public string getKodeBuah(string Buah)
        {
            if (Buah == "Apel")
            {
                return "A00";
            }
            else if (Buah == "Aprikot")
            {
                return "B00";
            }
            else if (Buah == "Alpukat")
            {
                return "C00";
            }
            else if (Buah == "Pisang")
            {
                return "D00";
            }
            else if (Buah == "Paprika")
            {
                return "E00";
            }
            else if (Buah == "Blackberry")
            {
                return "F00";
            }
            else if (Buah == "Ceri")
            {
                return "H00";
            }
            else if (Buah == "Kelapa")
            {
                return "I00";
            }
            else if (Buah == "Jagung")
            {
                return "J00";
            }
            else if (Buah == "Kurma")
            {
                return "K00";
            }
            else if (Buah == "Durian")
            {
                return "L00";
            }
            else if (Buah == "Anggur")
            {
                return "M00";
            }
            else if (Buah == "Melon")
            {
                return "N00";
            }
            else if (Buah == "Semangka")
            {
                return "O00";
            }
            else
            {
                return "Tidak tersedia";
            }
        }
    }
}
