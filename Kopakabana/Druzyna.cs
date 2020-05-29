using System.Windows.Forms;

namespace Kopakabana
{
    /// <summary>
    /// Klasa bazowa dla wszystkich druzyn
    /// </summary>
    public abstract class Druzyna
    {
        public virtual void PokazDruzyne()
        {
            MessageBox.Show("Oto druzyna!");
        }
    }


    /// <summary>
    /// Klasa dziedzicząca po klasie Druzyna, odpowiada druzynie siatkowki
    /// </summary>


    public class DruzynaSiatkowka : Druzyna
    {
        public override void PokazDruzyne()
        {
            MessageBox.Show("Oto druzyna siatkowki!");
        }
    }


    /// <summary>
    ///  Klasa dziedziczaca po klasie Druzyna, odpowiada druzynie w przeciaganie liny
    /// </summary>
    public class DruzynaLina : Druzyna
    {
        public override void PokazDruzyne()
        {
            MessageBox.Show("Oto druzyna w przeciagnie liny!");
        }
    }

    /// <summary>
    /// Klasa dziedziczaca po klasie Druzyna, odpowiada druzynie w dwa ognie
    /// </summary>
    public class DruzynaDwaOgnie : Druzyna
    {
        public override void PokazDruzyne()
        {
            MessageBox.Show("Oto druzyna w dwa ognie!");
        }
    }
}
