using Org.BouncyCastle.Utilities.Encoders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Proiect_BD
{
    public partial class FormEvent : Form
    {
        private readonly EventPage _parent;
        public string NumeEveniment, Locatie, Descriere, NumeCompanie, CUI, IBAN, Banca, NumarTelefon, Adresa, Mail, Fax, Indicatii;

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public DateTime Data;
        public int CapitalSocial, id;
        public FormEvent(EventPage parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        public void UpdateInfoEvent()
        {
            label1.Text = "Update Event";
            btnSaveEvent.Text = "Update";
            textNameEvent.Text = NumeEveniment;
            textLocationEvent.Text= Locatie;
            textDateEvent.Text = Data.ToString();
            textInfoEvent.Text= Descriere;
            textNameCompany.Text= NumeCompanie;
            textCUICompany.Text = CUI;
            textIBANCompany.Text = IBAN;
            textBankCompany.Text = Banca;
            textCapitalCompany.Text = CapitalSocial.ToString();
            textNrTelCompany.Text = NumarTelefon;
            textAdressComapny.Text = Adresa.ToString();
            textMailComapny.Text = Mail;
            textFaxCompany.Text = Fax;
            textOrientationCompany.Text = Indicatii;
        }

        public void SaveInfo()
        {
            label1.Text = "Add Model";
            btnSaveEvent.Text = "Save";
        }

        public void Clear()
        {
            textNameEvent.Text = textLocationEvent.Text = textDateEvent.Text = textInfoEvent.Text = textNameCompany.Text = textCUICompany.Text = textIBANCompany.Text = textBankCompany.Text = textCapitalCompany.Text = textNrTelCompany.Text = textAdressComapny.Text = textMailComapny.Text = textFaxCompany.Text = textOrientationCompany.Text = string.Empty;
        }

        private void Event_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveEvent_Click(object sender, EventArgs e)
        {
            if (textNameEvent.Text.Trim().Length < 1)
            {
                MessageBox.Show("Event name is Empty!");
                return;
            }
            if (textLocationEvent.Text.Trim().Length < 1)
            {
                MessageBox.Show("Event location is Empty!");
                return;
            }
            if (textDateEvent.Text.Trim().Length < 0)
            {
                MessageBox.Show("Event date is Empty!");
                return;
            }
            if (textInfoEvent.Text.Trim().Length < 1)
            {
                MessageBox.Show("Event description is Empty!");
                return;
            }
            if (textNameCompany.Text.Trim().Length < 1)
            {
                MessageBox.Show("Company name is Empty!");
                return;
            }
            if (textNrTelCompany.Text.Trim().Length < 1)
            {
                MessageBox.Show("Company telephone number is Empty!");
                return;
            }
            if (textAdressComapny.Text.Trim().Length < 0)
            {
                MessageBox.Show("Company adress is Empty!");
                return;
            }
           
            
            var date = DateTime.Parse(textDateEvent.Text.Trim());
            var capital = Int32.Parse(textCapitalCompany.Text.Trim());
            if (btnSaveEvent.Text == "Save")
            {
                Event ev = new Event(textNameEvent.Text.Trim(), textLocationEvent.Text.Trim(), date, textInfoEvent.Text.Trim(), textNameCompany.Text.Trim(), textCUICompany.Text.Trim(), textIBANCompany.Text.Trim(), textBankCompany.Text.Trim(), capital, textNrTelCompany.Text.Trim(), textAdressComapny.Text.Trim(), textMailComapny.Text.Trim(), textFaxCompany.Text.Trim(), textOrientationCompany.Text.Trim());
                DBAgentie.AddEvent(ev);
                Clear();
            }
            if (btnSaveEvent.Text == "Update")
            {
                Event ev = new Event(textNameEvent.Text.Trim(), textLocationEvent.Text.Trim(), date, textInfoEvent.Text.Trim(), textNameCompany.Text.Trim(), textCUICompany.Text.Trim(), textIBANCompany.Text.Trim(), textBankCompany.Text.Trim(), capital, textNrTelCompany.Text.Trim(), textAdressComapny.Text.Trim(), textMailComapny.Text.Trim(), textFaxCompany.Text.Trim(), textOrientationCompany.Text.Trim());
                DBAgentie.UpdateEvent(ev, id);
            }
            _parent.Display();
        }
    }
}
