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
                    }
                }
            }
        }
    }
}
