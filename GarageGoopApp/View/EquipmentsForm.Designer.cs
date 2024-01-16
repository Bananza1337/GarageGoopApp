
namespace GarageGoopApp
{
    partial class EquipmentsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EquipmentsForm));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.myDataSet = new GarageGoopApp.MyDataSet();
            this.оборудование_кооперативаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.оборудование_кооперативаTableAdapter = new GarageGoopApp.MyDataSetTableAdapters.Оборудование_кооперативаTableAdapter();
            this.tableAdapterManager = new GarageGoopApp.MyDataSetTableAdapters.TableAdapterManager();
            this.оборудование_кооперативаDataGridView = new System.Windows.Forms.DataGridView();
            this.оборудование_кооперативаBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.оборудование_кооперативаBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.членыкооперативаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.члены_кооперативаTableAdapter = new GarageGoopApp.MyDataSetTableAdapters.Члены_кооперативаTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.оборудование_кооперативаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.оборудование_кооперативаDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.оборудование_кооперативаBindingNavigator)).BeginInit();
            this.оборудование_кооперативаBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.членыкооперативаBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(544, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Оборудование кооператива";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.оборудование_кооперативаBindingNavigator);
            this.groupBox1.Controls.Add(this.оборудование_кооперативаDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(12, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(974, 413);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // myDataSet
            // 
            this.myDataSet.DataSetName = "MyDataSet";
            this.myDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // оборудование_кооперативаBindingSource
            // 
            this.оборудование_кооперативаBindingSource.DataMember = "Оборудование_кооператива";
            this.оборудование_кооперативаBindingSource.DataSource = this.myDataSet;
            // 
            // оборудование_кооперативаTableAdapter
            // 
            this.оборудование_кооперативаTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = GarageGoopApp.MyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АвтомобильTableAdapter = null;
            this.tableAdapterManager.ГаражTableAdapter = null;
            this.tableAdapterManager.КооперативTableAdapter = null;
            this.tableAdapterManager.Оборудование_кооперативаTableAdapter = this.оборудование_кооперативаTableAdapter;
            this.tableAdapterManager.ПлатежиTableAdapter = null;
            this.tableAdapterManager.СобственникTableAdapter = null;
            this.tableAdapterManager.Сотрудники_кооперативаTableAdapter = null;
            this.tableAdapterManager.СчетаTableAdapter = null;
            this.tableAdapterManager.УслугиTableAdapter = null;
            this.tableAdapterManager.Члены_кооперативаTableAdapter = this.члены_кооперативаTableAdapter;
            this.tableAdapterManager.ШтрафыTableAdapter = null;
            // 
            // оборудование_кооперативаDataGridView
            // 
            this.оборудование_кооперативаDataGridView.AllowUserToAddRows = false;
            this.оборудование_кооперативаDataGridView.AllowUserToDeleteRows = false;
            this.оборудование_кооперативаDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.оборудование_кооперативаDataGridView.AutoGenerateColumns = false;
            this.оборудование_кооперативаDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.оборудование_кооперативаDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.оборудование_кооперативаDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.оборудование_кооперативаDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.оборудование_кооперативаDataGridView.DataSource = this.оборудование_кооперативаBindingSource;
            this.оборудование_кооперативаDataGridView.Location = new System.Drawing.Point(6, 44);
            this.оборудование_кооперативаDataGridView.MultiSelect = false;
            this.оборудование_кооперативаDataGridView.Name = "оборудование_кооперативаDataGridView";
            this.оборудование_кооперативаDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.оборудование_кооперативаDataGridView.Size = new System.Drawing.Size(962, 363);
            this.оборудование_кооперативаDataGridView.TabIndex = 0;
            this.оборудование_кооперативаDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.оборудование_кооперативаDataGridView_DataError);
            // 
            // оборудование_кооперативаBindingNavigator
            // 
            this.оборудование_кооперативаBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.оборудование_кооперативаBindingNavigator.BindingSource = this.оборудование_кооперативаBindingSource;
            this.оборудование_кооперативаBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.оборудование_кооперативаBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.оборудование_кооперативаBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.оборудование_кооперативаBindingNavigatorSaveItem});
            this.оборудование_кооперативаBindingNavigator.Location = new System.Drawing.Point(3, 16);
            this.оборудование_кооперативаBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.оборудование_кооперативаBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.оборудование_кооперативаBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.оборудование_кооперативаBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.оборудование_кооперативаBindingNavigator.Name = "оборудование_кооперативаBindingNavigator";
            this.оборудование_кооперативаBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.оборудование_кооперативаBindingNavigator.Size = new System.Drawing.Size(968, 25);
            this.оборудование_кооперативаBindingNavigator.TabIndex = 6;
            this.оборудование_кооперативаBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // оборудование_кооперативаBindingNavigatorSaveItem
            // 
            this.оборудование_кооперативаBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.оборудование_кооперативаBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("оборудование_кооперативаBindingNavigatorSaveItem.Image")));
            this.оборудование_кооперативаBindingNavigatorSaveItem.Name = "оборудование_кооперативаBindingNavigatorSaveItem";
            this.оборудование_кооперативаBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.оборудование_кооперативаBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.оборудование_кооперативаBindingNavigatorSaveItem.Click += new System.EventHandler(this.оборудование_кооперативаBindingNavigatorSaveItem_Click_1);
            // 
            // членыкооперативаBindingSource
            // 
            this.членыкооперативаBindingSource.DataMember = "Члены_кооператива";
            this.членыкооперативаBindingSource.DataSource = this.myDataSet;
            // 
            // члены_кооперативаTableAdapter
            // 
            this.члены_кооперативаTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_Оборудования";
            this.dataGridViewTextBoxColumn1.HeaderText = "Номер оборудования";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Наименование";
            this.dataGridViewTextBoxColumn2.HeaderText = "Наименование";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ID_Члена";
            this.dataGridViewTextBoxColumn3.DataSource = this.членыкооперативаBindingSource;
            this.dataGridViewTextBoxColumn3.DisplayMember = "ID_Члена";
            this.dataGridViewTextBoxColumn3.HeaderText = "Номер члена кооператива";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "ID_Члена";
            // 
            // EquipmentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 498);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "EquipmentsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Оборудование кооператива";
            this.Load += new System.EventHandler(this.EquipmentsForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.оборудование_кооперативаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.оборудование_кооперативаDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.оборудование_кооперативаBindingNavigator)).EndInit();
            this.оборудование_кооперативаBindingNavigator.ResumeLayout(false);
            this.оборудование_кооперативаBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.членыкооперативаBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private MyDataSet myDataSet;
        private System.Windows.Forms.BindingSource оборудование_кооперативаBindingSource;
        private MyDataSetTableAdapters.Оборудование_кооперативаTableAdapter оборудование_кооперативаTableAdapter;
        private MyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator оборудование_кооперативаBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton оборудование_кооперативаBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView оборудование_кооперативаDataGridView;
        private MyDataSetTableAdapters.Члены_кооперативаTableAdapter члены_кооперативаTableAdapter;
        private System.Windows.Forms.BindingSource членыкооперативаBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
    }
}