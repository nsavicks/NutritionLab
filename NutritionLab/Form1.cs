using NutritionLab.Source.Model;
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
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Serialization;

namespace NutritionLab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            OsveziListuNamirnica();
        }

        private void OsveziListuNamirnica()
        {
            LinkedList<Namirnica> l = DatabaseManagement.DohvatiSveNamirnice(tbTraziNamirnice.Text, comboBox2.Text);
            int i = 0;

            listViewNamirnice.Items.Clear();

            foreach (Namirnica n in l)
            {
                listViewNamirnice.Items.Add(n.Id.ToString());
                listViewNamirnice.Items[i].SubItems.Add(n.Naziv);
                listViewNamirnice.Items[i].SubItems.Add(n.Grupa);
                listViewNamirnice.Items[i].SubItems.Add(n.UgljeniHidrati.ToString());
                listViewNamirnice.Items[i].SubItems.Add(n.Masti.ToString());
                listViewNamirnice.Items[i].SubItems.Add(n.Proteini.ToString());
                listViewNamirnice.Items[i].SubItems.Add(n.Kalorije.ToString());
                i++;
            }
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            OsveziListuNamirnica();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string naziv = tbNazivNamirnice.Text;
            string grupa = comboBox3.Text;
            double uh = double.Parse(tbUHNamirnice.Text);
            double mas = double.Parse(tbMasNamirnice.Text);
            double pro = double.Parse(tbProNamirnice.Text);
            double kal = double.Parse(textBox1.Text);

            Namirnica n = new Namirnica()
            {
                Naziv = naziv,
                Grupa = grupa,
                UgljeniHidrati = uh,
                Masti = mas,
                Proteini = pro,
                Kalorije = kal,
            };

            DatabaseManagement.DodajNamirnicu(n);
            OsveziListuNamirnica();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listViewNamirnice.SelectedItems)
            {
                int id = int.Parse(item.Text);
                DatabaseManagement.ObrisiNamirnicu(id);
            }
            OsveziListuNamirnica();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listViewNamirnice.SelectedItems)
            {
                int Id = int.Parse(item.Text);
                string Naziv = item.SubItems[1].Text;
                string Grupa = item.SubItems[2].Text;
                double UH = double.Parse(item.SubItems[3].Text);
                double MA = double.Parse(item.SubItems[4].Text);
                double PR = double.Parse(item.SubItems[5].Text);
                double kal = double.Parse(item.SubItems[6].Text);

                Namirnica n = new Namirnica(Id)
                {
                    Naziv = Naziv,
                    Grupa = Grupa,
                    UgljeniHidrati = UH,
                    Masti = MA,
                    Proteini = PR,
                    Kalorije = kal
                };

                int kol = (int) numericUpDown1.Value;

                Jelo.TrenutnoJelo.DodajNamirnicu(n, kol);            
            }

            PrikaziTrenutnoJelo();
        }

        private void OsveziChart(Chart ch, double uh, double mas, double pro)
        {
            ch.Series["s1"].Points.Clear();
            ch.Series["s1"].IsValueShownAsLabel = true;
            ch.Series["s1"].Points.AddXY("Ugljeni hidrati", uh);
            ch.Series["s1"].Points.AddXY("Masti", mas);
            ch.Series["s1"].Points.AddXY("Proteini", pro);
        }

        private void PrikaziTrenutnoJelo()
        {
            listView1.Items.Clear();

            for(int i = 0; i < Jelo.TrenutnoJelo.Namirnice.Count; i++)
            {
                Namirnica n = Jelo.TrenutnoJelo.Namirnice.ElementAt<Namirnica>(i);
                int kol = Jelo.TrenutnoJelo.Kolicine.ElementAt<int>(i);
                string[] row = { n.Id.ToString(), n.Naziv, n.Grupa, (n.UgljeniHidrati*kol/100.0).ToString(), (n.Masti*kol/100.0).ToString(), (n.Proteini*kol/100.0).ToString(), (n.Kalorije * kol / 100.0).ToString(), kol.ToString() };
                var listViewItem = new ListViewItem(row);
                listView1.Items.Add(listViewItem);
            }

            textBox3.Text = Jelo.TrenutnoJelo.Naziv;
            comboBox1.Text = Jelo.TrenutnoJelo.Tip.ToString();
            label1.Text = Jelo.TrenutnoJelo.Kalorije.ToString() + " kCal";

            OsveziChart(chart1, Jelo.TrenutnoJelo.UgljeniHidrati, Jelo.TrenutnoJelo.Masti, Jelo.TrenutnoJelo.Proteini);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                int ind = item.Index;
                Jelo.TrenutnoJelo.UkloniNamirnicu(ind);
                item.Remove();
            }

            PrikaziTrenutnoJelo();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "XML File|*.xml";
            saveFileDialog1.Title = "Sacuvaj jelo";
            saveFileDialog1.ShowDialog();
            
            if (saveFileDialog1.FileName != "")
            {
                FileStream fs = (FileStream) saveFileDialog1.OpenFile();
                XmlSerializer writer = new XmlSerializer(typeof(Jelo));
                writer.Serialize(fs, Jelo.TrenutnoJelo);
                fs.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "XML File|*.xml";
            openFileDialog1.Title = "Izaberi jelo";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                XmlSerializer reader = new XmlSerializer(typeof(Jelo));
                StreamReader sr = new StreamReader(openFileDialog1.FileName);

                Jelo.TrenutnoJelo = (Jelo)reader.Deserialize(sr);

                PrikaziTrenutnoJelo();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            OsveziListuNamirnica();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Jelo.TrenutnoJelo.Tip = comboBox1.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Jelo.TrenutnoJelo = new Jelo("Naziv obroka...", comboBox1.Text);
            PrikaziTrenutnoJelo();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Jelo.TrenutnoJelo.Naziv = textBox3.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int ind = tabControl1.SelectedIndex;

            Dijeta.TrenutnaDijeta.dodaj(ind, Jelo.TrenutnoJelo);

            OsveziPrikazDijete(ind);
        }

        private ListView DohvatiListView(int ind)
        {
            ListView lv = null;
            switch (ind)
            {
                case 0: lv = listViewPon; break;
                case 1: lv = listViewUto; break;
                case 2: lv = listViewSre; break;
                case 3: lv = listViewCet; break;
                case 4: lv = listViewPet; break;
                case 5: lv = listViewSub; break;
                case 6: lv = listViewNed; break;
            }

            return lv;
        }

        private Label DohvatiLabelu(int ind)
        {
            Label lb = null;

            switch (ind)
            {
                case 0: lb = lbPon; break;
                case 1: lb = lbUto; break;
                case 2: lb = lbSre; break;
                case 3: lb = lbCet; break;
                case 4: lb = lbPet; break;
                case 5: lb = lbSub; break;
                case 6: lb = lbNed; break;
            }

            return lb;
        }

        private void OsveziPrikazDijete(int ind)
        {
            Label lb = DohvatiLabelu(ind);
            ListView lv = DohvatiListView(ind);

            lv.Items.Clear();

            foreach (Jelo j in Dijeta.TrenutnaDijeta.Jela[ind])
            {
                string[] row = { j.Naziv, j.Tip, j.Kolicina.ToString(), j.UgljeniHidrati.ToString(), j.Masti.ToString(), j.Proteini.ToString(), j.Kalorije.ToString() };
                var listViewItem = new ListViewItem(row);
                lv.Items.Add(listViewItem);
            }

            lb.Text = Dijeta.TrenutnaDijeta.dohvatiKalorije(ind).ToString() + " kCal";

            int kolicina = Dijeta.TrenutnaDijeta.dohvatiKolicinu(ind);

            double procUh = (Dijeta.TrenutnaDijeta.dohvatiUH(ind) / (double) kolicina) * 100.0;
            double procMas = (Dijeta.TrenutnaDijeta.dohvatiMasti(ind) / (double)kolicina) * 100.0;
            double procPro = (Dijeta.TrenutnaDijeta.dohvatiProteine(ind) / (double)kolicina) * 100.0;

            procUh = Math.Round(procUh, 1);
            procMas = Math.Round(procMas, 1);
            procPro = Math.Round(procPro, 1);

            OsveziChart(chart2, procUh, procMas, procPro);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            OsveziPrikazDijete(tabControl1.SelectedIndex);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int ind = tabControl1.SelectedIndex;

            ListView lv = DohvatiListView(ind);

            foreach (ListViewItem item in lv.SelectedItems)
            {
                Dijeta.TrenutnaDijeta.ukloni(ind, item.Index);
                item.Remove();
            }

            OsveziPrikazDijete(ind);
        }
    }
}
