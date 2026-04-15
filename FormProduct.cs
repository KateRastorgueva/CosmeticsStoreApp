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

        public FormProduct()
        {
            InitializeComponent();
        }

        private void товарBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.товарBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cosmeticsStoreDataSet);

        }

        private void FormProduct_Load(object sender, EventArgs e)
        {
            this.товарTableAdapter.Fill(this.cosmeticsStoreDataSet.Товар);

        }

        private void btnLoadPhoto_Click(object sender, EventArgs e)
        {
            openFileDialogPhoto.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (openFileDialogPhoto.ShowDialog() == DialogResult.OK)
            {
                фотоPictureBox.Image = new Bitmap(openFileDialogPhoto.FileName);
            }
        }
    }
}
