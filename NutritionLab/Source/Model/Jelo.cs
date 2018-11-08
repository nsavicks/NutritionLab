using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NutritionLab.Source.Model
{
    [Serializable, XmlRoot("Jelo")]
    public class Jelo
    {    
        public static Jelo TrenutnoJelo { get; set; }

        [XmlAttribute(AttributeName = "Tip")]
        public string Tip { get; set; }

        [XmlElement(ElementName = "Namirnice")]
        public List<Namirnica> Namirnice { get; set; }

        [XmlAttribute(AttributeName = "Kolicine")]
        public List<int> Kolicine { get; set; }

        public double UgljeniHidrati
        {
            get
            {
                double sol = 0;
                for (int i = 0; i < this.Namirnice.Count; i++)
                {
                    Namirnica n = this.Namirnice.ElementAt<Namirnica>(i);
                    int kol = this.Kolicine.ElementAt<int>(i);
                    sol += n.UgljeniHidrati * ((double) kol / 100.0);
                }

                return sol;
            }
        }

        public double Masti
        {
            get
            {
                double sol = 0;
                for (int i = 0; i < this.Namirnice.Count; i++)
                {
                    Namirnica n = this.Namirnice.ElementAt<Namirnica>(i);
                    int kol = this.Kolicine.ElementAt<int>(i);
                    sol += n.Masti * ((double)kol / 100.0);
                }

                return sol;
            }
        }

        public double Proteini
        {
            get
            {
                double sol = 0;
                for (int i = 0; i < this.Namirnice.Count; i++)
                {
                    Namirnica n = this.Namirnice.ElementAt<Namirnica>(i);
                    int kol = this.Kolicine.ElementAt<int>(i);
                    sol += n.Proteini * ((double)kol / 100.0);
                }

                return sol;
            }
        }

        public double Kalorije
        {
            get
            {
                double sol = 0;
                for (int i = 0; i < this.Namirnice.Count; i++)
                {
                    Namirnica n = this.Namirnice.ElementAt<Namirnica>(i);
                    int kol = this.Kolicine.ElementAt<int>(i);
                    sol += n.Kalorije * ((double)kol / 100.0);
                }

                return sol;
            }
        }

        static Jelo()
        {
            TrenutnoJelo = new Jelo();
        }

        public Jelo()
        {
            this.Tip = "Dorucak";
            this.Namirnice = new List<Namirnica>();
            this.Kolicine = new List<int>();
        }

        public Jelo(string tip)
        {
            this.Tip = tip;
            this.Namirnice = new List<Namirnica>();
            this.Kolicine = new List<int>();
        }

        public void DodajNamirnicu(Namirnica n, int kol)
        {
            this.Namirnice.Add(n);
            this.Kolicine.Add(kol);
        }

        public void UkloniNamirnicu(Namirnica n)
        {
            int ind = this.Namirnice.FindIndex(x => x.Id == n.Id);
            this.Namirnice.RemoveAt(ind);
            this.Kolicine.RemoveAt(ind);   
        }

        public void UkloniNamirnicu(int ind)
        {
            this.Namirnice.RemoveAt(ind);
            this.Kolicine.RemoveAt(ind);
        }


        /// <summary>
        ///  Enum za tipove jela
        /// </summary>
        public enum TipJela
        {
            Dorucak,

            Rucak,

            Vecera,

            Uzina
        }
    }
}
