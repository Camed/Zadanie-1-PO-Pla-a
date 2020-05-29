using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kopakabana
{
    public abstract class Mecz // bruh
    {
        public Druzyna Druzyna1 { get; protected set; }
        public Druzyna Druzyna2 { get; protected set; }
        public Druzyna Zwyciezca { get; protected set; }
        
        public Sedzia SedziaGlowny { get; protected set; }
        public int PunktyUzyskaneZwyciezcy { get; protected set; }
        public int PunktyUtraconeZwyciezcy { get; protected set; }
        public abstract void Play();
    }

    public class MeczSiatkowki : Mecz
    {
        public Sedzia SedziaPomocniczy1 { get; private set; }
        public Sedzia SedziaPomocniczy2 { get; private set; }
        public MeczSiatkowki(DruzynaSiatkowka d1, DruzynaSiatkowka d2, Sedzia sglowny, Sedzia shelp1, Sedzia shelp2)
        {
            Druzyna1 = d1;
            Druzyna2 = d2;
            SedziaGlowny = sglowny;
            SedziaPomocniczy1 = shelp1;
            SedziaPomocniczy2 = shelp2;
        }

        public override void Play()
        {
            Random r = new Random();
            int x = r.Next() % 2;
            if(x == 0)
            {
                Zwyciezca = Druzyna1;
                PunktyUzyskaneZwyciezcy = 25;
                PunktyUtraconeZwyciezcy = r.Next() % 24;
            }
            else
            {
                Zwyciezca = Druzyna2;
                PunktyUzyskaneZwyciezcy = 25;
                PunktyUtraconeZwyciezcy = r.Next() % 24;
            }
        }
    }
    public class MeczPrzeciaganieLiny : Mecz
    {
        public MeczPrzeciaganieLiny(DruzynaLina d1, DruzynaLina d2, Sedzia sglowny)
        {
            Druzyna1 = d1;
            Druzyna2 = d2;
            SedziaGlowny = sglowny;
        }
        public override void Play()
        {
            Random r = new Random();
            int x = r.Next() % 2;
            if (x == 0)
            {
                Zwyciezca = Druzyna1;
                PunktyUzyskaneZwyciezcy = 3;
                PunktyUtraconeZwyciezcy = r.Next() % 3;
            }
            else
            {
                Zwyciezca = Druzyna2;
                PunktyUzyskaneZwyciezcy = 3;
                PunktyUtraconeZwyciezcy = r.Next() % 3;
            }
        }
    }
    public class MeczDwaOgnie : Mecz
    {
        public MeczDwaOgnie(DruzynaDwaOgnie d1, DruzynaDwaOgnie d2, Sedzia sglowny)
        {
            Druzyna1 = d1;
            Druzyna2 = d2;
            SedziaGlowny = sglowny;
        }
        public override void Play()
        {
            Random r = new Random();
            int x = r.Next() % 2;
            if (x == 0)
            {
                Zwyciezca = Druzyna1;
                PunktyUzyskaneZwyciezcy = 20;
                PunktyUtraconeZwyciezcy = r.Next() % 20;
            }
            else
            {
                Zwyciezca = Druzyna2;
                PunktyUzyskaneZwyciezcy = 20;
                PunktyUtraconeZwyciezcy = r.Next() % 20;
            }
        }
    }
}
