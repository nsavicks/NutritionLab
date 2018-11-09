using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutritionLab.Source.Model
{
    public class Dijeta
    {
        public static Dijeta TrenutnaDijeta
        {
            get; set;
        }

        public string Naziv
        {
            get; set;
        }

        public List<Jelo>[] Jela
        {
            get; set;
        } 

        static Dijeta()
        {
            TrenutnaDijeta = new Dijeta();
        }

        public Dijeta(string naziv = "")
        {
            this.Naziv = naziv;
            this.Jela = new List<Jelo>[7];
            for (int i = 0; i < 7; i++) this.Jela[i] = new List<Jelo>();
        }

        public void dodaj(int i,Jelo j)
        {
            this.Jela[i].Add((Jelo)j.Clone());
        }

        public void ukloni(int i, int j)
        {
            this.Jela[i].RemoveAt(j);
        }

        public double dohvatiUH(int i)
        {
            double sol = 0;

            foreach (Jelo j in this.Jela[i])
            {
                sol += j.UgljeniHidrati;
            }

            return sol;
        }

        public double dohvatiMasti(int i)
        {
            double sol = 0;

            foreach (Jelo j in this.Jela[i])
            {
                sol += j.Masti;
            }

            return sol;
        }

        public double dohvatiProteine(int i)
        {
            double sol = 0;

            foreach (Jelo j in this.Jela[i])
            {
                sol += j.Proteini;
            }

            return sol;
        }

        public double dohvatiKalorije(int i)
        {
            double sol = 0;

            foreach (Jelo j in this.Jela[i])
            {
                sol += j.Kalorije;
            }

            return sol;
        }

        public int dohvatiKolicinu(int i)
        {
            int sol = 0;

            foreach (Jelo j in this.Jela[i])
            {
                sol += j.Kolicina;
            }

            return sol;
        }
    }
}
