using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kopakabana
{
    abstract class Turniej
    {
        protected List<Mecz> mecze = new List<Mecz>();
        protected List<Druzyna> druzyna = new List<Druzyna>();
        protected List<Sedzia> sedzie = new List<Sedzia>();

        public abstract void Start();
    }
}
