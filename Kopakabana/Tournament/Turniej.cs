using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kopakabana
{
    abstract class Turniej<T, M>
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
        public List<M> mecze = new List<M>();
        protected List<T> druzyny = new List<T>();
        protected List<Sedzia> sedzie = new List<Sedzia>();

        public abstract void Start();
    }
}
