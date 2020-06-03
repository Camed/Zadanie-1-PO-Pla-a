using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kopakabana
{
    class TurniejSiatkowka : Turniej
    {
        public TurniejSiatkowka(List<Druzyna> druzyna, List<Sedzia> sedzie)
        {
            this.druzyny = druzyna;
            this.sedzie = sedzie;
        }
        public override void Start()
        {
            for (int i = 0; i < druzyny.Count(); i++)
            {
                for (int j = i; j < druzyny.Count(); j++)
                {
                    mecze.Add(new MeczSiatkowki((DruzynaSiatkowka)druzyny[i], (DruzynaSiatkowka)druzyny[j], sedzie[0], sedzie[1], sedzie[2]));
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
