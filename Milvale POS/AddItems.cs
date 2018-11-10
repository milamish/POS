using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milvale_POS
{
    public partial class AddItems : Form
    {
        public AddItems()
        {
            InitializeComponent();
        }

        private void itemsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.itemsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.vale3DataSet);

        }

        private void AddItems_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vale3DataSet.Items' table. You can move, or remove it, as needed.
            this.itemsTableAdapter.Fill(this.vale3DataSet.Items);

        }

        private void itemNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void itemNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string a = Convert.ToString(itemNameTextBox.Text);
                double b = Convert.ToDouble(costTextBox.Text);
                int c = Convert.ToInt32(quantityTextBox.Text);
                double f = b * c;
                label5.Text = a.ToString();
                label6.Text = String.Format("{0:C}", double.Parse(b.ToString()));
                label7.Text = c.ToString();
                label8.Text = String.Format("{0:C}", double.Parse(f.ToString()));


            }
            catch
            {

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            itemNameTextBox.Text = "";
            costTextBox.Text = "";
            quantityTextBox.Text = "";
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
        }

        private void costTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                costTextBox.Text = String.Format("{0:N2}", double.Parse(costTextBox.Text));
            }
            catch
            {
                MessageBox.Show("invalid input");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
