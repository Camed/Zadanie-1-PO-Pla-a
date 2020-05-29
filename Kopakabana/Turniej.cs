﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kopakabana
{
    class Turniej
    {
        private List<Mecz> mecze = new List<Mecz>();
        private List<Druzyna> druzyna = new List<Druzyna>();
        private List<Sedzia> sedzie = new List<Sedzia>();

        public Turniej(List<Druzyna> druzyna, List<Sedzia> sedzie)
        {
            this.druzyna = druzyna;
            this.sedzie = sedzie;
        }
        public void Start()
        {
            for (int i = 0; i < druzyna.Count(); i++)
            {
                for(int j = i; j < druzyna.Count(); j++)
                {
                    if(druzyna is DruzynaSiatkowka)
                    {
                        mecze.Add(new MeczSiatkowki((DruzynaSiatkowka)druzyna[i], (DruzynaSiatkowka)druzyna[j], sedzie[0], sedzie[1], sedzie[2]));
                    }
                    else if(druzyna is DruzynaDwaOgnie)
                    {
                        mecze.Add(new MeczDwaOgnie((DruzynaDwaOgnie)druzyna[i], (DruzynaDwaOgnie)druzyna[j], sedzie[0]));
                    }
                    else
                        mecze.Add(new MeczPrzeciaganieLiny((DruzynaLina)druzyna[i], (DruzynaLina)druzyna[j], sedzie[0]));
                }
            }
            foreach (var x in mecze)
                x.Play();
        }
        public List<Druzyna> Top4()
        {

            return druzyna;
        }
    }
}
