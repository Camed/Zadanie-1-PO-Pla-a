using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kopakabana
{
    class TurniejOgnie : Turniej
    {
        public TurniejOgnie(List<Druzyna> druzyny, List<Sedzia> sedzie)
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
                    mecze.Add(new MeczDwaOgnie((DruzynaDwaOgnie)druzyny[i], (DruzynaDwaOgnie)druzyny[j], sedzie[0]));
                }
            }
            foreach (var x in mecze)
                x.Play();
        }
        public List<Druzyna> Top4()
        {

            return druzyny;
        }
    }
}