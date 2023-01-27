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
    public partial class CampaniePage : Form
    {
        public CampaniePage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void Display()
        {
            DBAgentie.DisplayAndSearch("SELECT C.Id, M.Id as ModelId, C.Nume, M.Nume as NumeModel, Locatie, Data, Fotograf, Organizator FROM Campanie C left join Model M On C.ModelId = M.Id", dataGridViewCampanie);
        }
        private void CampaniePage_Shown(object sender, EventArgs e)
        {
            Display();
        }
        private void btnBackHomePage_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.ShowDialog();
            this.Close();
        }

        private void dataGridViewCampanie_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textSearchCampanieDupaModel_TextChanged(object sender, EventArgs e)
        {
            DBAgentie.DisplayAndSearch("SELECT C.Id, M.Id as ModelId, C.Nume, M.Nume as NumeModel, Locatie, Data, Fotograf, Organizator FROM Campanie C left join Model M On C.ModelId = M.Id WHERE  C.Nume LIKE '%+ textSearchCampanieDupaModel.Text + %' UNION SELECT C.Id, M.Id as ModelId, C.Nume, M.Nume as NumeModel, Locatie, Data, Fotograf, Organizator FROM Campanie C left join Model M On C.ModelId = M.Id WHERE M.Nume LIKE '%+ textSearchCampanieDupaModel.Text + %'", dataGridViewCampanie);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            DBAgentie.DisplayAndSearch("SELECT M.Nume from Model M join Campanie C on M.Id = C.ModelId group by M.Nume having Count(C.ModelId) < any(select Count(Id) / Count(M.Id) from Campanie)", dataGridViewCampanie);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnModele0Campanii_Click(object sender, EventArgs e)
        {
            DBAgentie.DisplayAndSearch("SELECT Nume FROM Model M WHERE NOT EXISTS(SELECT * FROM Campanie WHERE ModelId = M.Id)", dataGridViewCampanie);
        }

        private void CampaniePage_Load(object sender, EventArgs e)
        {

        }
    }
}
