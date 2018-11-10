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
    public partial class ViewItems : Form
    {
        public ViewItems()
        {
            InitializeComponent();
        }

        private void itemsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.itemsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.vale3DataSet);

        }

        private void ViewItems_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vale3DataSet.Items' table. You can move, or remove it, as needed.
            this.itemsTableAdapter.Fill(this.vale3DataSet.Items);

        }
    }
}
