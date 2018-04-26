using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szamlazas
{
    /*
     * 7. Feladat
     * 
     * Hozzon létre egy osztályt Szamlak néven! Állítsa publikussá!
     */
    public class Szamlak
    {
        /*
         * 8. Feladat
         * 
         * Hozzon létre a Szamla osztályban egy privát tagváltozót:
         * szamlak: List<Szamla> ("Szamla"-kat tároló lista)
         */
        private List<Szamla> szamlak;

        /*
         * 9. Feladat
         * 
         * Valósítsa meg a Szamlak osztaly konstruktorát! Paraméterlistája üres!
         * A konstruktor példányosítsa az osztályban tárolt listát!
         */
        public Szamlak()
        {
            szamlak = new List<Szamla>();
        }

        /*
         * 10. Feladat
         * 
         * Hozzon létre a Szamlak osztályban egy Tartozas nevű függvényt!
         * Paraméterül várjon egy szöveges változót, ami a partner neve!
         * Térjen vissza egy egész típusú változóval, ami megadja, hogy a paratméterül adott
         * partner mennyi pénzzel tartozik!
         */
        public int Tartozas(string partner)
        {
            int tartozas = 0;
            foreach (var szamla in szamlak)
            {
                if (szamla.Partner == partner)
                    tartozas += szamla.Fizetendo;
            }
            return tartozas;
        }

        /*
         * 11. Feladat
         * 
         * Hozzon létre a Szamlak osztályban egy UjSzamla nevű függvényt!
         * A függvény várjon paraméterül egy Szamla típusú változót, majd ezt adja hozzá
         * a szamlak listához! Ne térjen vissza semmivel!
         */
        public void UjSzamla(Szamla szamla) { szamlak.Add(szamla); }

        /*
         * 12. Feladat
         * 
         * Hozzon létre a Szamlak osztályban egy Kintlevosegek nevű függvényt!
         * Paraméterlistája üsres! Térjen vissza egy egész sámmal, amely megadja, hogy
         * összesen mennyi a kifzetendő számlák összege.
         */
        public int Kintlevosegek()
        {
            int kintlevosegek = 0;
            foreach (var szamla in szamlak)
            {
                kintlevosegek += szamla.Fizetendo;
            }
            return kintlevosegek;
        }

        /*
         * 13. Feladat
         * 
         * Hozzon létre a Szamlak osztályban egy SzamlaPartnere nevű függvényt!
         * A függény paraméterül vár egy szöveg típusú változót, ami egy számlaszámot replezentál.
         * Térjen vissza egy szöveges típusú változóval, amely megadja a paraméterül átadott
         * számlaszámhoz tartozó partner nevét!
         * Ha nem található a számla, akkor térjen vissza TODO szöveggel.
         */
        public string SzamlaPartnere(string szamlaszam)
        {
            foreach (var szamla in szamlak)
            {
                if (szamla.SzamlaSzama == szamlaszam)
                    return szamla.Partner;
            }
            return "TODO";
        }

        /*
         * 14. Feladat
         * 
         * Hozzon létre a Szamlak osztályban egy SzamlaPartnere nevű függvényt!
         * A függény paraméterül vár egy szöveg típusú változót, ami egy számlaszámot replezentál.
         * Térjen vissza egy egész típusú változóval, amely megadja a paraméterül átadott
         * számlaszámhoz tartozó számla fizetendő értékét!
         * Ha nem található a számla, akkor térjen vissza (-1)-gyel.
         */
        public int SzamlaOsszege(string szamlaszam) 
        {
            foreach (var szamla in szamlak)
            {
                if (szamla.SzamlaSzama == szamlaszam)
                    return szamla.Fizetendo;
            }
            return -1;
        }

        /*
         * 16. Feladat
         * 
         * Hozzon létre a Szamlak osztályban egy MostWantedSzamla nevű függvény!
         * A függvén térjen vissza a legmagasabb fizetendő összeggel rendelkező számla 
         * számlaszámával! A függvénynek nincs paramétere.
         */
        public string MostWantedSzamla()
        {
            return szamlak.Max().SzamlaSzama;
        }

        /*
         * 17. Feladat
         * 
         * Hozzon lére a Szamlak osztályban egy egyész típusú csak olvasható property-t
         * FizezendoSzamlakSzama! A property a ki nem fizetett számlák számát mutassa!
         */
        public int FizetendoSzamlakSzama
        {
            get
            {
                int darab = 0;
                foreach (var szamla in szamlak)
                {
                    if (szamla.Fizetendo > 0)
                        darab++;
                }
                return darab;
            }
        }

    }
}
