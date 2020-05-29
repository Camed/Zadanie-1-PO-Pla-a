using System.Collections.Generic;

namespace Kopakabana
{
    class FinPrzeciaganieLiny : Finaly
    {
        private MeczPrzeciaganieLiny m1, m2, m3, m4;
        private DruzynaLina d1, d2, d3, d4;
        public FinPrzeciaganieLiny(DruzynaLina d1, DruzynaLina d2, DruzynaLina d3, DruzynaLina d4, List<Sedzia> s) // 2 sędziowie
        {
            this.d1 = d1;
            this.d2 = d2;
            this.d3 = d3;
            this.d4 = d4;
            this.s = s;
        }
        public override List<Druzyna> Start()
        {
            m1 = new MeczPrzeciaganieLiny(d1, d2, s[0]);
            m1.Play();
            m2 = new MeczPrzeciaganieLiny(d3, d4, s[1]);
            m2.Play();
            m3 = new MeczPrzeciaganieLiny((DruzynaLina)m1.Zwyciezca, (DruzynaLina)m2.Zwyciezca, s[0]);
            m4 = new MeczPrzeciaganieLiny((DruzynaLina)m1.Przegrany, (DruzynaLina)m2.Przegrany, s[1]);
            m3.Play();
            m4.Play();
            Drabina.Add((DruzynaLina)m3.Zwyciezca);
            Drabina.Add((DruzynaLina)m3.Przegrany);
            Drabina.Add((DruzynaLina)m4.Zwyciezca);
            Drabina.Add((DruzynaLina)m4.Przegrany);
            return Drabina;
        }
    }
}

