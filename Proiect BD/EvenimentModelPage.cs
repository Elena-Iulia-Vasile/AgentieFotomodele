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
    public partial class EvenimentModelPage : Form
    {
        public EvenimentModelPage()
        {
            InitializeComponent();
        }

        public void Display()
        {
            DBAgentie.DisplayAndSearch("select E.Nume as NumeEveniment, E.Id AS EvenimentId, M.Id as ModelId, Data, Descriere, M.Nume as NumeModel, M.DataNasterii, M.Sex, M.NumarTelefon, M.Mail from EvenimentModel EM LEFT join Eveniment E ON EM.EvenimentId = E.Id LEFT JOIN Model M ON EM.ModelId = M.Id ", dataGridViewEM);
        }

        private void EvenimentModelPage_Shown(object sender, EventArgs e)
        {
            Display();
        }

        private void dataGridViewEM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Afist_Click(object sender, EventArgs e)
        {

        }

        private void EvenimentModelPage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'agentieFotomodeleDataSet5.Eveniment' table. You can move, or remove it, as needed.
            this.evenimentTableAdapter.Fill(this.agentieFotomodeleDataSet5.Eveniment);

        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCalculIntComplexa_Click(object sender, EventArgs e)
        {
            DBAgentie.DisplayAndSearch("SELECT year(Data) An, count(Id) NumarDeEvenimente FROM Eveniment GROUP BY year(Data) HAVING count(Id) = (SELECT max(D.NrEv) FROM (select (count(Id)) AS NrEv FROM Eveniment GROUP BY year(Data)) AS D)", dataGridView1);
        }

        private void btnBackHomePageFromEM_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.ShowDialog();
            this.Close();
        }
    }
}
