using System.Collections.Generic;

namespace Kopakabana
{
    class FinSiatka : Finaly
    {
        private MeczSiatkowki m1, m2, m3, m4;
        private DruzynaSiatkowka d1, d2, d3, d4;
        public FinSiatka(DruzynaSiatkowka d1, DruzynaSiatkowka d2, DruzynaSiatkowka d3, DruzynaSiatkowka d4, List<Sedzia> s) //6 sędziów
        {
            this.d1 = d1;
            this.d2 = d2;
            this.d3 = d3;
            this.d4 = d4;
            this.s = s;
        }
        public override List<Druzyna> Start()
        {
            m1 = new MeczSiatkowki(d1, d2, s[0], s[1], s[2]);
            m1.Play();
            m2 = new MeczSiatkowki(d3, d4, s[3], s[4], s[5]);
            m2.Play();
            m3 = new MeczSiatkowki((DruzynaSiatkowka)m1.Zwyciezca, (DruzynaSiatkowka)m2.Zwyciezca, s[0], s[1], s[2]);
            m4 = new MeczSiatkowki((DruzynaSiatkowka)m1.Przegrany, (DruzynaSiatkowka)m2.Przegrany, s[3], s[4], s[5]);
            m3.Play();
            m4.Play();
            Drabina.Add((DruzynaSiatkowka)m3.Zwyciezca);
            Drabina.Add((DruzynaSiatkowka)m3.Przegrany);
            Drabina.Add((DruzynaSiatkowka)m4.Zwyciezca);
            Drabina.Add((DruzynaSiatkowka)m4.Przegrany);
            return Drabina;
        }
    }
}

