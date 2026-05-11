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
    public partial class FormProduct : Form
    {
        private static FormProduct _instance;

        public static FormProduct Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                    _instance = new FormProduct();
                return _instance;
            }
        }

        public void ShowForm()
        {
            Show();
            Activate();
        }
        public int SelectedProductNumber { get; set; }
        public FormProduct()
        {
            InitializeComponent();
        }

        private void товарBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.товарBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.cosmeticsStoreDataSet);
                MessageBox.Show("Данные сохранены", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка при сохранении: " + err.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void SelectProductByNumber(int productNumber)
        {
            int index = товарBindingSource.Find("Номер", productNumber);
            if (index >= 0)
            {
                товарBindingSource.Position = index;
            }
        }
        private void FormProduct_Load(object sender, EventArgs e)
        {
            this.товарTableAdapter.Fill(this.cosmeticsStoreDataSet.Товар);

            if (SelectedProductNumber > 0)
            {
                int index = товарBindingSource.Find("Номер", SelectedProductNumber);
                if (index >= 0)
                {
                    товарBindingSource.Position = index;
                }
            }
        }
        public void ShowProductByNumber(int productNumber)
        {
            int index = товарBindingSource.Find("Номер", productNumber);
            if (index >= 0)
            {
                товарBindingSource.Position = index;
            }
            Show();
            Activate();
        }
        private void btnLoadPhoto_Click(object sender, EventArgs e)
        {
            openFileDialogPhoto.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (openFileDialogPhoto.ShowDialog() == DialogResult.OK)
            {
                фотоPictureBox.Image = new Bitmap(openFileDialogPhoto.FileName);
            }
        }

        private void номерTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
