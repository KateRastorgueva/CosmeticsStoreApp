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
    public partial class FormSale : Form
    {
        private static FormSale _instance;

        public static FormSale Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                    _instance = new FormSale();
                return _instance;
            }
        }

        public void ShowForm()
        {
            Show();
            Activate();
        }

        public FormSale()
        {
            InitializeComponent();
        }

        private void продажаBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.продажаBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cosmeticsStoreDataSet);

        }

        private void FormSale_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cosmeticsStoreDataSet.Продажа' table. You can move, or remove it, as needed.
            this.продажаTableAdapter.Fill(this.cosmeticsStoreDataSet.Продажа);

        }
    }
}
