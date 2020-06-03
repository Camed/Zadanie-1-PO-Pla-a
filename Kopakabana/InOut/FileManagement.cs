using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kopakabana
{
    public static class FileManagement
    {
        private const string sedziowiePath = "data\\sedziowie.txt";                // 1 sędzia - 1 linia, każda linia wygląda tak: SType Imie Nazwisko
        private const string siatkowkaPath = "data\\siatkowka.txt";                // nazwy druzyn siatkowki
        private const string dwaOgniePath = "data\\dwaognie.txt";                  // nazwy druzyn w dwa ognie
        private const string linaPath = "data\\lina.txt";                          // nazwy druzyn w przeciaganie liny
        
        /// <summary>
        /// Zwraca true, jeśli pliki istnieją. W przeciwnym wypadku false.
        /// </summary>
        /// <returns></returns>
        private static bool filesExist()
        {
            return File.Exists(sedziowiePath) && File.Exists(siatkowkaPath) && File.Exists(dwaOgniePath) && File.Exists(linaPath);
        }


        /// <summary>
        /// Wczytywanie sedziow z plikow
        /// </summary>
        private static void loadSedziowie()
        {
            string[] input = File.ReadAllLines(sedziowiePath);
            foreach (var s in input)
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
        private static void loadSiatkowka()
        {
            string[] input;
            try
            {
                input = File.ReadAllLines(siatkowkaPath);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            foreach (var s in input)
            {
                Listy.DruzynySiatkowki.Add(new DruzynaSiatkowka(s));
            }
        }


        /// <summary>
        /// Wczytywanie druzyn w dwa ognie z plikow
        /// </summary>
        private static void loadOgnie()
        {
            string[] input;
            try
            {
                input = File.ReadAllLines(dwaOgniePath);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            foreach (var s in input)
            {
                Listy.DruzynyDwaOgnie.Add(new DruzynaDwaOgnie(s));
            }
        }


        /// <summary>
        /// Wczytywanie druzyn w przeciaganie liny z plikow
        /// </summary>
        private static void loadLina()
        {
            string[] input;
            try
            {
                input = File.ReadAllLines(linaPath);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            foreach (var s in input)
            {
                Listy.DruzynyLina.Add(new DruzynaLina(s));
            }
        }


        /// <summary>
        /// Zapisywanie wszystkich sedziow do pliku
        /// </summary>
        private static void saveSedziowie()
        {
            try
            {
                File.Delete(sedziowiePath);
                File.Create(sedziowiePath);
                string[] sedziowie = new string[Listy.SedziowieDwaOgnie.Count() + Listy.SedziowieLina.Count() + Listy.SedziowieSiatkowki.Count()];
                int iter = 0;
                foreach (var x in Listy.SedziowieDwaOgnie)
                {
                    sedziowie[iter] = string.Format("dwaognie {0} {1}", x.Imie, x.Nazwisko);
                    iter++;
                }
                foreach (var x in Listy.SedziowieLina)
                {
                    sedziowie[iter] = string.Format("lina {0} {1}", x.Imie, x.Nazwisko);
                    iter++;
                }
                foreach (var x in Listy.SedziowieSiatkowki)
                {
                    sedziowie[iter] = string.Format("siatkowka {0} {1}", x.Imie, x.Nazwisko);
                }

                File.WriteAllLines(sedziowiePath, sedziowie);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        /// <summary>
        /// Zapisywanie druzyn siatkowki do pliku
        /// </summary>
        private static void saveSiatkowka()
        {
            try
            {
                File.Delete(siatkowkaPath);
                File.Create(siatkowkaPath);

                File.WriteAllLines(siatkowkaPath, from x in Listy.DruzynySiatkowki select x.Nazwa);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Zapisywanie druzyn w dwa ognie do pliku
        /// </summary>
        private static void saveOgnie()
        {
            try
            {
                File.Delete(dwaOgniePath);
                File.Create(dwaOgniePath);

                File.WriteAllLines(dwaOgniePath, from x in Listy.DruzynyDwaOgnie select x.Nazwa);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Zapisywanie druzyn w przeciaganie liny do pliku
        /// </summary>
        private static void saveLina()
        {
            try
            {
                File.Delete(linaPath);
                File.Create(linaPath);

                File.WriteAllLines(linaPath, from x in Listy.DruzynyLina select x.Nazwa);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Sprawdza, czy folder i pliki z danymi istnieją. Jeśli nie, tworzy je. Następnie "ładuje" ich zawartość.
        /// </summary>
        public static void Start()
        {
            if (!Directory.Exists("data"))
            {
                Directory.CreateDirectory("data");
            }
            if (!filesExist())
            {
                FileStream fs = File.Create(sedziowiePath);
                fs.Close(); fs.Dispose();

                fs = File.Create(linaPath);
                fs.Close(); fs.Dispose();

                fs = File.Create(siatkowkaPath);
                fs.Close(); fs.Dispose();

                fs = File.Create(dwaOgniePath);
                fs.Close(); fs.Dispose();

                fs = File.Create(linaPath);
                fs.Close(); fs.Dispose();
            }
            LoadFromFiles();
        }

        /// <summary>
        /// Zapisywanie wszystkich danych
        /// </summary>
        public static void SaveToFiles()
        {
            try
            {
                saveSedziowie();
                saveOgnie();
                saveSiatkowka();
                saveLina();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }


        /// <summary>
        /// Wczytywanie wszystkich danych
        /// </summary>
        public static void LoadFromFiles()
        {
            try
            {
                loadSedziowie();
                loadSiatkowka();
                loadLina();
                loadOgnie();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
