using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kopakabana
{
    class Finaly
    {
        private Mecz m1;
        private Mecz m2;
        private Mecz m3;
        private Druzyna d1;
        private Druzyna d2;
        private Druzyna d3;
        private Druzyna d4;
        private List<Druzyna> Drabina = List<Druzyna>();
        private List<Sedzia> s = List<Sedzia>();
        public Finaly(Druzyna d1, Druzyna d2, Druzyna d3, Druzyna d4, List<Sedzia> s)
        {
            this.d1 = d1;
            this.d2 = d2;
            this.d3 = d3;
            this.d4 = d4;
            this.s = s;
        }
        public void Start()
        {

        }
    }
}
