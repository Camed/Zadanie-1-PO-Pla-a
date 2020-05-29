﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kopakabana
{
    class TurniejOgnie
    {
        public TurniejOgnie(List<Druzyna> druzyna, List<Sedzia> sedzie)
        {
            this.druzyna = druzyna;
            this.sedzie = sedzie;
        }
        public void Start()
        {
            for (int i = 0; i < druzyna.Count(); i++)
            {
                for (int j = i; j < druzyna.Count(); j++)
                {
                    mecze.Add(new MeczDwaOgnie((DruzynaDwaOgnie)druzyna[i], (DruzynaDwaOgnie)druzyna[j], sedzie[0]));
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