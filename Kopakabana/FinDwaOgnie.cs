using System.Collections.Generic;

namespace Kopakabana
{
    class FinDwaOgnie : Finaly
    {
        private MeczDwaOgnie m1, m2, m3, m4;
        private DruzynaDwaOgnie d1, d2, d3, d4;
        public FinDwaOgnie(DruzynaDwaOgnie d1, DruzynaDwaOgnie d2, DruzynaDwaOgnie d3, DruzynaDwaOgnie d4, List<Sedzia> s) // 2 sędziowie
        {
            this.d1 = d1;
            this.d2 = d2;
            this.d3 = d3;
            this.d4 = d4;
            this.s = s;
        }
        public override List<Druzyna> Start()
        {
            m1 = new MeczDwaOgnie(d1, d2, s[0]);
            m1.Play();
            m2 = new MeczDwaOgnie(d3, d4, s[1]);
            m2.Play();
            m3 = new MeczDwaOgnie((DruzynaDwaOgnie)m1.Zwyciezca, (DruzynaDwaOgnie)m2.Zwyciezca, s[0]);
            m4 = new MeczDwaOgnie((DruzynaDwaOgnie)m1.Przegrany, (DruzynaDwaOgnie)m2.Przegrany, s[1]);
            m3.Play();
            m4.Play();
            Drabina.Add((DruzynaDwaOgnie)m3.Zwyciezca);
            Drabina.Add((DruzynaDwaOgnie)m3.Przegrany);
            Drabina.Add((DruzynaDwaOgnie)m4.Zwyciezca);
            Drabina.Add((DruzynaDwaOgnie)m4.Przegrany);
            return Drabina;
        }
    }
}

