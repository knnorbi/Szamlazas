using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szamlazas
{
    /*
     * 1. Feladat
     * 
     * Hozzon létre egy osztályt Szamla néven! Állítsa publikussá!
     */
    public class Szamla: IComparable
    {
        /*
         * 2. Feladat
         * 
         * Hozzon létre a Szamla osztályban négy privát tagváltozót:
         * szam: szöveg
         * osszeg: egész
         * partner: szöveg
         * teljesitve: logikai
         */
        private string szam;
        private int osszeg;
        private string partner;
        private bool teljesitve;

        /*
         * 3. Feladat
         * 
         * Valósítsa meg a Szamla osztály konstruktorát!
         * Paraméterül várjon egy egész és egy szöveg típusú változót!
         * Az osztály osszeg tagválózójának értékét állítsa be a paraméterül átadott egész értékre!
         * Az osztály partner tagválózójának értékét állítsa be a paraméterül átadott szöveg értékre!
         * Az osztály teljesitve tagválózójának értékét állítsa hamis értékre!
         * Az osztály szam tagválózójának értékét állítsa be az aktuális dátumból képzett értékre
         * a minta szerint! (minta: 20180426/113503)
         */
        public Szamla(int osszeg, string partner)
        {
            this.osszeg = osszeg;
            this.partner = partner;
            teljesitve = false;
            szam = DateTime.Now.Year.ToString()+ DateTime.Now.Month.ToString()
                + DateTime.Now.Day.ToString() + "/" + DateTime.Now.Hour.ToString()
                + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString();
        }

        /* 
         * 4. Feladat
         * 
         * Hozzon létre a Szamla osztályban egy SzamlaSzama nevű csak olvasható property-t,
         * ami visszaadja a számla számlaszámát!
         * Hozzon létre a Szamla osztályban egy Partner nevű csak olvasható property-t,
         * ami visszaadja a számlához tartozó partnert!
         */
        public string SzamlaSzama { get { return szam; } }
        public string Partner { get { return partner; } }

        /* 
         * 5. Feladat
         * 
         * Hozzon létre a Szamla osztályban egy Fizetendo nevű csak olvasható property-t,
         * ami visszaadja a számla összegét abban az esetben, ha a számla nincs teljesítve!
         * Teljesített számlák esetén nullát adjon vissza!
         */
        public int Fizetendo
        {
            get
            {
                if (teljesitve)
                    return 0;
                return osszeg;
            }
        }

        /*
         * 6. Feladat
         * 
         * Hozzon létra a Szamla osztalyban egy Fizet nevű függvény! A függvény ne térjen vissza
         * semmivel, paraméterlistája üres! A függvény állítsa a teljesitve tagváltozó értékét igazra!
         */
        public void Fizet() { teljesitve = true; }

        /*
         * 15. Feladat
         * 
         * Impelmetnálja a Szamla osztályba a IComparable interfészt!
         * A számlákat a fizetendő összegek alapján hasonlítsa össze!
         */
        public int CompareTo(object obj)
        {
            Szamla masik = obj as Szamla;
            return this.Fizetendo.CompareTo(masik.Fizetendo);
        }
    }
}
