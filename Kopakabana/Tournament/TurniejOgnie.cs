using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kopakabana
{
    class TurniejOgnie : Turniej<DruzynaDwaOgnie, MeczDwaOgnie>
    {
        public TurniejOgnie(List<DruzynaDwaOgnie> druzyny, List<Sedzia> sedzie)
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
                    mecze.Add(new MeczDwaOgnie(druzyny[i], druzyny[j], sedzie[0]));
                }
            }
            foreach (var x in mecze)
                x.Play();
        }
        public List<DruzynaDwaOgnie> Top4()
        {

            Dictionary<DruzynaDwaOgnie, WygraneiPunkty> zlicz = new Dictionary<DruzynaDwaOgnie, WygraneiPunkty>();

            foreach (DruzynaDwaOgnie y in druzyny)
            {
                zlicz.Add(y, new WygraneiPunkty());
            }
            foreach (var y in mecze)
            {
                DruzynaDwaOgnie zw = (DruzynaDwaOgnie)y.Zwyciezca;
                DruzynaDwaOgnie zp = (DruzynaDwaOgnie)y.Przegrany;
                zlicz[zw] = new WygraneiPunkty(zlicz[zw].wygrane + 1, zlicz[zw].punkty + y.PunktyUzyskaneZwyciezcy);
                zlicz[zp] = new WygraneiPunkty(zlicz[zp].wygrane, zlicz[zp].punkty + y.PunktyUtraconeZwyciezcy);
            }
            var n = zlicz.ToList().OrderByDescending(a => a.Value.wygrane).ThenByDescending(a => a.Value.punkty);

            List<DruzynaDwaOgnie> odp = new List<DruzynaDwaOgnie>();
            foreach (var t in n)
            {
                odp.Add(t.Key);
            }
            return odp;
        }
    }
}