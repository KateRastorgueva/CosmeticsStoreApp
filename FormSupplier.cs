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
    public partial class FormSupplier : Form
    {
        public FormSupplier()
        {
            InitializeComponent();
        }

        private void поставщикBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.поставщикBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cosmeticsStoreDataSet);

        }

        private void FormSupplier_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cosmeticsStoreDataSet.Поставщик' table. You can move, or remove it, as needed.
            this.поставщикTableAdapter.Fill(this.cosmeticsStoreDataSet.Поставщик);

        }

        private void поставщикDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
            private static FormSupplier _instance;

            public static FormSupplier Instance
            {
                get
                {
                    if (_instance == null || _instance.IsDisposed)
                        _instance = new FormSupplier();
                    return _instance;
                }
            }

            public void ShowForm()
            {
                Show();
                Activate();
            }

        
    }
}
