using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Kopakabana
{
    class TurniejLina : Turniej
    {
        public TurniejLina(List<Druzyna> druzyny, List<Sedzia> sedzie)
        {
            this.druzyny = druzyny;
            this.sedzie = sedzie;
        }
        public override void Start()
        {
            for (int i = 0; i < druzyny.Count(); i++)
            {
                for (int j = i + 1; j < druzyny.Count(); j++)
                {
                    mecze.Add(new MeczPrzeciaganieLiny((DruzynaLina)druzyny[i], (DruzynaLina)druzyny[j], sedzie[0]));
                }
            }
            foreach (var x in mecze)
                x.Play();
        }
        public List<Druzyna> Top4()
        {
            Dictionary<DruzynaLina, WygraneiPunkty> zlicz = new Dictionary<DruzynaLina, WygraneiPunkty>();
           
            foreach(DruzynaLina x in druzyny)
            {
                zlicz.Add(x, new WygraneiPunkty());
            }
            foreach(var x in mecze)
            {
                DruzynaLina zw = (DruzynaLina)x.Zwyciezca;
                DruzynaLina zp = (DruzynaLina)x.Przegrany;
                zlicz[zw] = new WygraneiPunkty(zlicz[zw].wygrane + 1, zlicz[zw].punkty + x.PunktyUzyskaneZwyciezcy);
                zlicz[zp] = new WygraneiPunkty(zlicz[zp].wygrane, zlicz[zp].punkty + x.PunktyUtraconeZwyciezcy);
            }


            return new List<Druzyna>();
        }
    }
}