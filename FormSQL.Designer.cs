namespace CosmeticsStoreApp
{
    partial class FormSQL
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tabControlSQL = new System.Windows.Forms.TabControl();
            this.tabPagePrimer = new System.Windows.Forms.TabPage();
            this.dataGridViewSelect = new System.Windows.Forms.DataGridView();
            this.groupBoxSelect = new System.Windows.Forms.GroupBox();
            this.radioButtonSales = new System.Windows.Forms.RadioButton();
            this.radioButtonProducts = new System.Windows.Forms.RadioButton();
            this.radioButtonWorkers = new System.Windows.Forms.RadioButton();
            this.tabPageFullSelect = new System.Windows.Forms.TabPage();
            this.dataGridViewFullSelect = new System.Windows.Forms.DataGridView();
            this.groupBoxFullSelect = new System.Windows.Forms.GroupBox();
            this.buttonExecuteSelect = new System.Windows.Forms.Button();
            this.checkBoxOrder = new System.Windows.Forms.CheckBox();
            this.radioButtonWithHaving = new System.Windows.Forms.RadioButton();
            this.radioButtonGroupBy = new System.Windows.Forms.RadioButton();
            this.tabPageSubquery = new System.Windows.Forms.TabPage();
            this.dataGridViewSubquery = new System.Windows.Forms.DataGridView();
            this.groupBoxSubquery = new System.Windows.Forms.GroupBox();
            this.buttonSubquery = new System.Windows.Forms.Button();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.labelNumber = new System.Windows.Forms.Label();
            this.radioButtonNonCorrelated = new System.Windows.Forms.RadioButton();
            this.radioButtonCorrelated = new System.Windows.Forms.RadioButton();
            this.tabPageDML = new System.Windows.Forms.TabPage();
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.groupBoxDML = new System.Windows.Forms.GroupBox();
            this.panelProduct = new System.Windows.Forms.Panel();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.buttonExecuteDML = new System.Windows.Forms.Button();
            this.radioButtonDelete = new System.Windows.Forms.RadioButton();
            this.radioButtonUpdate = new System.Windows.Forms.RadioButton();
            this.radioButtonInsert = new System.Windows.Forms.RadioButton();
            this.buttonSelectProducts = new System.Windows.Forms.Button();
            this.tabControlSQL.SuspendLayout();
            this.tabPagePrimer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelect)).BeginInit();
            this.groupBoxSelect.SuspendLayout();
            this.tabPageFullSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFullSelect)).BeginInit();
            this.groupBoxFullSelect.SuspendLayout();
            this.tabPageSubquery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubquery)).BeginInit();
            this.groupBoxSubquery.SuspendLayout();
            this.tabPageDML.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            this.groupBoxDML.SuspendLayout();
            this.panelProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlSQL
            // 
            this.tabControlSQL.Controls.Add(this.tabPagePrimer);
            this.tabControlSQL.Controls.Add(this.tabPageFullSelect);
            this.tabControlSQL.Controls.Add(this.tabPageSubquery);
            this.tabControlSQL.Controls.Add(this.tabPageDML);
            this.tabControlSQL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlSQL.Location = new System.Drawing.Point(0, 0);
            this.tabControlSQL.Name = "tabControlSQL";
            this.tabControlSQL.SelectedIndex = 0;
            this.tabControlSQL.Size = new System.Drawing.Size(900, 550);
            this.tabControlSQL.TabIndex = 0;
            // 
            // tabPagePrimer
            // 
            this.tabPagePrimer.Controls.Add(this.dataGridViewSelect);
            this.tabPagePrimer.Controls.Add(this.groupBoxSelect);
            this.tabPagePrimer.Location = new System.Drawing.Point(4, 29);
            this.tabPagePrimer.Name = "tabPagePrimer";
            this.tabPagePrimer.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePrimer.Size = new System.Drawing.Size(892, 517);
            this.tabPagePrimer.TabIndex = 0;
            this.tabPagePrimer.Text = "Примеры запросов";
            this.tabPagePrimer.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSelect
            // 
            this.dataGridViewSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSelect.Location = new System.Drawing.Point(3, 140);
            this.dataGridViewSelect.Name = "dataGridViewSelect";
            this.dataGridViewSelect.RowHeadersWidth = 62;
            this.dataGridViewSelect.RowTemplate.Height = 28;
            this.dataGridViewSelect.Size = new System.Drawing.Size(886, 374);
            this.dataGridViewSelect.TabIndex = 1;
            // 
            // groupBoxSelect
            // 
            this.groupBoxSelect.Controls.Add(this.radioButtonSales);
            this.groupBoxSelect.Controls.Add(this.radioButtonProducts);
            this.groupBoxSelect.Controls.Add(this.radioButtonWorkers);
            this.groupBoxSelect.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxSelect.Location = new System.Drawing.Point(3, 3);
            this.groupBoxSelect.Name = "groupBoxSelect";
            this.groupBoxSelect.Size = new System.Drawing.Size(886, 137);
            this.groupBoxSelect.TabIndex = 0;
            this.groupBoxSelect.TabStop = false;
            this.groupBoxSelect.Text = "Запросы по данным";
            // 
            // radioButtonSales
            // 
            this.radioButtonSales.AutoSize = true;
            this.radioButtonSales.Location = new System.Drawing.Point(19, 95);
            this.radioButtonSales.Name = "radioButtonSales";
            this.radioButtonSales.Size = new System.Drawing.Size(104, 24);
            this.radioButtonSales.TabIndex = 2;
            this.radioButtonSales.Text = "Продажи";
            this.radioButtonSales.UseVisualStyleBackColor = true;
            this.radioButtonSales.CheckedChanged += new System.EventHandler(this.radioButtonSales_CheckedChanged);
            // 
            // radioButtonProducts
            // 
            this.radioButtonProducts.AutoSize = true;
            this.radioButtonProducts.Location = new System.Drawing.Point(19, 65);
            this.radioButtonProducts.Name = "radioButtonProducts";
            this.radioButtonProducts.Size = new System.Drawing.Size(90, 24);
            this.radioButtonProducts.TabIndex = 1;
            this.radioButtonProducts.Text = "Товары";
            this.radioButtonProducts.UseVisualStyleBackColor = true;
            this.radioButtonProducts.CheckedChanged += new System.EventHandler(this.radioButtonProducts_CheckedChanged);
            // 
            // radioButtonWorkers
            // 
            this.radioButtonWorkers.AutoSize = true;
            this.radioButtonWorkers.Location = new System.Drawing.Point(19, 35);
            this.radioButtonWorkers.Name = "radioButtonWorkers";
            this.radioButtonWorkers.Size = new System.Drawing.Size(125, 24);
            this.radioButtonWorkers.TabIndex = 0;
            this.radioButtonWorkers.Text = "Сотрудники";
            this.radioButtonWorkers.UseVisualStyleBackColor = true;
            this.radioButtonWorkers.CheckedChanged += new System.EventHandler(this.radioButtonWorkers_CheckedChanged);
            // 
            // tabPageFullSelect
            // 
            this.tabPageFullSelect.Controls.Add(this.dataGridViewFullSelect);
            this.tabPageFullSelect.Controls.Add(this.groupBoxFullSelect);
            this.tabPageFullSelect.Location = new System.Drawing.Point(4, 29);
            this.tabPageFullSelect.Name = "tabPageFullSelect";
            this.tabPageFullSelect.Size = new System.Drawing.Size(892, 517);
            this.tabPageFullSelect.TabIndex = 1;
            this.tabPageFullSelect.Text = "Полный SELECT";
            this.tabPageFullSelect.UseVisualStyleBackColor = true;
            // 
            // dataGridViewFullSelect
            // 
            this.dataGridViewFullSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFullSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewFullSelect.Location = new System.Drawing.Point(0, 150);
            this.dataGridViewFullSelect.Name = "dataGridViewFullSelect";
            this.dataGridViewFullSelect.RowHeadersWidth = 62;
            this.dataGridViewFullSelect.RowTemplate.Height = 28;
            this.dataGridViewFullSelect.Size = new System.Drawing.Size(892, 367);
            this.dataGridViewFullSelect.TabIndex = 1;
            // 
            // groupBoxFullSelect
            // 
            this.groupBoxFullSelect.Controls.Add(this.buttonExecuteSelect);
            this.groupBoxFullSelect.Controls.Add(this.checkBoxOrder);
            this.groupBoxFullSelect.Controls.Add(this.radioButtonWithHaving);
            this.groupBoxFullSelect.Controls.Add(this.radioButtonGroupBy);
            this.groupBoxFullSelect.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxFullSelect.Location = new System.Drawing.Point(0, 0);
            this.groupBoxFullSelect.Name = "groupBoxFullSelect";
            this.groupBoxFullSelect.Size = new System.Drawing.Size(892, 150);
            this.groupBoxFullSelect.TabIndex = 0;
            this.groupBoxFullSelect.TabStop = false;
            this.groupBoxFullSelect.Text = "Статистика продаж";
            // 
            // buttonExecuteSelect
            // 
            this.buttonExecuteSelect.Location = new System.Drawing.Point(19, 105);
            this.buttonExecuteSelect.Name = "buttonExecuteSelect";
            this.buttonExecuteSelect.Size = new System.Drawing.Size(120, 35);
            this.buttonExecuteSelect.TabIndex = 3;
            this.buttonExecuteSelect.Text = "Выполнить";
            this.buttonExecuteSelect.UseVisualStyleBackColor = true;
            this.buttonExecuteSelect.Click += new System.EventHandler(this.buttonExecuteSelect_Click);
            // 
            // checkBoxOrder
            // 
            this.checkBoxOrder.AutoSize = true;
            this.checkBoxOrder.Location = new System.Drawing.Point(19, 80);
            this.checkBoxOrder.Name = "checkBoxOrder";
            this.checkBoxOrder.Size = new System.Drawing.Size(227, 24);
            this.checkBoxOrder.TabIndex = 2;
            this.checkBoxOrder.Text = "Сортировка по убыванию";
            this.checkBoxOrder.UseVisualStyleBackColor = true;
            // 
            // radioButtonWithHaving
            // 
            this.radioButtonWithHaving.AutoSize = true;
            this.radioButtonWithHaving.Location = new System.Drawing.Point(19, 50);
            this.radioButtonWithHaving.Name = "radioButtonWithHaving";
            this.radioButtonWithHaving.Size = new System.Drawing.Size(272, 24);
            this.radioButtonWithHaving.TabIndex = 1;
            this.radioButtonWithHaving.Text = "Сотрудники с прибылью > 1000";
            this.radioButtonWithHaving.UseVisualStyleBackColor = true;
            // 
            // radioButtonGroupBy
            // 
            this.radioButtonGroupBy.AutoSize = true;
            this.radioButtonGroupBy.Location = new System.Drawing.Point(19, 20);
            this.radioButtonGroupBy.Name = "radioButtonGroupBy";
            this.radioButtonGroupBy.Size = new System.Drawing.Size(255, 24);
            this.radioButtonGroupBy.TabIndex = 0;
            this.radioButtonGroupBy.Text = "Группировка по сотрудникам";
            this.radioButtonGroupBy.UseVisualStyleBackColor = true;
            // 
            // tabPageSubquery
            // 
            this.tabPageSubquery.Controls.Add(this.dataGridViewSubquery);
            this.tabPageSubquery.Controls.Add(this.groupBoxSubquery);
            this.tabPageSubquery.Location = new System.Drawing.Point(4, 29);
            this.tabPageSubquery.Name = "tabPageSubquery";
            this.tabPageSubquery.Size = new System.Drawing.Size(892, 517);
            this.tabPageSubquery.TabIndex = 2;
            this.tabPageSubquery.Text = "Подзапросы";
            this.tabPageSubquery.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSubquery
            // 
            this.dataGridViewSubquery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSubquery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSubquery.Location = new System.Drawing.Point(0, 170);
            this.dataGridViewSubquery.Name = "dataGridViewSubquery";
            this.dataGridViewSubquery.RowHeadersWidth = 62;
            this.dataGridViewSubquery.RowTemplate.Height = 28;
            this.dataGridViewSubquery.Size = new System.Drawing.Size(892, 347);
            this.dataGridViewSubquery.TabIndex = 1;
            // 
            // groupBoxSubquery
            // 
            this.groupBoxSubquery.Controls.Add(this.buttonSubquery);
            this.groupBoxSubquery.Controls.Add(this.textBoxNumber);
            this.groupBoxSubquery.Controls.Add(this.labelNumber);
            this.groupBoxSubquery.Controls.Add(this.radioButtonNonCorrelated);
            this.groupBoxSubquery.Controls.Add(this.radioButtonCorrelated);
            this.groupBoxSubquery.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxSubquery.Location = new System.Drawing.Point(0, 0);
            this.groupBoxSubquery.Name = "groupBoxSubquery";
            this.groupBoxSubquery.Size = new System.Drawing.Size(892, 170);
            this.groupBoxSubquery.TabIndex = 0;
            this.groupBoxSubquery.TabStop = false;
            this.groupBoxSubquery.Text = "Подзапросы по данным";
            // 
            // buttonSubquery
            // 
            this.buttonSubquery.Location = new System.Drawing.Point(19, 130);
            this.buttonSubquery.Name = "buttonSubquery";
            this.buttonSubquery.Size = new System.Drawing.Size(180, 30);
            this.buttonSubquery.TabIndex = 4;
            this.buttonSubquery.Text = "Выполнить подзапрос";
            this.buttonSubquery.UseVisualStyleBackColor = true;
            this.buttonSubquery.Click += new System.EventHandler(this.buttonSubquery_Click);
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(161, 98);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(150, 26);
            this.textBoxNumber.TabIndex = 3;
            this.textBoxNumber.TextChanged += new System.EventHandler(this.textBoxNumber_TextChanged);
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Location = new System.Drawing.Point(15, 95);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(63, 20);
            this.labelNumber.TabIndex = 2;
            this.labelNumber.Text = "Номер:";
            // 
            // radioButtonNonCorrelated
            // 
            this.radioButtonNonCorrelated.AutoSize = true;
            this.radioButtonNonCorrelated.Location = new System.Drawing.Point(19, 65);
            this.radioButtonNonCorrelated.Name = "radioButtonNonCorrelated";
            this.radioButtonNonCorrelated.Size = new System.Drawing.Size(418, 24);
            this.radioButtonNonCorrelated.TabIndex = 1;
            this.radioButtonNonCorrelated.Text = "Некоррелированный (Товары цены выше средней)";
            this.radioButtonNonCorrelated.UseVisualStyleBackColor = true;
            this.radioButtonNonCorrelated.CheckedChanged += new System.EventHandler(this.radioButtonNonCorrelated_CheckedChanged);
            // 
            // radioButtonCorrelated
            // 
            this.radioButtonCorrelated.AutoSize = true;
            this.radioButtonCorrelated.Location = new System.Drawing.Point(19, 25);
            this.radioButtonCorrelated.Name = "radioButtonCorrelated";
            this.radioButtonCorrelated.Size = new System.Drawing.Size(407, 44);
            this.radioButtonCorrelated.TabIndex = 0;
            this.radioButtonCorrelated.Text = "Коррелированный подзапрос(Лучшие продавцы)\r\n\r\n";
            this.radioButtonCorrelated.UseVisualStyleBackColor = true;
            this.radioButtonCorrelated.CheckedChanged += new System.EventHandler(this.radioButtonCorrelated_CheckedChanged);
            // 
            // tabPageDML
            // 
            this.tabPageDML.Controls.Add(this.dataGridViewProducts);
            this.tabPageDML.Controls.Add(this.groupBoxDML);
            this.tabPageDML.Controls.Add(this.buttonSelectProducts);
            this.tabPageDML.Location = new System.Drawing.Point(4, 29);
            this.tabPageDML.Name = "tabPageDML";
            this.tabPageDML.Size = new System.Drawing.Size(892, 517);
            this.tabPageDML.TabIndex = 3;
            this.tabPageDML.Text = "Изменение данных";
            this.tabPageDML.UseVisualStyleBackColor = true;
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.Location = new System.Drawing.Point(15, 280);
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.RowHeadersWidth = 62;
            this.dataGridViewProducts.RowTemplate.Height = 28;
            this.dataGridViewProducts.Size = new System.Drawing.Size(862, 175);
            this.dataGridViewProducts.TabIndex = 1;
            // 
            // groupBoxDML
            // 
            this.groupBoxDML.Controls.Add(this.panelProduct);
            this.groupBoxDML.Controls.Add(this.buttonExecuteDML);
            this.groupBoxDML.Controls.Add(this.radioButtonDelete);
            this.groupBoxDML.Controls.Add(this.radioButtonUpdate);
            this.groupBoxDML.Controls.Add(this.radioButtonInsert);
            this.groupBoxDML.Location = new System.Drawing.Point(15, 10);
            this.groupBoxDML.Name = "groupBoxDML";
            this.groupBoxDML.Size = new System.Drawing.Size(862, 260);
            this.groupBoxDML.TabIndex = 0;
            this.groupBoxDML.TabStop = false;
            this.groupBoxDML.Text = "Операторы";
            // 
            // panelProduct
            // 
            this.panelProduct.Controls.Add(this.textBoxPrice);
            this.panelProduct.Controls.Add(this.labelPrice);
            this.panelProduct.Controls.Add(this.textBoxName);
            this.panelProduct.Controls.Add(this.labelName);
            this.panelProduct.Controls.Add(this.textBoxId);
            this.panelProduct.Controls.Add(this.labelId);
            this.panelProduct.Location = new System.Drawing.Point(15, 95);
            this.panelProduct.Name = "panelProduct";
            this.panelProduct.Size = new System.Drawing.Size(350, 120);
            this.panelProduct.TabIndex = 4;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(100, 80);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(200, 26);
            this.textBoxPrice.TabIndex = 5;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(10, 83);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(52, 20);
            this.labelPrice.TabIndex = 4;
            this.labelPrice.Text = "Цена:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(100, 45);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(200, 26);
            this.textBoxName.TabIndex = 3;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(10, 48);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(87, 20);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Название:";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(117, 10);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(183, 26);
            this.textBoxId.TabIndex = 1;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(10, 13);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(101, 20);
            this.labelId.TabIndex = 0;
            this.labelId.Text = "Код товара:";
            // 
            // buttonExecuteDML
            // 
            this.buttonExecuteDML.Location = new System.Drawing.Point(390, 110);
            this.buttonExecuteDML.Name = "buttonExecuteDML";
            this.buttonExecuteDML.Size = new System.Drawing.Size(150, 35);
            this.buttonExecuteDML.TabIndex = 3;
            this.buttonExecuteDML.Text = "Выполнить запрос";
            this.buttonExecuteDML.UseVisualStyleBackColor = true;
            this.buttonExecuteDML.Click += new System.EventHandler(this.buttonExecuteDML_Click);
            // 
            // radioButtonDelete
            // 
            this.radioButtonDelete.AutoSize = true;
            this.radioButtonDelete.Location = new System.Drawing.Point(390, 70);
            this.radioButtonDelete.Name = "radioButtonDelete";
            this.radioButtonDelete.Size = new System.Drawing.Size(150, 24);
            this.radioButtonDelete.TabIndex = 2;
            this.radioButtonDelete.Text = "Удалить товар";
            this.radioButtonDelete.UseVisualStyleBackColor = true;
            this.radioButtonDelete.CheckedChanged += new System.EventHandler(this.radioButtonDelete_CheckedChanged);
            // 
            // radioButtonUpdate
            // 
            this.radioButtonUpdate.AutoSize = true;
            this.radioButtonUpdate.Location = new System.Drawing.Point(390, 40);
            this.radioButtonUpdate.Name = "radioButtonUpdate";
            this.radioButtonUpdate.Size = new System.Drawing.Size(205, 24);
            this.radioButtonUpdate.TabIndex = 1;
            this.radioButtonUpdate.Text = "Изменить цену товара";
            this.radioButtonUpdate.UseVisualStyleBackColor = true;
            this.radioButtonUpdate.CheckedChanged += new System.EventHandler(this.radioButtonUpdate_CheckedChanged);
            // 
            // radioButtonInsert
            // 
            this.radioButtonInsert.AutoSize = true;
            this.radioButtonInsert.Location = new System.Drawing.Point(390, 10);
            this.radioButtonInsert.Name = "radioButtonInsert";
            this.radioButtonInsert.Size = new System.Drawing.Size(158, 24);
            this.radioButtonInsert.TabIndex = 0;
            this.radioButtonInsert.Text = "Добавить товар";
            this.radioButtonInsert.UseVisualStyleBackColor = true;
            this.radioButtonInsert.CheckedChanged += new System.EventHandler(this.radioButtonInsert_CheckedChanged);
            // 
            // buttonSelectProducts
            // 
            this.buttonSelectProducts.Location = new System.Drawing.Point(15, 470);
            this.buttonSelectProducts.Name = "buttonSelectProducts";
            this.buttonSelectProducts.Size = new System.Drawing.Size(200, 35);
            this.buttonSelectProducts.TabIndex = 2;
            this.buttonSelectProducts.Text = "Показать список товаров";
            this.buttonSelectProducts.UseVisualStyleBackColor = true;
            this.buttonSelectProducts.Click += new System.EventHandler(this.buttonSelectProducts_Click);
            // 
            // FormSQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Controls.Add(this.tabControlSQL);
            this.Name = "FormSQL";
            this.Text = "SQL Запросы";
            this.Load += new System.EventHandler(this.FormSQL_Load);
            this.tabControlSQL.ResumeLayout(false);
            this.tabPagePrimer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelect)).EndInit();
            this.groupBoxSelect.ResumeLayout(false);
            this.groupBoxSelect.PerformLayout();
            this.tabPageFullSelect.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFullSelect)).EndInit();
            this.groupBoxFullSelect.ResumeLayout(false);
            this.groupBoxFullSelect.PerformLayout();
            this.tabPageSubquery.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubquery)).EndInit();
            this.groupBoxSubquery.ResumeLayout(false);
            this.groupBoxSubquery.PerformLayout();
            this.tabPageDML.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            this.groupBoxDML.ResumeLayout(false);
            this.groupBoxDML.PerformLayout();
            this.panelProduct.ResumeLayout(false);
            this.panelProduct.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.TabControl tabControlSQL;
        private System.Windows.Forms.TabPage tabPagePrimer;
        private System.Windows.Forms.DataGridView dataGridViewSelect;
        private System.Windows.Forms.GroupBox groupBoxSelect;
        private System.Windows.Forms.RadioButton radioButtonSales;
        private System.Windows.Forms.RadioButton radioButtonProducts;
        private System.Windows.Forms.RadioButton radioButtonWorkers;
        private System.Windows.Forms.TabPage tabPageFullSelect;
        private System.Windows.Forms.DataGridView dataGridViewFullSelect;
        private System.Windows.Forms.GroupBox groupBoxFullSelect;
        private System.Windows.Forms.Button buttonExecuteSelect;
        private System.Windows.Forms.CheckBox checkBoxOrder;
        private System.Windows.Forms.RadioButton radioButtonWithHaving;
        private System.Windows.Forms.RadioButton radioButtonGroupBy;
        private System.Windows.Forms.TabPage tabPageSubquery;
        private System.Windows.Forms.DataGridView dataGridViewSubquery;
        private System.Windows.Forms.GroupBox groupBoxSubquery;
        private System.Windows.Forms.Button buttonSubquery;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.RadioButton radioButtonNonCorrelated;
        private System.Windows.Forms.RadioButton radioButtonCorrelated;
        private System.Windows.Forms.TabPage tabPageDML;
        private System.Windows.Forms.Button buttonSelectProducts;
        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private System.Windows.Forms.GroupBox groupBoxDML;
        private System.Windows.Forms.Panel panelProduct;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Button buttonExecuteDML;
        private System.Windows.Forms.RadioButton radioButtonDelete;
        private System.Windows.Forms.RadioButton radioButtonUpdate;
        private System.Windows.Forms.RadioButton radioButtonInsert;
    }
}