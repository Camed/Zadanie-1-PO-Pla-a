using System.Windows.Forms;

namespace Kopakabana
{
    /// <summary>
    /// Klasa bazowa dla wszystkich druzyn
    /// </summary>
    public abstract class Druzyna
    {
        public string Nazwa { get; protected set; }
        
        public Druzyna(string nazwa)
        {
            Nazwa = nazwa;
        }
        public virtual void PokazDruzyne()
        {
            MessageBox.Show($"Oto druzyna {Nazwa}!");
        }
    }


    /// <summary>
    /// Klasa dziedzicząca po klasie Druzyna, odpowiada druzynie siatkowki
    /// </summary>

    public class DruzynaSiatkowka : Druzyna
    {
        public DruzynaSiatkowka(string nazwa) : base(nazwa)
        {
            Nazwa = nazwa;
        }
        public override void PokazDruzyne()
        {
            MessageBox.Show($"Oto druzyna siatkowki o nazwie {Nazwa}!");
        }
    }


    /// <summary>
    ///  Klasa dziedziczaca po klasie Druzyna, odpowiada druzynie w przeciaganie liny
    /// </summary>
    public class DruzynaLina : Druzyna
    {
        public DruzynaLina(string nazwa) : base(nazwa)
        {
            Nazwa = nazwa;
        }
        public override void PokazDruzyne()
        {
            MessageBox.Show($"Oto druzyna w przeciagnie liny o nazwie {Nazwa}!");
        }
    }

    /// <summary>
    /// Klasa dziedziczaca po klasie Druzyna, odpowiada druzynie w dwa ognie
    /// </summary>
    public class DruzynaDwaOgnie : Druzyna
    {
        public DruzynaDwaOgnie(string nazwa) : base(nazwa)
        {
            Nazwa = nazwa;
        }
        public override void PokazDruzyne()
        {
            MessageBox.Show($"Oto druzyna w dwa ognie o nazwie {Nazwa}!");
        }
    }
}
