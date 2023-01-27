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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void evenimentModelBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.evenimentModelBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.agentieFotomodeleDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'agentieFotomodeleDataSet.Model' table. You can move, or remove it, as needed.
            this.modelTableAdapter.Fill(this.agentieFotomodeleDataSet.Model);
            // TODO: This line of code loads data into the 'agentieFotomodeleDataSet.EvenimentModel' table. You can move, or remove it, as needed.
            this.evenimentModelTableAdapter.Fill(this.agentieFotomodeleDataSet.EvenimentModel);

        }

        /* private void modelBindingNavigatorSaveItem_Click(object sender, EventArgs e)
         {
             this.Validate();
             this.modelBindingSource.EndEdit();
             this.tableAdapterManager.UpdateAll(this.agentieFotomodeleDataSet);

         }

         private void modelBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
         {
             this.Validate();
             this.modelBindingSource.EndEdit();
             this.tableAdapterManager.UpdateAll(this.agentieFotomodeleDataSet);

         }*/
    }
}
