using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROIECT_PAW
{
    class Explicatii
    {
        string cuvant;

    public    Explicatii()
        {
            cuvant = "";
        }
     public   Explicatii(string noucuv)
        {
            cuvant = noucuv;
        }

        public string getCuvant()
        {
           
                return cuvant;
            
        }

    }
}
