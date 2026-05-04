using System;
using System.Drawing;
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
            try
            {
                this.Validate();
                this.поставилBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.cosmeticsStoreDataSet);
                MessageBox.Show("Данные сохранены", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка: " + err.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormSupply_Load(object sender, EventArgs e)
        {
            this.поставилTableAdapter.Fill(this.cosmeticsStoreDataSet.Поставил);
        }
        private void поставилDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = поставилDataGridView.Rows[e.RowIndex];

                if (row.Cells["dataGridViewTextBoxColumn2"].Value != null)
                {
                    int номерТовара = Convert.ToInt32(row.Cells["dataGridViewTextBoxColumn2"].Value);

                    switch (номерТовара)
                    {
                        case 101: row.DefaultCellStyle.BackColor = Color.LightCoral; break;
                        case 102: row.DefaultCellStyle.BackColor = Color.LightGreen; break;
                        case 103: row.DefaultCellStyle.BackColor = Color.LightYellow; break;
                        case 104: row.DefaultCellStyle.BackColor = Color.Lavender; break;
                        case 105: row.DefaultCellStyle.BackColor = Color.LightBlue; break;
                        case 106: row.DefaultCellStyle.BackColor = Color.LightPink; break;
                        default: row.DefaultCellStyle.BackColor = Color.White; break;
                    }
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                }
            }
        }
    }
}