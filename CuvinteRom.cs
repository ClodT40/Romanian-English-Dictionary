using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROIECT_PAW
{
    class CuvinteRom
    {
        string cuvant;

       public CuvinteRom()
        {
            cuvant = "";
        }
     public   CuvinteRom(string noucuv)
        {
            cuvant = noucuv;
        }
        public string getCuvant()
        {

            return cuvant;

        }
    }
}
