using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kopakabana
{
    abstract class Turniej
    {
        protected struct WygraneiPunkty
        {
            public int wygrane;
            public int punkty;
            public WygraneiPunkty(int x, int y)
            {
                wygrane = x;
                punkty = y;
            }
        }
        protected List<Mecz> mecze = new List<Mecz>();
        protected List<Druzyna> druzyny = new List<Druzyna>();
        protected List<Sedzia> sedzie = new List<Sedzia>();

        public abstract void Start();
    }
}
