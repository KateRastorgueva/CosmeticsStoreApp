using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CosmeticsStoreApp
{
    public partial class FormOperation : Form
    {
        public FormOperation()
        {
            InitializeComponent();
        }

        private void операцияBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.операцияBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cosmeticsStoreDataSet);

        }

        private void FormOperation_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cosmeticsStoreDataSet.Операция' table. You can move, or remove it, as needed.
            this.операцияTableAdapter.Fill(this.cosmeticsStoreDataSet.Операция);

        }
    }
}
