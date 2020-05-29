using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kopakabana
{
    class TurniejSiatkowka
    {
        public TurniejSiatkowka(List<Druzyna> druzyna, List<Sedzia> sedzie)
        {
            this.druzyna = druzyna;
            this.sedzie = sedzie;
        }
        public void Start()
        {
            for (int i = 0; i < druzyna.Count(); i++)
            {
                for (int j = i; j < druzyna.Count(); j++)
                {
                    mecze.Add(new MeczSiatkowki((DruzynaSiatkowka)druzyna[i], (DruzynaSiatkowka)druzyna[j], sedzie[0], sedzie[1], sedzie[2]));
                }
            }
            foreach (var x in mecze)
                x.Play();
        }
        public List<Druzyna> Top4()
        {
            
            return druzyna;
        }
    }
}
