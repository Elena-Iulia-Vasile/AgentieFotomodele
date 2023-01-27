using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_BD
{
    public class Fotomodel
    {
        public string Nume { get; set; }
        public DateTime DataNasterii { get; set; }
        public string Sex { get; set; }
        public string NumarTelefon { get; set; }
        public string Mail {get; set; }
        
        //public Poza
        
        public string Inaltime { get; set; }
        public string Bust { get; set; }
        public string Talie { get; set; }
        public string Solduri { get; set; }
        public string Pantof { get; set; }
        public string MarimeHaine { get; set; }
        public string CuloarePar { get; set; }
        public string CuloareOchi { get; set; }

        public Fotomodel(string nume, DateTime dataNasterii, string sex, string numarTelefon, string mail, string inaltime, string bust, string talie, string solduri, string pantof, string marimeHaine, string culoarePar, string culoareOchi)
        {
            Nume = nume;
            DataNasterii = dataNasterii;
            Sex = sex;
            NumarTelefon = numarTelefon;
            Mail = mail;
            Inaltime = inaltime;
            Bust = bust;
            Talie = talie;
            Solduri = solduri;
            Pantof = pantof;
            MarimeHaine = marimeHaine;
            CuloarePar = culoarePar;
            CuloareOchi = culoareOchi;
        }
    }
}
