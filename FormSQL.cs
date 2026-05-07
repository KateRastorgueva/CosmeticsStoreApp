using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CosmeticsStoreApp
{
    public partial class FormSQL : Form
    {
        private static FormSQL _instance;

        public static FormSQL Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                    _instance = new FormSQL();
                return _instance;
            }
        }

        public void ShowForm()
        {
            Show();
            Activate();
        }

        public FormSQL()
        {
            InitializeComponent();
        }

        private DataTable FillDataGridView(string sqlSelect)
        {
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.CosmeticsStoreConnectionString);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlSelect;
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        private DataTable FillDataGridViewParam(string sqlSelect, string paramName, string paramValue)
        {
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.CosmeticsStoreConnectionString);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlSelect;
            command.Parameters.AddWithValue(paramName, paramValue);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        private void radioButtonWorkers_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonWorkers.Checked)
                dataGridViewSelect.DataSource = FillDataGridView("SELECT * FROM Сотрудник");
        }

        private void radioButtonProducts_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonProducts.Checked)
                dataGridViewSelect.DataSource = FillDataGridView("SELECT Номер, Название, Цена FROM Товар WHERE Цена > 500");
        }

        private void radioButtonSales_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonSales.Checked)
            {
                string sql = @"SELECT o.Номер_операции, o.Дата_операции, 
                                      s.ФИО AS Сотрудник, p.ФИО AS Покупатель
                               FROM Операция o
                               INNER JOIN Сотрудник s ON o.Паспорт = s.Паспорт
                               LEFT JOIN Покупатель p ON o.ID_покупателя = p.ID_покупателя";
                dataGridViewSelect.DataSource = FillDataGridView(sql);
            }
        }
        private void buttonExecuteSelect_Click(object sender, EventArgs e)
        {
            string sql = @"SELECT s.ФИО, COUNT(o.Номер_операции) AS Количество_продаж,
                                  CAST(SUM(t.Цена) AS decimal(16,2)) AS Общая_сумма
                           FROM Сотрудник s
                           INNER JOIN Операция o ON s.Паспорт = o.Паспорт
                           INNER JOIN Продажа pr ON o.Номер_операции = pr.Номер_операции
                           INNER JOIN Товар t ON pr.Номер_товара = t.Номер
                           GROUP BY s.ФИО";

            if (radioButtonWithHaving.Checked)
                sql += " HAVING SUM(t.Цена) > 1000";

            if (checkBoxOrder.Checked)
                sql += " ORDER BY Общая_сумма DESC";

            dataGridViewFullSelect.DataSource = FillDataGridView(sql);
        }
        private void radioButtonNonCorrelated_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonNonCorrelated.Checked)
            {
                labelNumber.Text = "Номер товара:";
                textBoxNumber.Clear();

                string sql = @"SELECT Номер, Название, Количество_на_складе, Цена
                       FROM Товар
                       ORDER BY Номер";
                dataGridViewSubquery.DataSource = FillDataGridView(sql);
            }
        }

        private void radioButtonCorrelated_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonCorrelated.Checked)
            {
                labelNumber.Text = "Номер чека:";
                textBoxNumber.Clear();

                string sql = @"SELECT pr.Номер_операции, t.Название, t.Цена,
                              s.ФИО AS Сотрудник
                       FROM Продажа pr
                       INNER JOIN Операция o ON pr.Номер_операции = o.Номер_операции
                       INNER JOIN Сотрудник s ON o.Паспорт = s.Паспорт
                       INNER JOIN Товар t ON pr.Номер_товара = t.Номер
                       ORDER BY pr.Номер_операции";
                dataGridViewSubquery.DataSource = FillDataGridView(sql);
            }
        }

        private void buttonSubquery_Click(object sender, EventArgs e)
        {
            if (radioButtonCorrelated.Checked)
            {
                if (string.IsNullOrEmpty(textBoxNumber.Text))
                {
                    MessageBox.Show("Введите номер чека");
                    return;
                }

                string sql = @"SELECT pr.Номер_операции, t.Название, t.Цена,
                              s.ФИО AS Сотрудник
                       FROM Продажа pr
                       INNER JOIN Операция o ON pr.Номер_операции = o.Номер_операции
                       INNER JOIN Сотрудник s ON o.Паспорт = s.Паспорт
                       INNER JOIN Товар t ON pr.Номер_товара = t.Номер
                       WHERE pr.Номер_операции = @number";
                dataGridViewSubquery.DataSource = FillDataGridViewParam(sql, "@number", textBoxNumber.Text);
            }
            else if (radioButtonNonCorrelated.Checked)
            {
                if (string.IsNullOrEmpty(textBoxNumber.Text))
                {
                    MessageBox.Show("Введите номер товара");
                    return;
                }

                string sql = @"SELECT Номер, Название, Количество_на_складе, Цена
                       FROM Товар
                       WHERE Номер = @number";
                dataGridViewSubquery.DataSource = FillDataGridViewParam(sql, "@number", textBoxNumber.Text);
            }
            else
            {
                MessageBox.Show("Выберите тип подзапроса");
            }
        }
        private void radioButtonInsert_CheckedChanged(object sender, EventArgs e)
        {
            panelProduct.Visible = true;
            textBoxId.Enabled = true;
            textBoxName.Enabled = true;
            textBoxPrice.Enabled = true;
            labelId.Text = "Код товара:";
            labelName.Text = "Название:";
            labelPrice.Text = "Цена:";
        }

        private void radioButtonUpdate_CheckedChanged(object sender, EventArgs e)
        {
            panelProduct.Visible = true;
            textBoxId.Enabled = true;
            textBoxName.Enabled = false;
            textBoxPrice.Enabled = true;
            labelId.Text = "Код товара:";
            labelName.Text = "Название:";
            labelPrice.Text = "Новая цена:";
        }

        private void radioButtonDelete_CheckedChanged(object sender, EventArgs e)
        {
            panelProduct.Visible = true;
            textBoxId.Enabled = true;
            textBoxName.Enabled = false;
            textBoxPrice.Enabled = false;
            labelId.Text = "Код товара для удаления:";
            labelName.Text = "";
            labelPrice.Text = "";
        }

        private void buttonExecuteDML_Click(object sender, EventArgs e)
        {
            if (radioButtonInsert.Checked)
                InsertProduct();
            else if (radioButtonUpdate.Checked)
                UpdateProduct();
            else if (radioButtonDelete.Checked)
                DeleteProduct();
            else
                MessageBox.Show("Выберите действие (добавить, изменить или удалить)");
        }

        private void InsertProduct()
        {
            if (string.IsNullOrEmpty(textBoxId.Text) || string.IsNullOrEmpty(textBoxName.Text) || string.IsNullOrEmpty(textBoxPrice.Text))
            {
                MessageBox.Show("Заполните все поля (код, название, цена)");
                return;
            }

            string sql = @"INSERT INTO Товар (Номер, Название, Цена) VALUES (@Номер, @Название, @Цена)";
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.CosmeticsStoreConnectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sql;
            command.Parameters.AddWithValue("@Номер", int.Parse(textBoxId.Text));
            command.Parameters.AddWithValue("@Название", textBoxName.Text);
            command.Parameters.AddWithValue("@Цена", decimal.Parse(textBoxPrice.Text));

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Товар успешно добавлен", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                buttonSelectProducts_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при добавлении: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private void UpdateProduct()
        {
            if (string.IsNullOrEmpty(textBoxId.Text) || string.IsNullOrEmpty(textBoxPrice.Text))
            {
                MessageBox.Show("Введите код товара и новую цену");
                return;
            }

            string sql = @"UPDATE Товар SET Цена = @Цена WHERE Номер = @Номер";
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.CosmeticsStoreConnectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sql;
            command.Parameters.AddWithValue("@Номер", int.Parse(textBoxId.Text));
            command.Parameters.AddWithValue("@Цена", decimal.Parse(textBoxPrice.Text));

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Цена товара обновлена", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                buttonSelectProducts_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при обновлении: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private void DeleteProduct()
        {
            if (string.IsNullOrEmpty(textBoxId.Text))
            {
                MessageBox.Show("Введите код товара для удаления");
                return;
            }

            string sql = @"DELETE FROM Товар WHERE Номер = @Номер";
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.CosmeticsStoreConnectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sql;
            command.Parameters.AddWithValue("@Номер", int.Parse(textBoxId.Text));

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Товар удалён", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                buttonSelectProducts_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при удалении: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private void buttonSelectProducts_Click(object sender, EventArgs e)
        {
            dataGridViewProducts.DataSource = FillDataGridView("SELECT Номер, Название, Цена, Производитель FROM Товар");
        }

        private void FormSQL_Load(object sender, EventArgs e)
        {

        }

        private void textBoxNumber_TextChanged(object sender, EventArgs e)
        {

        }
    }
}