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
    public partial class FormEmployee : Form
    {
        public FormEmployee()
        {
            InitializeComponent();
        }
        private static FormEmployee _instance;

        public static FormEmployee Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                    _instance = new FormEmployee();
                return _instance;
            }
        }

        public void ShowForm()
        {
            Show();
            Activate();
        }
        private void сотрудникBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.сотрудникBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cosmeticsStoreDataSet);

        }

        private void FormEmployee_Load(object sender, EventArgs e)
        {
            this.сотрудникTableAdapter.Fill(this.cosmeticsStoreDataSet.Сотрудник);

        }

        private void сотрудникBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void сотрудникDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void сотрудникDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = сотрудникDataGridView.Rows[e.RowIndex];

                if (row.Cells["Должность"].Value != null)
                {
                    string должность = row.Cells["Должность"].Value.ToString();

                    switch (должность)
                    {
                        case "Продавец":
                            row.DefaultCellStyle.BackColor = Color.LightGreen;
                            break;
                        case "Старший продавец":
                            row.DefaultCellStyle.BackColor = Color.LightBlue;
                            break;
                        case "Кассир":
                            row.DefaultCellStyle.BackColor = Color.LightYellow;
                            break;
                        case "Администратор":
                            row.DefaultCellStyle.BackColor = Color.Lavender;
                            break;
                        default:
                            row.DefaultCellStyle.BackColor = Color.White;
                            break;
                    }
                }
            }
        }
    }
}
