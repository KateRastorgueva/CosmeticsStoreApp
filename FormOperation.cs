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
        private static FormOperation _instance;

        public static FormOperation Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                    _instance = new FormOperation();
                return _instance;
            }
        }

        public void ShowForm()
        {
            Show();
            Activate();
        }
        public FormOperation()
        {
            InitializeComponent();
        }

        private void операцияBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.операцияBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.cosmeticsStoreDataSet);
                MessageBox.Show("Данные сохранены", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка: " + err.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FormOperation_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cosmeticsStoreDataSet.Продажа' table. You can move, or remove it, as needed.
            this.продажаTableAdapter.Fill(this.cosmeticsStoreDataSet.Продажа);
            // TODO: This line of code loads data into the 'cosmeticsStoreDataSet.Операция' table. You can move, or remove it, as needed.
            this.операцияTableAdapter.Fill(this.cosmeticsStoreDataSet.Операция);
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(toolStripTextBoxFind, "Введите номер операции");
            toolTip.SetToolTip(toolStripButtonFind, "Найти операцию по номеру");
            toolTip.SetToolTip(toolStripCheckBoxFilter, "Включить/выключить фильтр");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void toolStripButtonFind_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(toolStripTextBoxFind.Text))
            {
                MessageBox.Show("Введите номер операции для поиска", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                int searchValue = int.Parse(toolStripTextBoxFind.Text);
                int index = операцияBindingSource.Find("Номер_операции", searchValue);

                if (index >= 0)
                {
                    операцияBindingSource.Position = index;
                }
                else
                {
                    MessageBox.Show("Операция с номером " + searchValue + " не найдена", "Результат поиска", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при поиске: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripCheckBoxFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (toolStripCheckBoxFilter.Checked)
            {
                if (string.IsNullOrEmpty(toolStripTextBoxFind.Text))
                {
                    MessageBox.Show("Введите значение для фильтрации", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    toolStripCheckBoxFilter.Checked = false;
                    return;
                }

                try
                {
                    int filterValue = int.Parse(toolStripTextBoxFind.Text);
                    операцияBindingSource.Filter = "Номер_операции = " + filterValue;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка фильтрации: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    toolStripCheckBoxFilter.Checked = false;
                }
            }
            else
            {
                операцияBindingSource.Filter = "";
                операцияBindingSource.RemoveFilter();
            }
        }
        private void продажаDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    FormProduct productForm = new FormProduct();
                    productForm.Show();
                }
                catch
                {
                    MessageBox.Show("Ошибка при открытии формы товара");
                }
            }
        }
        private void продажаDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
