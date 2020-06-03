using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kopakabana
{
    class TurniejSiatkowka : Turniej<DruzynaSiatkowka, MeczSiatkowki>
    {
        public TurniejSiatkowka(List<DruzynaSiatkowka> druzyna, List<Sedzia> sedzie)
        {
            this.druzyny = druzyna;
            this.sedzie = sedzie;
        }
        public override void Start()
        {
            for (int i = 0; i < druzyny.Count(); i++)
            {
                for (int j = i + 1; j < druzyny.Count(); j++)
                {
                    mecze.Add(new MeczSiatkowki(druzyny[i], druzyny[j], sedzie[0], sedzie[1], sedzie[2]));
                }
            }
            foreach (var x in mecze)
                x.Play();
        }
        public List<DruzynaSiatkowka> Top4()
        {

            Dictionary<DruzynaSiatkowka, WygraneiPunkty> zlicz = new Dictionary<DruzynaSiatkowka, WygraneiPunkty>();

            foreach (DruzynaSiatkowka y in druzyny)
            {
                zlicz.Add(y, new WygraneiPunkty());
            }
            foreach (var y in mecze)
            {
                DruzynaSiatkowka zw = (DruzynaSiatkowka)y.Zwyciezca;
                DruzynaSiatkowka zp = (DruzynaSiatkowka)y.Przegrany;
                zlicz[zw] = new WygraneiPunkty(zlicz[zw].wygrane + 1, zlicz[zw].punkty + y.PunktyUzyskaneZwyciezcy);
                zlicz[zp] = new WygraneiPunkty(zlicz[zp].wygrane, zlicz[zp].punkty + y.PunktyUtraconeZwyciezcy);
            }
            var n = zlicz.ToList().OrderByDescending(a => a.Value.wygrane).ThenByDescending(a => a.Value.punkty);

            List<DruzynaSiatkowka> odp = new List<DruzynaSiatkowka>();
            foreach(var t in n)
            {
                odp.Add(t.Key);
            }

            return odp;
        }
    }
}
