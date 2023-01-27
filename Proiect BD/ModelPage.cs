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
    public partial class ModelPage : Form
    {
        FormModel form;

        public ModelPage()
        {
            InitializeComponent();
            form = new FormModel(this);
        }

        public void Display()
        {
            DBAgentie.DisplayAndSearch("SELECT M.Id, Nume, DataNasterii, Sex, NumarTelefon, Inaltime, Bust, Solduri, Poza FROM Model M left join Caracteristici C On M.CaracteristiciId = C.Id", dataGridViewModel);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void CreateModel_Click(object sender, EventArgs e)
        {
            form.Clear();
            form.SaveInfo();
            FormModel formModel = new FormModel(this);
            formModel.ShowDialog();
            this.Hide();
        }

        private void ModelPage_Shown(object sender, EventArgs e)
        {
            Display(); 
        }

        private void ModelPage_Load(object sender, EventArgs e)
        {

        }


        private void dataGridViewModel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }

        private void dataGridViewModel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 9)
            {
                //Edit
                form.Clear();
                form.id = Int32.Parse(dataGridViewModel.Rows[e.RowIndex].Cells[0].Value.ToString());
                form.name = dataGridViewModel.Rows[e.RowIndex].Cells[1].Value.ToString();
                form.dataNasterii = DateTime.Parse(dataGridViewModel.Rows[e.RowIndex].Cells[2].Value.ToString());
                form.sex = dataGridViewModel.Rows[e.RowIndex].Cells[3].Value.ToString();
                form.numarTelefon = dataGridViewModel.Rows[e.RowIndex].Cells[4].Value.ToString();
                form.inaltime = Int32.Parse(dataGridViewModel.Rows[e.RowIndex].Cells[5].Value.ToString());
                form.bust = Int32.Parse(dataGridViewModel.Rows[e.RowIndex].Cells[6].Value.ToString());
                form.solduri = Int32.Parse(dataGridViewModel.Rows[e.RowIndex].Cells[7].Value.ToString());

                form.UpdateInfoModel();
                form.ShowDialog();

                return;
            }
            if (e.ColumnIndex == 10)
            {
                //Delete
                if (MessageBox.Show("Are you sure you want to delete that model record?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    var index = Int32.Parse(dataGridViewModel.Rows[e.RowIndex].Cells[0].Value.ToString());
                    DBAgentie.DeleteModel(index);
                    Display();
                }
                return;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void textSearchModel_TextChanged(object sender, EventArgs e)
        {
            string query = "SELECT M.Id, Nume, DataNasterii, Sex, NumarTelefon, Inaltime, Bust, Solduri, Poza FROM Model M left join Caracteristici C On M.CaracteristiciId = C.Id WHERE Nume LIKE '%" + textSearchModel.Text + "%'";
     
            DBAgentie.DisplayAndSearch( query, dataGridViewModel);
        }

       

        private void btnBackToHomeModel_Click_1(object sender, EventArgs e)
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
