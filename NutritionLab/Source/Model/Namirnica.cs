using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NutritionLab.Source.Model
{
    [Serializable, XmlRoot("Namirnica")]
    public class Namirnica
    {
        private static int genID = 0;

        [XmlAttribute(AttributeName = "Id")]
        public int Id { get; set; }

        [XmlAttribute(AttributeName = "Naziv")]
        public string Naziv { get; set; }

        [XmlAttribute(AttributeName = "Grupa")]
        public string Grupa { get; set; }

        [XmlAttribute(AttributeName = "UgljeniHidrati")]
        public double UgljeniHidrati { get; set; }

        [XmlAttribute(AttributeName = "Masti")]
        public double Masti { get; set; }

        [XmlAttribute(AttributeName = "Proteini")]
        public double Proteini { get; set; }

        [XmlAttribute(AttributeName = "Kalorije")]
        public double Kalorije { get; set; }

        public Namirnica()
        {
            this.Id = ++genID;
            this.Naziv = "";
            this.Grupa = "";
            this.UgljeniHidrati = 0;
            this.Masti = 0;
            this.Proteini = 0;
            this.Kalorije = 0;
        }

        public Namirnica(int id)
        {
            this.Id = id;        
            this.Naziv = "";
            this.Grupa = "";
            this.UgljeniHidrati = 0;
            this.Masti = 0;
            this.Proteini = 0;
            this.Kalorije = 0;
        }

        static Namirnica()
        {
            genID = DatabaseManagement.DohvatiMaxIdNamirnice();
        }
    }
}
