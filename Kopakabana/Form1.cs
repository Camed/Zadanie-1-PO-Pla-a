using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kopakabana
{
    public partial class Form1 : Form
    {
        private TurniejSiatkowka ts;
        private TurniejOgnie tog;
        private TurniejLina tl;
        public Form1()
        {
            InitializeComponent();
            try
            {
                FileManagement.Start();
                foreach(var x in Listy.DruzynySiatkowki)
                {
                    listSiatkowka.Items.Add(x.Nazwa);
                }
                foreach(var x in Listy.DruzynyLina)
                {
                    listLina.Items.Add(x.Nazwa);
                }
                foreach (var x in Listy.DruzynyDwaOgnie)
                {
                    listDwaOgnie.Items.Add(x.Nazwa);
                }
                foreach(var x in Listy.SedziowieLina)
                {
                    listSedziowieLina.Items.Add($"{x.Imie} {x.Nazwisko}");
                }
                foreach(var x in Listy.SedziowieDwaOgnie)
                {
                    listSedziowieOgnie.Items.Add($"{x.Imie} {x.Nazwisko}");
                }
                foreach(var x in Listy.SedziowieSiatkowki)
                {
                    listSedziowieSiatkowka.Items.Add($"{x.Imie} {x.Nazwisko}");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Wystapil blad: {ex.Message}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ShowPlazowaTeam_Click(object sender, EventArgs e)
        {
            if(listSiatkowka.SelectedIndex == -1)
            {
                MessageBox.Show("Najpierw wybierz druzyne do pokazania!", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                foreach(var x in Listy.DruzynySiatkowki)
                {
                    if(x.Nazwa == listSiatkowka.SelectedItem.ToString())
                    {
                        x.PokazDruzyne();
                        break;
                    }
                }
            }
        }

        private void saveChangesButton_Click(object sender, EventArgs e)
        {
            try
            {
                FileManagement.SaveToFiles();
                MessageBox.Show("Zmiany zapisano poprawnie!", "Zmiany", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystapil blad: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addSiatkowkaButton_Click(object sender, EventArgs e)
        {
            string text = siatkowkaNameBox.Text;
            if (text.Length == 0) MessageBox.Show("Wprowadz nazwe druzyny!");
            else
            {
                DruzynaSiatkowka ds = new DruzynaSiatkowka(text);
                Listy.DruzynySiatkowki.Add(ds);
                listSiatkowka.Items.Add(text);
                siatkowkaNameBox.Text = "";
            }
        }

        private void removeSiatkowkaButton_Click(object sender, EventArgs e)
        {
            if(listSiatkowka.SelectedIndex == -1)
            {
                MessageBox.Show("Najpierw wybierz druzyne do usuniecia!", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                for(int i = 0; i < Listy.DruzynySiatkowki.Count; i++)
                {
                    if(Listy.DruzynySiatkowki[i].Nazwa == listSiatkowka.SelectedItem.ToString())
                    {
                        Listy.DruzynySiatkowki.Remove(Listy.DruzynySiatkowki[i]);
                        listSiatkowka.Items.RemoveAt(listSiatkowka.SelectedIndex);
                        break;
                    }
                }
            }
        }

        private void addLinaButton_Click(object sender, EventArgs e)
        {
            string text = linaNameBox.Text;
            if (text.Length == 0) MessageBox.Show("Wprowadz nazwe druzyny!");
            else
            {
                DruzynaLina dl = new DruzynaLina(text);
                Listy.DruzynyLina.Add(dl);
                listLina.Items.Add(text);
                linaNameBox.Text = "";
            }
        }

        private void ShowLinaTeam_Click(object sender, EventArgs e)
        {
            if (listLina.SelectedIndex == -1)
            {
                MessageBox.Show("Najpierw wybierz druzyne do pokazania!", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                foreach (var x in Listy.DruzynyLina)
                {
                    if (x.Nazwa == listLina.SelectedItem.ToString())
                    {
                        x.PokazDruzyne();
                        break;
                    }
                }
            }
        }

        private void removeLinaButton_Click(object sender, EventArgs e)
        {
            if (listLina.SelectedIndex == -1)
            {
                MessageBox.Show("Najpierw wybierz druzyne do usuniecia!", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                for (int i = 0; i < Listy.DruzynyLina.Count; i++)
                {
                    if (Listy.DruzynyLina[i].Nazwa == listLina.SelectedItem.ToString())
                    {
                        Listy.DruzynyLina.Remove(Listy.DruzynyLina[i]);
                        listLina.Items.RemoveAt(listLina.SelectedIndex);
                        break;
                    }
                }
            }
        }

        private void addOgnieButton_Click(object sender, EventArgs e)
        {
            string text = ognieNameBox.Text;
            if (text.Length == 0) MessageBox.Show("Wprowadz nazwe druzyny!");
            else
            {
                DruzynaDwaOgnie ds = new DruzynaDwaOgnie(text);
                Listy.DruzynyDwaOgnie.Add(ds);
                listDwaOgnie.Items.Add(text);
                ognieNameBox.Text = "";
            }
        }

        private void ShowOgnieTeam_Click(object sender, EventArgs e)
        {
            if (listDwaOgnie.SelectedIndex == -1)
            {
                MessageBox.Show("Najpierw wybierz druzyne do pokazania!", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                foreach (var x in Listy.DruzynyDwaOgnie)
                {
                    if (x.Nazwa == listDwaOgnie.SelectedItem.ToString())
                    {
                        x.PokazDruzyne();
                        break;
                    }
                }
            }
        }

        private void removeOgnieButton_Click(object sender, EventArgs e)
        {
            if (listDwaOgnie.SelectedIndex == -1)
            {
                MessageBox.Show("Najpierw wybierz druzyne do usuniecia!", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                for (int i = 0; i < Listy.DruzynyDwaOgnie.Count; i++)
                {
                    if (Listy.DruzynyDwaOgnie[i].Nazwa == listDwaOgnie.SelectedItem.ToString())
                    {
                        Listy.DruzynyDwaOgnie.Remove(Listy.DruzynyDwaOgnie[i]);
                        listDwaOgnie.Items.RemoveAt(listDwaOgnie.SelectedIndex);
                        break;
                    }
                }
            }
        }

        private void addSedziaSiat_Click(object sender, EventArgs e)
        {
            string text = TextSedziowieSiatkowka.Text;
            if (text.Length == 0) MessageBox.Show("Wprowadz imie i nazwisko sedziego!");
            else
            {
                string name = text.Split()[0];
                string surname = text.Split()[1];
                SedziaType stype = SedziaType.Siatkowka;
                Listy.SedziowieSiatkowki.Add(new Sedzia(name, surname, stype));
                listSedziowieSiatkowka.Items.Add($"{name} {surname}");
                TextSedziowieSiatkowka.Text = "";
            }
        }

        private void addSedziaLina_Click(object sender, EventArgs e)
        {
            string text = TextSedziowieLina.Text;
            if (text.Length == 0) MessageBox.Show("Wprowadz imie i nazwisko sedziego!");
            else
            {
                string name = text.Split()[0];
                string surname = text.Split()[1];
                SedziaType stype = SedziaType.Lina;
                Listy.SedziowieLina.Add(new Sedzia(name, surname, stype));
                listSedziowieLina.Items.Add($"{name} {surname}");
                TextSedziowieLina.Text = "";
            }
        }

        private void addSedziaOgnie_Click(object sender, EventArgs e)
        {
            string text = TextSedziowieOgnie.Text;
            if (text.Length == 0) MessageBox.Show("Wprowadz imie i nazwisko sedziego!");
            else
            {
                string name = text.Split()[0];
                string surname = text.Split()[1];
                SedziaType stype = SedziaType.DwaOgnie;
                Listy.SedziowieDwaOgnie.Add(new Sedzia(name, surname, stype));
                listSedziowieOgnie.Items.Add($"{name} {surname}");
                TextSedziowieOgnie.Text = "";
            }
        }

        private void showSedziaSiat_Click(object sender, EventArgs e)
        {
            if (listSedziowieSiatkowka.SelectedIndex == -1)
            {
                MessageBox.Show("Najpierw wybierz sedziego do pokazania!", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                foreach (var x in Listy.SedziowieSiatkowki)
                {
                    string name = listSedziowieSiatkowka.SelectedItem.ToString().Split()[0];
                    string surname = listSedziowieSiatkowka.SelectedItem.ToString().Split()[1];
                    if (x.Imie == name && x.Nazwisko == surname)
                    {
                        x.PokazSedzie();
                        break;
                    }
                }
            }
        }

        private void showSedziaLina_Click(object sender, EventArgs e)
        {
            if (listSedziowieLina.SelectedIndex == -1)
            {
                MessageBox.Show("Najpierw wybierz sedziego do pokazania!", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                foreach (var x in Listy.SedziowieLina)
                {
                    string name = listSedziowieLina.SelectedItem.ToString().Split()[0];
                    string surname = listSedziowieLina.SelectedItem.ToString().Split()[1];
                    if (x.Imie == name && x.Nazwisko == surname)
                    {
                        x.PokazSedzie();
                        break;
                    }
                }
            }
        }

        private void showSedziaOgnie_Click(object sender, EventArgs e)
        {
            if (listSedziowieOgnie.SelectedIndex == -1)
            {
                MessageBox.Show("Najpierw wybierz sedziego do pokazania!", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                foreach (var x in Listy.SedziowieDwaOgnie)
                {
                    string name = listSedziowieOgnie.SelectedItem.ToString().Split()[0];
                    string surname = listSedziowieOgnie.SelectedItem.ToString().Split()[1];
                    if (x.Imie == name && x.Nazwisko == surname)
                    {
                        x.PokazSedzie();
                        break;
                    }
                }
            }
        }

        private void removeSedziaSiat_Click(object sender, EventArgs e)
        {
            if (listSedziowieSiatkowka.SelectedIndex == -1)
            {
                MessageBox.Show("Najpierw wybierz sedziego do usuniecia!", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                for (int i = 0; i < Listy.SedziowieSiatkowki.Count; i++)
                {
                    var imie = listSedziowieSiatkowka.SelectedItem.ToString().Split()[0];
                    var nazwisko = listSedziowieSiatkowka.SelectedItem.ToString().Split()[1];
                    if (Listy.SedziowieSiatkowki[i].Imie == imie && Listy.SedziowieSiatkowki[i].Nazwisko == nazwisko)
                    {
                        Listy.SedziowieSiatkowki.Remove(Listy.SedziowieSiatkowki[i]);
                        listSedziowieSiatkowka.Items.RemoveAt(listSedziowieSiatkowka.SelectedIndex);
                        break;
                    }
                }
            }
        }

        private void removeSedziaLina_Click(object sender, EventArgs e)
        {
            if (listSedziowieLina.SelectedIndex == -1)
            {
                MessageBox.Show("Najpierw wybierz sedziego do usuniecia!", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                for (int i = 0; i < Listy.SedziowieLina.Count; i++)
                {
                    var imie = listSedziowieLina.SelectedItem.ToString().Split()[0];
                    var nazwisko = listSedziowieLina.SelectedItem.ToString().Split()[1];
                    if (Listy.SedziowieLina[i].Imie == imie && Listy.SedziowieLina[i].Nazwisko == nazwisko)
                    {
                        Listy.SedziowieLina.Remove(Listy.SedziowieLina[i]);
                        listSedziowieLina.Items.RemoveAt(listSedziowieLina.SelectedIndex);
                        break;
                    }
                }
            }
        }

        private void removeSedziaOgnie_Click(object sender, EventArgs e)
        {
            if (listSedziowieOgnie.SelectedIndex == -1)
            {
                MessageBox.Show("Najpierw wybierz sedziego do usuniecia!", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                for (int i = 0; i < Listy.SedziowieDwaOgnie.Count; i++)
                {
                    var imie = listSedziowieOgnie.SelectedItem.ToString().Split()[0];
                    var nazwisko = listSedziowieOgnie.SelectedItem.ToString().Split()[1];
                    if (Listy.SedziowieDwaOgnie[i].Imie == imie && Listy.SedziowieDwaOgnie[i].Nazwisko == nazwisko)
                    {
                        Listy.SedziowieDwaOgnie.Remove(Listy.SedziowieDwaOgnie[i]);
                        listSedziowieOgnie.Items.RemoveAt(listSedziowieOgnie.SelectedIndex);
                        break;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Listy.SedziowieSiatkowki.Count < 6) MessageBox.Show($"Zbyt malo sedziow! Dodaj {6 - Listy.SedziowieSiatkowki.Count} sedziow/ego!");
            else
            {
                startSiatkowkaFinal.Enabled = true;
                ts = new TurniejSiatkowka(Listy.DruzynySiatkowki, Listy.SedziowieSiatkowki);
                ts.Start();
                foreach(var x in ts.mecze)
                {
                    historyTeamSiatkowka.Items.Add($"{x.Druzyna1.Nazwa}-{x.Druzyna2.Nazwa}");
                }

                foreach(var x in ts.Top4())
                {
                    teamListSiatkowka.Items.Add(x.Nazwa);
                }
            }
        }

        private void historyTeamSiatkowka_SelectedIndexChanged(object sender, EventArgs e)
        {
            string match = historyTeamSiatkowka.SelectedItem.ToString();
            string d1 = match.Split('-')[0];
            string d2 = match.Split('-')[1];

            foreach(var x in ts.mecze)
            {
                if(x.Druzyna1.Nazwa == d1 && x.Druzyna2.Nazwa == d2)
                {
                    wynikBox.Text = $"Zwyciezca: {x.Zwyciezca.Nazwa} {x.PunktyUzyskaneZwyciezcy}:{x.PunktyUtraconeZwyciezcy}\r\nSedzia glowny: {x.SedziaGlowny.Imie} {x.SedziaGlowny.Nazwisko}\r\nSedziowie boczni:{x.SedziaPomocniczy1.Imie} {x.SedziaPomocniczy1.Nazwisko} oraz {x.SedziaPomocniczy2.Imie} {x.SedziaPomocniczy2.Nazwisko}";
                }
            }
        }

        private void startSiatkowkaFinal_Click(object sender, EventArgs e)
        {
            var x = ts.Top4();
            FinSiatka finSiatka = new FinSiatka(x[0], x[1], x[2], x[3], Listy.SedziowieSiatkowki);
            var results = finSiatka.Start();
            finalySiatkaResults.Text = $"Zwyciezca:\r\n\t{results[0].Nazwa}\r\n\r\nDrugie miejsce:\r\n\t{results[1].Nazwa}\r\n\r\nTrzecie miejsce:\r\n\t{results[2].Nazwa}\r\n\r\nCzwarte miejsce:\r\n\t{results[3].Nazwa}";

        }
        private void startLina_Click(object sender, EventArgs e)
        {
            if (Listy.SedziowieLina.Count < 2) MessageBox.Show($"Zbyt malo sedziow! Dodaj {2 - Listy.SedziowieLina.Count} sedziow/ego!");
            else
            {
                startLinaFinal.Enabled = true;
                tl = new TurniejLina(Listy.DruzynyLina, Listy.SedziowieLina);
                tl.Start();
                foreach (var x in tl.mecze)
                {
                    historyTeamLina.Items.Add($"{x.Druzyna1.Nazwa}-{x.Druzyna2.Nazwa}");
                }

                foreach (var x in tl.Top4())
                {
                    teamListLina.Items.Add(x.Nazwa);
                }
            }
        }
        private void startOgnieTopka_Click(object sender, EventArgs e)
        {
                if (Listy.SedziowieDwaOgnie.Count < 2) MessageBox.Show($"Zbyt malo sedziow! Dodaj {2 - Listy.SedziowieDwaOgnie.Count} sedziow/ego!");
                else
                {
                    startOgnieFinal.Enabled = true;
                    tog = new TurniejOgnie(Listy.DruzynyDwaOgnie, Listy.SedziowieDwaOgnie);
                    tog.Start();
                    foreach (var x in tog.mecze)
                    {
                        historyTeamDwaOgnie.Items.Add($"{x.Druzyna1.Nazwa}-{x.Druzyna2.Nazwa}");
                    }

                    foreach (var x in tog.Top4())
                    {
                        teamListDwaOgnie.Items.Add(x.Nazwa);
                    }
                }
        }

        private void historyTeamDwaOgnie_SelectedIndexChanged(object sender, EventArgs e)
        {
            string match = historyTeamDwaOgnie.SelectedItem.ToString();
            string d1 = match.Split('-')[0];
            string d2 = match.Split('-')[1];

            foreach (var x in tog.mecze)
            {
                if (x.Druzyna1.Nazwa == d1 && x.Druzyna2.Nazwa == d2)
                {
                    wynikBoxOgnie.Text = $"Zwyciezca: {x.Zwyciezca.Nazwa} {x.PunktyUzyskaneZwyciezcy}:{x.PunktyUtraconeZwyciezcy}\r\nSedzia: {x.SedziaGlowny.Imie} {x.SedziaGlowny.Nazwisko}\r\n";
                }
            }
        }

        private void startOgnieFinal_Click(object sender, EventArgs e)
        {
            var x = tog.Top4();
            FinDwaOgnie finOgnie = new FinDwaOgnie(x[0], x[1], x[2], x[3], Listy.SedziowieDwaOgnie);
            var results = finOgnie.Start();
            finalyOgnieResults.Text = $"Zwyciezca:\r\n\t{results[0].Nazwa}\r\n\r\nDrugie miejsce:\r\n\t{results[1].Nazwa}\r\n\r\nTrzecie miejsce:\r\n\t{results[2].Nazwa}\r\n\r\nCzwarte miejsce:\r\n\t{results[3].Nazwa}";

        }



        private void historyTeamLina_SelectedIndexChanged(object sender, EventArgs e)
        {
            string match = historyTeamLina.SelectedItem.ToString();
            string d1 = match.Split('-')[0];
            string d2 = match.Split('-')[1];

            foreach (var x in tl.mecze)
            {
                if (x.Druzyna1.Nazwa == d1 && x.Druzyna2.Nazwa == d2)
                {
                    wynikBoxLina.Text = $"Zwyciezca: {x.Zwyciezca.Nazwa} {x.PunktyUzyskaneZwyciezcy}:{x.PunktyUtraconeZwyciezcy}\r\nSedzia glowny: {x.SedziaGlowny.Imie} {x.SedziaGlowny.Nazwisko}\r\n";
                }
            }
        }

        private void startLinaFinal_Click(object sender, EventArgs e)
        {
            var x = tl.Top4();
            FinPrzeciaganieLiny fl = new FinPrzeciaganieLiny(x[0], x[1], x[2], x[3], Listy.SedziowieLina);
            var results = fl.Start();
            finalyLinaResults.Text = $"Zwyciezca:\r\n\t{results[0].Nazwa}\r\n\r\nDrugie miejsce:\r\n\t{results[1].Nazwa}\r\n\r\nTrzecie miejsce:\r\n\t{results[2].Nazwa}\r\n\r\nCzwarte miejsce:\r\n\t{results[3].Nazwa}";
        }
    }
}
