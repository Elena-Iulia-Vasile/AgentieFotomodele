using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proiect_BD
{
    public partial class Login : Form
    {
        SqlConnection conn = DBAgentie.GetConnection();
        

        public Login()
        {
            InitializeComponent();
        }
        private void modelBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.modelBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.agentieFotomodeleDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'agentieFotomodeleDataSet.Model' table. You can move, or remove it, as needed.
            this.modelTableAdapter.Fill(this.agentieFotomodeleDataSet.Model);

        }

        private void modelDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string username, password;

            username = textBox1.Text; 
            password = textBox2.Text;

            try
            {
                string query = "SELECT * FROM LoginTable WHERE Username = '"+textBox1.Text+"' AND Password = '"+textBox2.Text+"'";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);
                if(dtable.Rows.Count > 0) 
                {
                    username = textBox1.Text;
                    password = textBox2.Text;


                    HomePage homePage = new HomePage();
                    homePage.ShowDialog();
                    this.Hide();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid Credential", "Agency");
                    textBox1.Clear();
                    textBox2.Clear();

                    textBox1.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Invalid Credential", "Agency");
            }
            finally
            {
                conn.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }
    }
}
