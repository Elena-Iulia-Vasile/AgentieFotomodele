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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void lblModel_Click(object sender, EventArgs e)
        {

        }

       

        private void CampagneSearch_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form campaniePage = new CampaniePage();
            campaniePage.ShowDialog();
        }

        private void modelSearch_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form modelPage = new  ModelPage();
            modelPage.ShowDialog();
        }

        private void EventSearch_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form eventPage = new EventPage();
            eventPage.ShowDialog();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'agentieFotomodeleDataSet.Model' table. You can move, or remove it, as needed.
            this.modelTableAdapter.Fill(this.agentieFotomodeleDataSet.Model);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AboutUs_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form eventModelPage = new EvenimentModelPage();
            eventModelPage.ShowDialog();
        }
    }
}
