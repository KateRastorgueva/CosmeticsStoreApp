using System;
using System.Drawing;
using System.Windows.Forms;

namespace CosmeticsStoreApp
{
    public partial class FormSupplier : Form
    {
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

        public FormSupplier()
        {
            InitializeComponent();
        }

        private void поставщикBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.поставщикBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.cosmeticsStoreDataSet);
                MessageBox.Show("Данные сохранены", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка: " + err.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormSupplier_Load(object sender, EventArgs e)
        {
            this.поставщикTableAdapter.Fill(this.cosmeticsStoreDataSet.Поставщик);
        }

        private void поставщикDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = поставщикDataGridView.Rows[e.RowIndex];
                if (row.Cells["dataGridViewTextBoxColumn2"].Value != null)
                {
                    string название = row.Cells["dataGridViewTextBoxColumn2"].Value.ToString();

                    if (название.Contains("ООО"))
                        row.DefaultCellStyle.BackColor = Color.LightGreen;
                    else if (название.Contains("ИП"))
                        row.DefaultCellStyle.BackColor = Color.LightBlue;
                    else if (название.Contains("ЗАО"))
                        row.DefaultCellStyle.BackColor = Color.LightYellow;
                    else
                        row.DefaultCellStyle.BackColor = Color.White;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                }
            }
        }
    }
}