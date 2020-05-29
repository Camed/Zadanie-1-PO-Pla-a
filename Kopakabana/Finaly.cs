using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kopakabana
{
    abstract class Finaly
    {
        protected List<Druzyna> Drabina = new List<Druzyna>();

        protected List<Sedzia> s;
        public abstract List<Druzyna> Start();
    }
}

