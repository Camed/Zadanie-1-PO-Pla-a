using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kopakabana
{
    public static class FileManagement
    {
        private const string sedziowiePath = "/data/sedziowie.txt";               // 1 sędzia - 1 linia, każda linia wygląda tak: SType Imie Nazwisko
        private const string siatkowkaPath = "/data/siatkowka.txt";               // nazwy druzyn siatkowki
        private const string dwaOgniePath  = "/data/dwaognie.txt";                // nazwy druzyn w dwa ognie
        private const string linaPath      = "/data/lina.txt";                    // nazwy druzyn w przeciaganie liny

        /// <summary>
        /// Wczytywanie sedziow z plikow
        /// </summary>
        private static void loadSedziowie()
        {
            string[] input = File.ReadAllLines(sedziowiePath);
            foreach(var s in input)
            {
                var x = s.Split(' ');
                string type = x[0];
                string imie = x[1];
                string nazwisko = x[2];
                switch (type)
                {
                    case "siatkowka":
                        Listy.SedziowieSiatkowki.Add(new Sedzia(imie, nazwisko, SedziaType.Siatkowka));
                        break;
                    case "dwaognie":
                        Listy.SedziowieDwaOgnie.Add(new Sedzia(imie, nazwisko, SedziaType.DwaOgnie));
                        break;
                    case "lina":
                        Listy.SedziowieLina.Add(new Sedzia(imie, nazwisko, SedziaType.Lina));
                        break;
                }
            }
        }
        
        /// <summary>
        /// Wczytywanie druzyn siatkowki z plikow
        /// </summary>
       
    }
}
