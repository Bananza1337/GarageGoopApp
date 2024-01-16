
namespace GarageGoopApp
{
    partial class CarsForm
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
            System.Windows.Forms.Label iD_АвтомобиляLabel;
            System.Windows.Forms.Label маркаLabel;
            System.Windows.Forms.Label модельLabel;
            System.Windows.Forms.Label год_выпускаLabel;
            System.Windows.Forms.Label vIN_номерLabel;
            System.Windows.Forms.Label iD_ГаражаLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarsForm));
            this.label1 = new System.Windows.Forms.Label();
            this.myDataSet = new GarageGoopApp.MyDataSet();
            this.автомобильBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.автомобильTableAdapter = new GarageGoopApp.MyDataSetTableAdapters.АвтомобильTableAdapter();
            this.tableAdapterManager = new GarageGoopApp.MyDataSetTableAdapters.TableAdapterManager();
            this.гаражTableAdapter = new GarageGoopApp.MyDataSetTableAdapters.ГаражTableAdapter();
            this.автомобильDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.гаражBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.iD_АвтомобиляTextBox = new System.Windows.Forms.TextBox();
            this.маркаTextBox = new System.Windows.Forms.TextBox();
            this.модельTextBox = new System.Windows.Forms.TextBox();
            this.год_выпускаTextBox = new System.Windows.Forms.TextBox();
            this.vIN_номерMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.iD_ГаражаComboBox = new System.Windows.Forms.ComboBox();
            this.автомобильBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.автомобильBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            iD_АвтомобиляLabel = new System.Windows.Forms.Label();
            маркаLabel = new System.Windows.Forms.Label();
            модельLabel = new System.Windows.Forms.Label();
            год_выпускаLabel = new System.Windows.Forms.Label();
            vIN_номерLabel = new System.Windows.Forms.Label();
            iD_ГаражаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.myDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.автомобильBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.автомобильDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.гаражBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.автомобильBindingNavigator)).BeginInit();
            this.автомобильBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // iD_АвтомобиляLabel
            // 
            iD_АвтомобиляLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            iD_АвтомобиляLabel.AutoSize = true;
            iD_АвтомобиляLabel.Location = new System.Drawing.Point(773, 56);
            iD_АвтомобиляLabel.Name = "iD_АвтомобиляLabel";
            iD_АвтомобиляLabel.Size = new System.Drawing.Size(108, 13);
            iD_АвтомобиляLabel.TabIndex = 3;
            iD_АвтомобиляLabel.Text = "Номер автомобиля:";
            // 
            // маркаLabel
            // 
            маркаLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            маркаLabel.AutoSize = true;
            маркаLabel.Location = new System.Drawing.Point(773, 82);
            маркаLabel.Name = "маркаLabel";
            маркаLabel.Size = new System.Drawing.Size(43, 13);
            маркаLabel.TabIndex = 5;
            маркаLabel.Text = "Марка:";
            // 
            // модельLabel
            // 
            модельLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            модельLabel.AutoSize = true;
            модельLabel.Location = new System.Drawing.Point(773, 108);
            модельLabel.Name = "модельLabel";
            модельLabel.Size = new System.Drawing.Size(49, 13);
            модельLabel.TabIndex = 7;
            модельLabel.Text = "Модель:";
            // 
            // год_выпускаLabel
            // 
            год_выпускаLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            год_выпускаLabel.AutoSize = true;
            год_выпускаLabel.Location = new System.Drawing.Point(773, 134);
            год_выпускаLabel.Name = "год_выпускаLabel";
            год_выпускаLabel.Size = new System.Drawing.Size(74, 13);
            год_выпускаLabel.TabIndex = 9;
            год_выпускаLabel.Text = "Год выпуска:";
            // 
            // vIN_номерLabel
            // 
            vIN_номерLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            vIN_номерLabel.AutoSize = true;
            vIN_номерLabel.Location = new System.Drawing.Point(773, 160);
            vIN_номерLabel.Name = "vIN_номерLabel";
            vIN_номерLabel.Size = new System.Drawing.Size(63, 13);
            vIN_номерLabel.TabIndex = 11;
            vIN_номерLabel.Text = "VIN-номер:";
            // 
            // iD_ГаражаLabel
            // 
            iD_ГаражаLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            iD_ГаражаLabel.AutoSize = true;
            iD_ГаражаLabel.Location = new System.Drawing.Point(773, 186);
            iD_ГаражаLabel.Name = "iD_ГаражаLabel";
            iD_ГаражаLabel.Size = new System.Drawing.Size(84, 13);
            iD_ГаражаLabel.TabIndex = 13;
            iD_ГаражаLabel.Text = "Номер гаража:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Автомобили";
            // 
            // myDataSet
            // 
            this.myDataSet.DataSetName = "MyDataSet";
            this.myDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // автомобильBindingSource
            // 
            this.автомобильBindingSource.DataMember = "Автомобиль";
            this.автомобильBindingSource.DataSource = this.myDataSet;
            // 
            // автомобильTableAdapter
            // 
            this.автомобильTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = GarageGoopApp.MyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АвтомобильTableAdapter = this.автомобильTableAdapter;
            this.tableAdapterManager.ГаражTableAdapter = this.гаражTableAdapter;
            this.tableAdapterManager.КооперативTableAdapter = null;
            this.tableAdapterManager.Оборудование_кооперативаTableAdapter = null;
            this.tableAdapterManager.ПлатежиTableAdapter = null;
            this.tableAdapterManager.СобственникTableAdapter = null;
            this.tableAdapterManager.Сотрудники_кооперативаTableAdapter = null;
            this.tableAdapterManager.СчетаTableAdapter = null;
            this.tableAdapterManager.УслугиTableAdapter = null;
            this.tableAdapterManager.Члены_кооперативаTableAdapter = null;
            this.tableAdapterManager.ШтрафыTableAdapter = null;
            // 
            // гаражTableAdapter
            // 
            this.гаражTableAdapter.ClearBeforeFill = true;
            // 
            // автомобильDataGridView
            // 
            this.автомобильDataGridView.AllowUserToAddRows = false;
            this.автомобильDataGridView.AllowUserToDeleteRows = false;
            this.автомобильDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.автомобильDataGridView.AutoGenerateColumns = false;
            this.автомобильDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.автомобильDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.автомобильDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.автомобильDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.автомобильDataGridView.DataSource = this.автомобильBindingSource;
            this.автомобильDataGridView.Location = new System.Drawing.Point(3, 44);
            this.автомобильDataGridView.MultiSelect = false;
            this.автомобильDataGridView.Name = "автомобильDataGridView";
            this.автомобильDataGridView.ReadOnly = true;
            this.автомобильDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.автомобильDataGridView.Size = new System.Drawing.Size(754, 354);
            this.автомобильDataGridView.TabIndex = 2;
            this.автомобильDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.автомобильDataGridView_DataError);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_Автомобиля";
            this.dataGridViewTextBoxColumn1.HeaderText = "Номер автомобиля";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Марка";
            this.dataGridViewTextBoxColumn2.HeaderText = "Марка";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Модель";
            this.dataGridViewTextBoxColumn3.HeaderText = "Модель";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Год_выпуска";
            this.dataGridViewTextBoxColumn4.HeaderText = "Год выпуска";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "VIN-номер";
            this.dataGridViewTextBoxColumn5.HeaderText = "VIN-номер";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ID_Гаража";
            this.dataGridViewTextBoxColumn6.DataSource = this.гаражBindingSource;
            this.dataGridViewTextBoxColumn6.DisplayMember = "ID_Гаража";
            this.dataGridViewTextBoxColumn6.HeaderText = "Номер гаража";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn6.ValueMember = "ID_Гаража";
            // 
            // гаражBindingSource
            // 
            this.гаражBindingSource.DataMember = "Гараж";
            this.гаражBindingSource.DataSource = this.myDataSet;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(iD_АвтомобиляLabel);
            this.groupBox1.Controls.Add(this.iD_АвтомобиляTextBox);
            this.groupBox1.Controls.Add(маркаLabel);
            this.groupBox1.Controls.Add(this.маркаTextBox);
            this.groupBox1.Controls.Add(модельLabel);
            this.groupBox1.Controls.Add(this.модельTextBox);
            this.groupBox1.Controls.Add(год_выпускаLabel);
            this.groupBox1.Controls.Add(this.год_выпускаTextBox);
            this.groupBox1.Controls.Add(vIN_номерLabel);
            this.groupBox1.Controls.Add(this.vIN_номерMaskedTextBox);
            this.groupBox1.Controls.Add(iD_ГаражаLabel);
            this.groupBox1.Controls.Add(this.iD_ГаражаComboBox);
            this.groupBox1.Controls.Add(this.автомобильBindingNavigator);
            this.groupBox1.Controls.Add(this.автомобильDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(12, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1104, 404);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // iD_АвтомобиляTextBox
            // 
            this.iD_АвтомобиляTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iD_АвтомобиляTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.автомобильBindingSource, "ID_Автомобиля", true));
            this.iD_АвтомобиляTextBox.Location = new System.Drawing.Point(887, 53);
            this.iD_АвтомобиляTextBox.Name = "iD_АвтомобиляTextBox";
            this.iD_АвтомобиляTextBox.Size = new System.Drawing.Size(205, 20);
            this.iD_АвтомобиляTextBox.TabIndex = 4;
            // 
            // маркаTextBox
            // 
            this.маркаTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.маркаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.автомобильBindingSource, "Марка", true));
            this.маркаTextBox.Location = new System.Drawing.Point(887, 79);
            this.маркаTextBox.Name = "маркаTextBox";
            this.маркаTextBox.Size = new System.Drawing.Size(205, 20);
            this.маркаTextBox.TabIndex = 6;
            // 
            // модельTextBox
            // 
            this.модельTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.модельTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.автомобильBindingSource, "Модель", true));
            this.модельTextBox.Location = new System.Drawing.Point(887, 105);
            this.модельTextBox.Name = "модельTextBox";
            this.модельTextBox.Size = new System.Drawing.Size(205, 20);
            this.модельTextBox.TabIndex = 8;
            // 
            // год_выпускаTextBox
            // 
            this.год_выпускаTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.год_выпускаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.автомобильBindingSource, "Год_выпуска", true));
            this.год_выпускаTextBox.Location = new System.Drawing.Point(887, 131);
            this.год_выпускаTextBox.Name = "год_выпускаTextBox";
            this.год_выпускаTextBox.Size = new System.Drawing.Size(205, 20);
            this.год_выпускаTextBox.TabIndex = 10;
            // 
            // vIN_номерMaskedTextBox
            // 
            this.vIN_номерMaskedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.vIN_номерMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.автомобильBindingSource, "VIN-номер", true));
            this.vIN_номерMaskedTextBox.Location = new System.Drawing.Point(887, 157);
            this.vIN_номерMaskedTextBox.Mask = ">00LL000LLL00";
            this.vIN_номерMaskedTextBox.Name = "vIN_номерMaskedTextBox";
            this.vIN_номерMaskedTextBox.Size = new System.Drawing.Size(205, 20);
            this.vIN_номерMaskedTextBox.TabIndex = 12;
            // 
            // iD_ГаражаComboBox
            // 
            this.iD_ГаражаComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iD_ГаражаComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.автомобильBindingSource, "ID_Гаража", true));
            this.iD_ГаражаComboBox.DataSource = this.гаражBindingSource;
            this.iD_ГаражаComboBox.DisplayMember = "ID_Гаража";
            this.iD_ГаражаComboBox.FormattingEnabled = true;
            this.iD_ГаражаComboBox.Location = new System.Drawing.Point(887, 183);
            this.iD_ГаражаComboBox.Name = "iD_ГаражаComboBox";
            this.iD_ГаражаComboBox.Size = new System.Drawing.Size(205, 21);
            this.iD_ГаражаComboBox.TabIndex = 14;
            this.iD_ГаражаComboBox.ValueMember = "ID_Гаража";
            // 
            // автомобильBindingNavigator
            // 
            this.автомобильBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.автомобильBindingNavigator.BindingSource = this.автомобильBindingSource;
            this.автомобильBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.автомобильBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.автомобильBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.автомобильBindingNavigatorSaveItem});
            this.автомобильBindingNavigator.Location = new System.Drawing.Point(3, 16);
            this.автомобильBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.автомобильBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.автомобильBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.автомобильBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.автомобильBindingNavigator.Name = "автомобильBindingNavigator";
            this.автомобильBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.автомобильBindingNavigator.Size = new System.Drawing.Size(1098, 25);
            this.автомобильBindingNavigator.TabIndex = 3;
            this.автомобильBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
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
            // автомобильBindingNavigatorSaveItem
            // 
            this.автомобильBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.автомобильBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("автомобильBindingNavigatorSaveItem.Image")));
            this.автомобильBindingNavigatorSaveItem.Name = "автомобильBindingNavigatorSaveItem";
            this.автомобильBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.автомобильBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.автомобильBindingNavigatorSaveItem.Click += new System.EventHandler(this.автомобильBindingNavigatorSaveItem_Click);
            // 
            // CarsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 484);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "CarsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Автомобили";
            this.Load += new System.EventHandler(this.CarsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.автомобильBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.автомобильDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.гаражBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.автомобильBindingNavigator)).EndInit();
            this.автомобильBindingNavigator.ResumeLayout(false);
            this.автомобильBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MyDataSet myDataSet;
        private System.Windows.Forms.BindingSource автомобильBindingSource;
        private MyDataSetTableAdapters.АвтомобильTableAdapter автомобильTableAdapter;
        private MyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView автомобильDataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingNavigator автомобильBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton автомобильBindingNavigatorSaveItem;
        private MyDataSetTableAdapters.ГаражTableAdapter гаражTableAdapter;
        private System.Windows.Forms.BindingSource гаражBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TextBox iD_АвтомобиляTextBox;
        private System.Windows.Forms.TextBox маркаTextBox;
        private System.Windows.Forms.TextBox модельTextBox;
        private System.Windows.Forms.TextBox год_выпускаTextBox;
        private System.Windows.Forms.MaskedTextBox vIN_номерMaskedTextBox;
        private System.Windows.Forms.ComboBox iD_ГаражаComboBox;
    }
}