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
    public partial class FormSupply : Form
    {
        private static FormSupply _instance;

        public static FormSupply Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                    _instance = new FormSupply();
                return _instance;
            }
        }

        public void ShowForm()
        {
            Show();
            Activate();
        }

        public FormSupply()
        {
            InitializeComponent();
        }

        private void поставилBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.поставилBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cosmeticsStoreDataSet);

        }

        private void FormSupply_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cosmeticsStoreDataSet.Поставил' table. You can move, or remove it, as needed.
            this.поставилTableAdapter.Fill(this.cosmeticsStoreDataSet.Поставил);

        }
    }
}
