using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proiect_BD
{
    public partial class EventPage : Form
    {
        FormEvent form;
        public EventPage()
        {
            InitializeComponent();
            form = new FormEvent(this);
        }

        public void Display()
        {
            DBAgentie.DisplayAndSearch("SELECT E.Id as Id,E.Nume, Locatie, Data, Descriere, C.Nume AS CompanieOrganizatoare, CI.NumarTelefon AS NumarTelefonCompanie, CI.Adresa AS AdresaCompaniei FROM Eveniment E left join Companie C on E.CompanieId = C.Id join ContactInfo CI on C.ContactInfoId = CI.Id", dataGridViewModelEvent);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void EventPage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'agentieFotomodeleDataSet3.Eveniment' table. You can move, or remove it, as needed.
            this.evenimentTableAdapter1.Fill(this.agentieFotomodeleDataSet3.Eveniment);
            // TODO: This line of code loads data into the 'agentieFotomodeleDataSet2.Eveniment' table. You can move, or remove it, as needed.
            this.evenimentTableAdapter.Fill(this.agentieFotomodeleDataSet2.Eveniment);

        }

        private void AddEvent_Click(object sender, EventArgs e)
        {
            form.Clear();
            form.SaveInfo();
            FormEvent formEvent = new FormEvent(this);
            formEvent.ShowDialog();
            this.Hide();
        }


        private void EventPage_Shown_1(object sender, EventArgs e)
        {
            Display();
        }

        private void textSearchEvent_TextChanged(object sender, EventArgs e)
        {
            DBAgentie.DisplayAndSearch("SELECT E.Id as Id, E.Nume, Locatie, Data, Descriere, C.Nume AS CompanieOrganizatoare, CI.NumarTelefon AS NumarTelefonCompanie, CI.Adresa AS AdresaCompaniei FROM Eveniment E left join Companie C on E.CompanieId = C.Id join ContactInfo CI on C.ContactInfoId = CI.Id WHERE E.Nume LIKE '%" + textSearchEvent.Text + "%'", dataGridViewModelEvent);
        }

        private void dataGridViewModel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridViewModel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 8)
            {
                //Edit
                form.Clear();
                form.id = Int16.Parse(dataGridViewModelEvent.Rows[e.RowIndex].Cells[0].Value.ToString());
                form.NumeEveniment = dataGridViewModelEvent.Rows[e.RowIndex].Cells[1].Value.ToString();
                form.Locatie = dataGridViewModelEvent.Rows[e.RowIndex].Cells[2].Value.ToString();
                form.Data = DateTime.Parse(dataGridViewModelEvent.Rows[e.RowIndex].Cells[3].Value.ToString());
                form.Descriere = dataGridViewModelEvent.Rows[e.RowIndex].Cells[4].Value.ToString();
                form.NumeCompanie = dataGridViewModelEvent.Rows[e.RowIndex].Cells[5].Value.ToString();
                form.NumarTelefon = dataGridViewModelEvent.Rows[e.RowIndex].Cells[6].Value.ToString();
                form.Adresa = dataGridViewModelEvent.Rows[e.RowIndex].Cells[7].Value.ToString();

                form.UpdateInfoEvent();

                form.ShowDialog();

                return;
            }
            if (e.ColumnIndex == 9)
            {
                //Delete
                if (MessageBox.Show("Are you sure you want to delete that event record?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DBAgentie.DeleteEvent(Int32.Parse(dataGridViewModelEvent.Rows[e.RowIndex].Cells[0].Value.ToString()));
                    Display();
                }
                return;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBackHomePage_Click(object sender, EventArgs e)
        {
            form.Clear();
            form.SaveInfo();
            HomePage homePage = new HomePage();
            homePage.ShowDialog();
            this.Hide();
            this.Close();
        }
    }
}
