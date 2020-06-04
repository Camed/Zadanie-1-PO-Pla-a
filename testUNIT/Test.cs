using Kopakabana;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace testUNIT
{
    public class TestClass
    {
        [Theory]
        [InlineData("Miłośnicy Bigosu", true)]
        public void CheckIFDruzynaSiatkaWasAdded(string name, bool checkif)
        {
            bool checkact = false;
            DruzynaSiatkowka t = new DruzynaSiatkowka(name);
            List<DruzynaSiatkowka> check = new List<DruzynaSiatkowka>
            {
                t
            };
            if (check.Count == 1)
            {
                checkact = true;
            }
            Assert.Equal(checkif, checkact);
        }
        [Theory]
        [InlineData("Miłośnicy Bigosu", true)]
        public void CheckIFDruzynaLinaWasAdded(string name, bool checkif)
        {
            bool checkact = false;
            DruzynaLina t = new DruzynaLina(name);
            List<DruzynaLina> check = new List<DruzynaLina>
            {
                t
            };
            if (check.Count == 1)
            {
                checkact = true;
            }
            Assert.Equal(checkif, checkact);
        }
        [Theory]
        [InlineData("Miłośnicy Bigosu", true)]
        public void CheckIFDruzynaDwaOgnieWasAdded(string name, bool checkif)
        {
            bool checkact = false;
            DruzynaDwaOgnie t = new DruzynaDwaOgnie(name);
            List<DruzynaDwaOgnie> check = new List<DruzynaDwaOgnie>
            {
                t
            };
            if (check.Count == 1)
            {
                checkact = true;
            }
            Assert.Equal(checkif, checkact);
        }
    }
}
