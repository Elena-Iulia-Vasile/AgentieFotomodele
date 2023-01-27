using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_BD
{
    public partial class FormModel : Form
    {
        private readonly ModelPage _parent;
        public string name, sex, mail, numarTelefon, culoareOchi, culoarePar, marimeHaine;
        public DateTime dataNasterii;
        public int id, inaltime, solduri, bust, talie, pantof;

        private void textBirthModel_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBackModelPage_Click(object sender, EventArgs e)
        {
            ModelPage modelPage = new ModelPage();
            modelPage.ShowDialog();
            this.Hide();
            this.Close();
        }

        private void FormModel_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public FormModel(ModelPage parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        public void UpdateInfoModel()
        {
            label1.Text = "Update Model";
            CreateModelEfectiv.Text = "Update";
            textNameModel.Text = name; 
            textBirthModel.Text = dataNasterii.ToString();
            textSexModel.Text = sex.ToString();
            textNrTelModel.Text = numarTelefon.ToString();
            textMailModel.Text = mail;
            textInaltimeModel.Text = inaltime.ToString();
            textBustModel.Text = bust.ToString();
            textTalieModel.Text = talie.ToString();
            textSolduriModel.Text = solduri.ToString();
            textPantofModel.Text = pantof.ToString();
            textMarimeModel.Text = marimeHaine;
            textCuloareParModel.Text = culoarePar; 
            textCuloareOchiModel.Text = culoareOchi;
        }

        public void SaveInfo()
        {
            label1.Text = "Add Model";
            CreateModelEfectiv.Text = "Save";
        }

        public void Clear()
        {
            textNameModel.Text = textBirthModel.Text = textSexModel.Text = textNrTelModel.Text = textMailModel.Text = textInaltimeModel.Text = textBustModel.Text = textTalieModel.Text = textSolduriModel.Text = textPantofModel.Text = textMarimeModel.Text = textCuloareParModel.Text = textCuloareOchiModel.Text = string.Empty;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CreateModelEfectiv_Click(object sender, EventArgs e)
        {
            if(textNameModel.Text.Trim().Length < 1) 
            {
                MessageBox.Show("Model Name is Empty!");
                return;
            }
            if (textBirthModel.Text.Trim().Length < 1)
            {
                MessageBox.Show("Model Birth is Empty!");
                return;
            }
            if (textSexModel.Text.Trim().Length < 0)
            {
                MessageBox.Show("Model Sex is Empty!");
                return;
            }
            if (textNrTelModel.Text.Trim().Length < 1)
            {
                MessageBox.Show("Model Phone Number is Empty!");
                return;
            }
            if (textInaltimeModel.Text.Trim().Length < 1)
            {
                MessageBox.Show("Model Height is Empty!");
                return;
            }
            if (textBustModel.Text.Trim().Length < 1)
            {
                MessageBox.Show("Model Bust is Empty!");
                return;
            }
            if (textSolduriModel.Text.Trim().Length < 1)
            {
                MessageBox.Show("Model Hips is Empty!");
                return;
            }
            var dateBirth = DateTime.Parse(textBirthModel.Text.Trim());
            if(CreateModelEfectiv.Text == "Save")
            {
                Fotomodel model = new Fotomodel(textNameModel.Text.Trim(), dateBirth, textSexModel.Text.Trim(), textNrTelModel.Text.Trim(), textMailModel.Text.Trim(), textInaltimeModel.Text.Trim(), textBustModel.Text.Trim(), textTalieModel.Text.Trim(), textSolduriModel.Text.Trim(), textPantofModel.Text.Trim(), textMarimeModel.Text.Trim(), textCuloareParModel.Text.Trim(), textCuloareOchiModel.Text.Trim());
                DBAgentie.AddFotomodel(model);
                Clear();
            }
            if(CreateModelEfectiv.Text == "Update")
            {
                Fotomodel model = new Fotomodel(textNameModel.Text.Trim(), dateBirth, textSexModel.Text.Trim(), textNrTelModel.Text.Trim(), textMailModel.Text.Trim(), textInaltimeModel.Text.Trim(), textBustModel.Text.Trim(), textTalieModel.Text.Trim(), textSolduriModel.Text.Trim(), textPantofModel.Text.Trim(), textMarimeModel.Text.Trim(), textCuloareParModel.Text.Trim(), textCuloareOchiModel.Text.Trim());
                DBAgentie.UpdateFotomodel(model, id);
            }
            _parent.Display();
        }
    }
}
