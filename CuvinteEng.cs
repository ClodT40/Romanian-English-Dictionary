using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROIECT_PAW
{
    class CuvinteEng
    {
        string cuvant;

      public  CuvinteEng()
        {
            cuvant = "";
        }
      public  CuvinteEng(string noucuv)
        {
            cuvant = noucuv;
        }
        public string getCuvant()
        {

            return cuvant;

        }
    }
}
