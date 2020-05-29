using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kopakabana
{
    class Finaly
    {
        

        public virtual void Start()
        {
            
        }
    }
    class FinSiatka : Finaly
    {
        private MeczSiatkowki m1;
        private MeczSiatkowki m2;
        private MeczSiatkowki m3;
        private MeczSiatkowki m4;
        private DruzynaSiatkowka d1;
        private DruzynaSiatkowka d2;
        private DruzynaSiatkowka d3;
        private DruzynaSiatkowka d4;
        private List<Druzyna> Drabina = new List<Druzyna>();
        private List<Sedzia> s;
        public FinSiatka(DruzynaSiatkowka d1, DruzynaSiatkowka d2, DruzynaSiatkowka d3, DruzynaSiatkowka d4, List<Sedzia> s)
        {
            this.d1 = d1;
            this.d2 = d2;
            this.d3 = d3;
            this.d4 = d4;
            this.s = s;
        }
        public override void Start()
        {
            m1 = new MeczSiatkowki(d1, d2, s[0], s[1], s[2]);
            m1.Play();
            m2 = new MeczSiatkowki(d3, d4, s[3], s[4], s[5]);
            m2.Play();
            m3 = new MeczSiatkowki((DruzynaSiatkowka)m1.Zwyciezca, (DruzynaSiatkowka)m2.Zwyciezca, s[0], s[1], s[2]);
            m4 = new MeczSiatkowki((DruzynaSiatkowka)m1.Przegrany, (DruzynaSiatkowka)m2.Przegrany, s[3], s[4], s[5]));
            m3.Play();
            m4.Play();
            

        }
    }
}
