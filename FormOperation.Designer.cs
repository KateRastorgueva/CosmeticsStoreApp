namespace CosmeticsStoreApp
{
    partial class FormOperation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOperation));
            this.cosmeticsStoreDataSet = new CosmeticsStoreApp.CosmeticsStoreDataSet();
            this.операцияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.операцияTableAdapter = new CosmeticsStoreApp.CosmeticsStoreDataSetTableAdapters.ОперацияTableAdapter();
            this.tableAdapterManager = new CosmeticsStoreApp.CosmeticsStoreDataSetTableAdapters.TableAdapterManager();
            this.операцияBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.операцияBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.операцияDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxGoods = new System.Windows.Forms.GroupBox();
            this.продажаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.продажаTableAdapter = new CosmeticsStoreApp.CosmeticsStoreDataSetTableAdapters.ПродажаTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolStripTextBoxFind = new System.Windows.Forms.TextBox();
            this.toolStripButtonFind = new System.Windows.Forms.Button();
            this.toolStripCheckBoxFilter = new System.Windows.Forms.CheckBox();
            this.продажаDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.cosmeticsStoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.операцияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.операцияBindingNavigator)).BeginInit();
            this.операцияBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.операцияDataGridView)).BeginInit();
            this.groupBoxGoods.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.продажаBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.продажаDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cosmeticsStoreDataSet
            // 
            this.cosmeticsStoreDataSet.DataSetName = "CosmeticsStoreDataSet";
            this.cosmeticsStoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // операцияBindingSource
            // 
            this.операцияBindingSource.DataMember = "Операция";
            this.операцияBindingSource.DataSource = this.cosmeticsStoreDataSet;
            // 
            // операцияTableAdapter
            // 
            this.операцияTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = CosmeticsStoreApp.CosmeticsStoreDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ОперацияTableAdapter = this.операцияTableAdapter;
            this.tableAdapterManager.ПокупательTableAdapter = null;
            this.tableAdapterManager.ПоставилTableAdapter = null;
            this.tableAdapterManager.ПоставщикTableAdapter = null;
            this.tableAdapterManager.ПродажаTableAdapter = null;
            this.tableAdapterManager.СотрудникTableAdapter = null;
            this.tableAdapterManager.ТоварTableAdapter = null;
            // 
            // операцияBindingNavigator
            // 
            this.операцияBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.операцияBindingNavigator.BindingSource = this.операцияBindingSource;
            this.операцияBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.операцияBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.операцияBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.операцияBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.операцияBindingNavigatorSaveItem});
            this.операцияBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.операцияBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.операцияBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.операцияBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.операцияBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.операцияBindingNavigator.Name = "операцияBindingNavigator";
            this.операцияBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.операцияBindingNavigator.Size = new System.Drawing.Size(890, 33);
            this.операцияBindingNavigator.TabIndex = 0;
            this.операцияBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Итоговое количество записей";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Первая запись";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Предыдущая запись";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Выбраная запись";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveNextItem.Text = "Следующая запись";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveLastItem.Text = "Переместиться к последнему";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // операцияBindingNavigatorSaveItem
            // 
            this.операцияBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.операцияBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("операцияBindingNavigatorSaveItem.Image")));
            this.операцияBindingNavigatorSaveItem.Name = "операцияBindingNavigatorSaveItem";
            this.операцияBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.операцияBindingNavigatorSaveItem.Text = "Сохранить";
            this.операцияBindingNavigatorSaveItem.Click += new System.EventHandler(this.операцияBindingNavigatorSaveItem_Click);
            // 
            // операцияDataGridView
            // 
            this.операцияDataGridView.AutoGenerateColumns = false;
            this.операцияDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.операцияDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.операцияDataGridView.DataSource = this.операцияBindingSource;
            this.операцияDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.операцияDataGridView.Location = new System.Drawing.Point(3, 22);
            this.операцияDataGridView.Name = "операцияDataGridView";
            this.операцияDataGridView.RowHeadersWidth = 62;
            this.операцияDataGridView.RowTemplate.Height = 28;
            this.операцияDataGridView.Size = new System.Drawing.Size(866, 181);
            this.операцияDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Номер_операции";
            this.dataGridViewTextBoxColumn1.HeaderText = "Номер_операции";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ID_покупателя";
            this.dataGridViewTextBoxColumn2.HeaderText = "ID_покупателя";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Паспорт";
            this.dataGridViewTextBoxColumn3.HeaderText = "Паспорт";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Дата_операции";
            this.dataGridViewTextBoxColumn4.HeaderText = "Дата_операции";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // groupBoxGoods
            // 
            this.groupBoxGoods.Controls.Add(this.продажаDataGridView);
            this.groupBoxGoods.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxGoods.Location = new System.Drawing.Point(0, 416);
            this.groupBoxGoods.Name = "groupBoxGoods";
            this.groupBoxGoods.Size = new System.Drawing.Size(890, 387);
            this.groupBoxGoods.TabIndex = 2;
            this.groupBoxGoods.TabStop = false;
            this.groupBoxGoods.Text = "Товары в чеке";
            // 
            // продажаBindingSource
            // 
            this.продажаBindingSource.DataMember = "FK__Продажа__Номер_о__3B75D760";
            this.продажаBindingSource.DataSource = this.операцияBindingSource;
            // 
            // продажаTableAdapter
            // 
            this.продажаTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.операцияDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(3, 194);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(872, 206);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Операция";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // toolStripTextBoxFind
            // 
            this.toolStripTextBoxFind.Location = new System.Drawing.Point(104, 91);
            this.toolStripTextBoxFind.Name = "toolStripTextBoxFind";
            this.toolStripTextBoxFind.Size = new System.Drawing.Size(100, 26);
            this.toolStripTextBoxFind.TabIndex = 4;
            // 
            // toolStripButtonFind
            // 
            this.toolStripButtonFind.Location = new System.Drawing.Point(253, 79);
            this.toolStripButtonFind.Name = "toolStripButtonFind";
            this.toolStripButtonFind.Size = new System.Drawing.Size(93, 51);
            this.toolStripButtonFind.TabIndex = 5;
            this.toolStripButtonFind.Text = "Поиск";
            this.toolStripButtonFind.UseVisualStyleBackColor = true;
            this.toolStripButtonFind.Click += new System.EventHandler(this.toolStripButtonFind_Click);
            // 
            // toolStripCheckBoxFilter
            // 
            this.toolStripCheckBoxFilter.AutoSize = true;
            this.toolStripCheckBoxFilter.Location = new System.Drawing.Point(417, 91);
            this.toolStripCheckBoxFilter.Name = "toolStripCheckBoxFilter";
            this.toolStripCheckBoxFilter.Size = new System.Drawing.Size(96, 24);
            this.toolStripCheckBoxFilter.TabIndex = 6;
            this.toolStripCheckBoxFilter.Text = "Фильтр";
            this.toolStripCheckBoxFilter.UseVisualStyleBackColor = true;
            this.toolStripCheckBoxFilter.CheckedChanged += new System.EventHandler(this.toolStripCheckBoxFilter_CheckedChanged);
            // 
            // продажаDataGridView
            // 
            this.продажаDataGridView.AutoGenerateColumns = false;
            this.продажаDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.продажаDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.продажаDataGridView.DataSource = this.продажаBindingSource;
            this.продажаDataGridView.Location = new System.Drawing.Point(0, 47);
            this.продажаDataGridView.Name = "продажаDataGridView";
            this.продажаDataGridView.RowHeadersWidth = 62;
            this.продажаDataGridView.RowTemplate.Height = 28;
            this.продажаDataGridView.Size = new System.Drawing.Size(882, 220);
            this.продажаDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Номер_операции";
            this.dataGridViewTextBoxColumn5.HeaderText = "Номер_операции";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Номер_товара";
            this.dataGridViewTextBoxColumn6.HeaderText = "Номер_товара";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // FormOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 803);
            this.Controls.Add(this.toolStripCheckBoxFilter);
            this.Controls.Add(this.toolStripButtonFind);
            this.Controls.Add(this.toolStripTextBoxFind);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxGoods);
            this.Controls.Add(this.операцияBindingNavigator);
            this.Name = "FormOperation";
            this.Text = "FormOperation";
            this.Load += new System.EventHandler(this.FormOperation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cosmeticsStoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.операцияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.операцияBindingNavigator)).EndInit();
            this.операцияBindingNavigator.ResumeLayout(false);
            this.операцияBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.операцияDataGridView)).EndInit();
            this.groupBoxGoods.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.продажаBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.продажаDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CosmeticsStoreDataSet cosmeticsStoreDataSet;
        private System.Windows.Forms.BindingSource операцияBindingSource;
        private CosmeticsStoreDataSetTableAdapters.ОперацияTableAdapter операцияTableAdapter;
        private CosmeticsStoreDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator операцияBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton операцияBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView операцияDataGridView;
        private System.Windows.Forms.GroupBox groupBoxGoods;
        private System.Windows.Forms.BindingSource продажаBindingSource;
        private CosmeticsStoreDataSetTableAdapters.ПродажаTableAdapter продажаTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox toolStripTextBoxFind;
        private System.Windows.Forms.Button toolStripButtonFind;
        private System.Windows.Forms.CheckBox toolStripCheckBoxFilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridView продажаDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}