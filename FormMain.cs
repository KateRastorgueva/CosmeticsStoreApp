using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CosmeticsStoreApp.Properties;
using System.Windows.Forms;

namespace CosmeticsStoreApp
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы действительно хотите выйти?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("(C) ТУСУР, КСУП, Расторгуева Е.С., группа 574-3, 2026", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Settings.Default.Save();
        }

        private void сотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEmployee.Instance.ShowForm();
        }

        private void продажиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Форма для продаж будет создана позже");
        }
        private void товарыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProduct.Instance.ShowForm();
        }
        private void покупателиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Форма для покупателей будет создана позже");
        }

        private void поставщикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Форма для поставщиков будет создана позже");
        }
    }
}
