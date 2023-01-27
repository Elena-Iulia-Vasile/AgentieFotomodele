using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_BD
{
    public class Event
    {
        //din tabela evenimente
        public string NumeEveniment { get; set; }
        public string Locatie { get; set; }
        public DateTime Data { get; set; }
        public string Descriere { get; set; }
        

        //din tabela companie

        public string NumeCompanie { get; set; }
        public string CUI { get; set; }
        public string IBAN { get; set; }
        public string Banca { get; set; }
        public int CapitalSocial { get; set; }

        //din tabela contact Info
        public string NumarTelefon { get; set; }
        public string Adresa { get; set; }
        public string Mail { get; set; }
        public string Fax { get; set; }
        public string Indicatii { get; set; }

        public Event(string numeEveniment, string locatie, DateTime data, string descriere, string numeCompanie, string cUI, string iBAN, string banca, int capitalSocial, string numarTelefon, string adresa, string mail, string fax, string indicatii)
        {
            NumeEveniment = numeEveniment;
            Locatie = locatie;
            Data = data;
            Descriere = descriere;
            NumeCompanie = numeCompanie;
            CUI = cUI;
            IBAN = iBAN;
            Banca = banca;
            CapitalSocial = capitalSocial;
            NumarTelefon = numarTelefon;
            Adresa = adresa;
            Mail = mail;
            Fax = fax;
            Indicatii = indicatii;
        }
    }
}
