using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kopakabana
{
    public enum SedziaType
    {
        Siatkowka, DwaOgnie, Lina
    }
    public class Sedzia
    {
        public SedziaType SType;
        public string Imie      { get; private set; }
        public string Nazwisko  { get; private set; }
        
        public Sedzia(string imie, string nazwisko, SedziaType stype)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            SType = stype;
        }
        public void PokazSedzie()
        {
            string typ = "";
            switch (SType)
            {
                case SedziaType.Lina:
                    typ = "przeciaganie liny";
                    break;
                case SedziaType.DwaOgnie:
                    typ = "dwa ognie";
                    break;
                case SedziaType.Siatkowka:
                    typ = "siatkowke";
                    break;
            }
            MessageBox.Show($"Oto sedzia {Imie} {Nazwisko}. Sedziuje w rozgrywkach w {typ}.");
        }
    }
}
