using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROIECT_PAW
{
    class Dictionar
    {
        List<Explicatii> e;
       List<CuvinteEng> cE;
        List<CuvinteRom> cR;

        Dictionar()
        {
            e = new List<Explicatii>();
            cE = new List<CuvinteEng>();
            cR = new List<CuvinteRom>();
        }

       public Dictionar( string newRom,string newEng, string newExp)
        {
            //e = new Explicatii(newExp);
            //cE = new CuvinteEng(newEng);
            //cR = new CuvinteRom(newRom);


            if (e == null) e = new List<Explicatii>();
            Explicatii xp = new Explicatii(newExp);
            e.Add(xp);

            if (cE == null) cE = new List<CuvinteEng>();
            CuvinteEng ec = new CuvinteEng(newEng);
            cE.Add(ec);

            if (cR == null) cR = new List<CuvinteRom>();
            CuvinteRom rc = new CuvinteRom(newRom);
            cR.Add(rc);
        }

        public string getCuvantDinExplicatii()
        {
            return e.ElementAt(0).getCuvant();
            //return e.getCuvant();
        }

        public string getCuvantDinCuvinteEngleza()
        {
            return cE.ElementAt(0).getCuvant();
            //return cE.getCuvant();
        }

        public string getCuvantDinCuvinteRomana()
        {
            return cR.ElementAt(0).getCuvant();
            //return cR.getCuvant();
        }




        public static Dictionar operator +(Dictionar d, Dictionar aux)
        {
            Explicatii auxiliarExplicatii = new Explicatii(aux.getCuvantDinExplicatii());
            d.e.Add(auxiliarExplicatii);

            CuvinteEng auxiliarCuvEng = new CuvinteEng(aux.getCuvantDinCuvinteEngleza());
            d.cE.Add(auxiliarCuvEng);

            CuvinteRom auxiliarCuvRom = new CuvinteRom(aux.getCuvantDinCuvinteRomana());
            d.cR.Add(auxiliarCuvRom);
            return d;
        }



    }
}
