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
    class TurniejLina : Turniej<DruzynaLina, MeczPrzeciaganieLiny>
    {
        public TurniejLina(List<DruzynaLina> druzyny, List<Sedzia> sedzie)
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
        public List<DruzynaLina> Top4()
        {

            Dictionary<DruzynaLina, WygraneiPunkty> zlicz = new Dictionary<DruzynaLina, WygraneiPunkty>();
            
            foreach(DruzynaLina y in druzyny)
            {
                zlicz.Add(y, new WygraneiPunkty());
            }
            foreach(var y in mecze)
            {
                DruzynaLina zw = (DruzynaLina)y.Zwyciezca;
                DruzynaLina zp = (DruzynaLina)y.Przegrany;
                zlicz[zw] = new WygraneiPunkty(zlicz[zw].wygrane + 1, zlicz[zw].punkty + y.PunktyUzyskaneZwyciezcy);
                zlicz[zp] = new WygraneiPunkty(zlicz[zp].wygrane, zlicz[zp].punkty + y.PunktyUtraconeZwyciezcy);
            }
            var n = zlicz.ToList().OrderByDescending(a => a.Value.wygrane).ThenByDescending(a => a.Value.punkty);

            List<DruzynaLina> odp = new List<DruzynaLina>();
            foreach (var t in n)
            {
                odp.Add(t.Key);
            }

            return odp;
        }
    }
}