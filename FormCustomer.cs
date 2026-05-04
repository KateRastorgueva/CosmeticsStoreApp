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
    public partial class FormCustomer : Form
    {
        private static FormCustomer _instance;

        public static FormCustomer Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                    _instance = new FormCustomer();
                return _instance;
            }
        }

        public void ShowForm()
        {
            Show();
            Activate();
        }

        public FormCustomer()
        {
            InitializeComponent();
        }
        private void FormCustomer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cosmeticsStoreDataSet.Покупатель' table. You can move, or remove it, as needed.
            this.покупательTableAdapter.Fill(this.cosmeticsStoreDataSet.Покупатель);

        }
        private void покупательDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.RowIndex % 2 == 0)
                {
                    покупательDataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightCyan;
                }
                else
                {
                    покупательDataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                }
            }
        }
    }
}
