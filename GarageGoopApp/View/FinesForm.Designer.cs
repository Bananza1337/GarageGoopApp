
namespace GarageGoopApp
{
    partial class FinesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinesForm));
            System.Windows.Forms.Label iD_ШтрафаLabel;
            System.Windows.Forms.Label тип_штрафаLabel;
            System.Windows.Forms.Label сумма_штрафаLabel;
            System.Windows.Forms.Label статус_оплатыLabel;
            System.Windows.Forms.Label iD_ЧленаLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.myDataSet = new GarageGoopApp.MyDataSet();
            this.штрафыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.штрафыTableAdapter = new GarageGoopApp.MyDataSetTableAdapters.ШтрафыTableAdapter();
            this.tableAdapterManager = new GarageGoopApp.MyDataSetTableAdapters.TableAdapterManager();
            this.штрафыDataGridView = new System.Windows.Forms.DataGridView();
            this.штрафыBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.штрафыBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iD_ШтрафаTextBox = new System.Windows.Forms.TextBox();
            this.тип_штрафаTextBox = new System.Windows.Forms.TextBox();
            this.сумма_штрафаTextBox = new System.Windows.Forms.TextBox();
            this.статус_оплатыTextBox = new System.Windows.Forms.TextBox();
            this.iD_ЧленаComboBox = new System.Windows.Forms.ComboBox();
            this.членыкооперативаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.члены_кооперативаTableAdapter = new GarageGoopApp.MyDataSetTableAdapters.Члены_кооперативаTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            iD_ШтрафаLabel = new System.Windows.Forms.Label();
            тип_штрафаLabel = new System.Windows.Forms.Label();
            сумма_штрафаLabel = new System.Windows.Forms.Label();
            статус_оплатыLabel = new System.Windows.Forms.Label();
            iD_ЧленаLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.штрафыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.штрафыDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.штрафыBindingNavigator)).BeginInit();
            this.штрафыBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.членыкооперативаBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Штрафы";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(iD_ШтрафаLabel);
            this.groupBox1.Controls.Add(this.iD_ШтрафаTextBox);
            this.groupBox1.Controls.Add(тип_штрафаLabel);
            this.groupBox1.Controls.Add(this.тип_штрафаTextBox);
            this.groupBox1.Controls.Add(сумма_штрафаLabel);
            this.groupBox1.Controls.Add(this.сумма_штрафаTextBox);
            this.groupBox1.Controls.Add(статус_оплатыLabel);
            this.groupBox1.Controls.Add(this.статус_оплатыTextBox);
            this.groupBox1.Controls.Add(iD_ЧленаLabel);
            this.groupBox1.Controls.Add(this.iD_ЧленаComboBox);
            this.groupBox1.Controls.Add(this.штрафыBindingNavigator);
            this.groupBox1.Controls.Add(this.штрафыDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(12, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1174, 390);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // myDataSet
            // 
            this.myDataSet.DataSetName = "MyDataSet";
            this.myDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // штрафыBindingSource
            // 
            this.штрафыBindingSource.DataMember = "Штрафы";
            this.штрафыBindingSource.DataSource = this.myDataSet;
            // 
            // штрафыTableAdapter
            // 
            this.штрафыTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = GarageGoopApp.MyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АвтомобильTableAdapter = null;
            this.tableAdapterManager.ГаражTableAdapter = null;
            this.tableAdapterManager.КооперативTableAdapter = null;
            this.tableAdapterManager.Оборудование_кооперативаTableAdapter = null;
            this.tableAdapterManager.ПлатежиTableAdapter = null;
            this.tableAdapterManager.СобственникTableAdapter = null;
            this.tableAdapterManager.Сотрудники_кооперативаTableAdapter = null;
            this.tableAdapterManager.СчетаTableAdapter = null;
            this.tableAdapterManager.УслугиTableAdapter = null;
            this.tableAdapterManager.Члены_кооперативаTableAdapter = this.члены_кооперативаTableAdapter;
            this.tableAdapterManager.ШтрафыTableAdapter = this.штрафыTableAdapter;
            // 
            // штрафыDataGridView
            // 
            this.штрафыDataGridView.AllowUserToAddRows = false;
            this.штрафыDataGridView.AllowUserToDeleteRows = false;
            this.штрафыDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.штрафыDataGridView.AutoGenerateColumns = false;
            this.штрафыDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.штрафыDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.штрафыDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.штрафыDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.штрафыDataGridView.DataSource = this.штрафыBindingSource;
            this.штрафыDataGridView.Location = new System.Drawing.Point(8, 44);
            this.штрафыDataGridView.MultiSelect = false;
            this.штрафыDataGridView.Name = "штрафыDataGridView";
            this.штрафыDataGridView.ReadOnly = true;
            this.штрафыDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.штрафыDataGridView.Size = new System.Drawing.Size(844, 340);
            this.штрафыDataGridView.TabIndex = 0;
            this.штрафыDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.штрафыDataGridView_DataError);
            // 
            // штрафыBindingNavigator
            // 
            this.штрафыBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.штрафыBindingNavigator.BindingSource = this.штрафыBindingSource;
            this.штрафыBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.штрафыBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.штрафыBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.штрафыBindingNavigatorSaveItem});
            this.штрафыBindingNavigator.Location = new System.Drawing.Point(3, 16);
            this.штрафыBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.штрафыBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.штрафыBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.штрафыBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.штрафыBindingNavigator.Name = "штрафыBindingNavigator";
            this.штрафыBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.штрафыBindingNavigator.Size = new System.Drawing.Size(1168, 25);
            this.штрафыBindingNavigator.TabIndex = 6;
            this.штрафыBindingNavigator.Text = "bindingNavigator1";
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
            // штрафыBindingNavigatorSaveItem
            // 
            this.штрафыBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.штрафыBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("штрафыBindingNavigatorSaveItem.Image")));
            this.штрафыBindingNavigatorSaveItem.Name = "штрафыBindingNavigatorSaveItem";
            this.штрафыBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.штрафыBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.штрафыBindingNavigatorSaveItem.Click += new System.EventHandler(this.штрафыBindingNavigatorSaveItem_Click);
            // 
            // iD_ШтрафаLabel
            // 
            iD_ШтрафаLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            iD_ШтрафаLabel.AutoSize = true;
            iD_ШтрафаLabel.Location = new System.Drawing.Point(871, 59);
            iD_ШтрафаLabel.Name = "iD_ШтрафаLabel";
            iD_ШтрафаLabel.Size = new System.Drawing.Size(86, 13);
            iD_ШтрафаLabel.TabIndex = 6;
            iD_ШтрафаLabel.Text = "Номер штрафа:";
            // 
            // iD_ШтрафаTextBox
            // 
            this.iD_ШтрафаTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iD_ШтрафаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.штрафыBindingSource, "ID_Штрафа", true));
            this.iD_ШтрафаTextBox.Location = new System.Drawing.Point(963, 56);
            this.iD_ШтрафаTextBox.Name = "iD_ШтрафаTextBox";
            this.iD_ШтрафаTextBox.Size = new System.Drawing.Size(199, 20);
            this.iD_ШтрафаTextBox.TabIndex = 7;
            // 
            // тип_штрафаLabel
            // 
            тип_штрафаLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            тип_штрафаLabel.AutoSize = true;
            тип_штрафаLabel.Location = new System.Drawing.Point(871, 85);
            тип_штрафаLabel.Name = "тип_штрафаLabel";
            тип_штрафаLabel.Size = new System.Drawing.Size(71, 13);
            тип_штрафаLabel.TabIndex = 8;
            тип_штрафаLabel.Text = "Тип штрафа:";
            // 
            // тип_штрафаTextBox
            // 
            this.тип_штрафаTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.тип_штрафаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.штрафыBindingSource, "Тип_штрафа", true));
            this.тип_штрафаTextBox.Location = new System.Drawing.Point(963, 82);
            this.тип_штрафаTextBox.Name = "тип_штрафаTextBox";
            this.тип_штрафаTextBox.Size = new System.Drawing.Size(199, 20);
            this.тип_штрафаTextBox.TabIndex = 9;
            // 
            // сумма_штрафаLabel
            // 
            сумма_штрафаLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            сумма_штрафаLabel.AutoSize = true;
            сумма_штрафаLabel.Location = new System.Drawing.Point(871, 111);
            сумма_штрафаLabel.Name = "сумма_штрафаLabel";
            сумма_штрафаLabel.Size = new System.Drawing.Size(86, 13);
            сумма_штрафаLabel.TabIndex = 10;
            сумма_штрафаLabel.Text = "Сумма штрафа:";
            // 
            // сумма_штрафаTextBox
            // 
            this.сумма_штрафаTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.сумма_штрафаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.штрафыBindingSource, "Сумма_штрафа", true));
            this.сумма_штрафаTextBox.Location = new System.Drawing.Point(963, 108);
            this.сумма_штрафаTextBox.Name = "сумма_штрафаTextBox";
            this.сумма_штрафаTextBox.Size = new System.Drawing.Size(199, 20);
            this.сумма_штрафаTextBox.TabIndex = 11;
            // 
            // статус_оплатыLabel
            // 
            статус_оплатыLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            статус_оплатыLabel.AutoSize = true;
            статус_оплатыLabel.Location = new System.Drawing.Point(871, 137);
            статус_оплатыLabel.Name = "статус_оплатыLabel";
            статус_оплатыLabel.Size = new System.Drawing.Size(84, 13);
            статус_оплатыLabel.TabIndex = 12;
            статус_оплатыLabel.Text = "Статус оплаты:";
            // 
            // статус_оплатыTextBox
            // 
            this.статус_оплатыTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.статус_оплатыTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.штрафыBindingSource, "Статус_оплаты", true));
            this.статус_оплатыTextBox.Location = new System.Drawing.Point(963, 134);
            this.статус_оплатыTextBox.Name = "статус_оплатыTextBox";
            this.статус_оплатыTextBox.Size = new System.Drawing.Size(199, 20);
            this.статус_оплатыTextBox.TabIndex = 13;
            // 
            // iD_ЧленаLabel
            // 
            iD_ЧленаLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            iD_ЧленаLabel.AutoSize = true;
            iD_ЧленаLabel.Location = new System.Drawing.Point(871, 163);
            iD_ЧленаLabel.Name = "iD_ЧленаLabel";
            iD_ЧленаLabel.Size = new System.Drawing.Size(144, 13);
            iD_ЧленаLabel.TabIndex = 14;
            iD_ЧленаLabel.Text = "Номер члена кооператива:";
            // 
            // iD_ЧленаComboBox
            // 
            this.iD_ЧленаComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iD_ЧленаComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.штрафыBindingSource, "ID_Члена", true));
            this.iD_ЧленаComboBox.DataSource = this.членыкооперативаBindingSource;
            this.iD_ЧленаComboBox.DisplayMember = "ID_Члена";
            this.iD_ЧленаComboBox.FormattingEnabled = true;
            this.iD_ЧленаComboBox.Location = new System.Drawing.Point(874, 181);
            this.iD_ЧленаComboBox.Name = "iD_ЧленаComboBox";
            this.iD_ЧленаComboBox.Size = new System.Drawing.Size(288, 21);
            this.iD_ЧленаComboBox.TabIndex = 15;
            this.iD_ЧленаComboBox.ValueMember = "ID_Члена";
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
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_Штрафа";
            this.dataGridViewTextBoxColumn1.HeaderText = "Номер штрафа";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Тип_штрафа";
            this.dataGridViewTextBoxColumn2.HeaderText = "Тип штрафа";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Сумма_штрафа";
            this.dataGridViewTextBoxColumn3.HeaderText = "Сумма штрафа";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Статус_оплаты";
            this.dataGridViewTextBoxColumn4.HeaderText = "Статус оплаты";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ID_Члена";
            this.dataGridViewTextBoxColumn5.DataSource = this.членыкооперативаBindingSource;
            this.dataGridViewTextBoxColumn5.DisplayMember = "ID_Члена";
            this.dataGridViewTextBoxColumn5.HeaderText = "Номер члена кооператива";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn5.ValueMember = "ID_Члена";
            // 
            // FinesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 470);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "FinesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Штрафы";
            this.Load += new System.EventHandler(this.FinesForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.штрафыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.штрафыDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.штрафыBindingNavigator)).EndInit();
            this.штрафыBindingNavigator.ResumeLayout(false);
            this.штрафыBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.членыкооперативаBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private MyDataSet myDataSet;
        private System.Windows.Forms.BindingSource штрафыBindingSource;
        private MyDataSetTableAdapters.ШтрафыTableAdapter штрафыTableAdapter;
        private MyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox iD_ШтрафаTextBox;
        private System.Windows.Forms.TextBox тип_штрафаTextBox;
        private System.Windows.Forms.TextBox сумма_штрафаTextBox;
        private System.Windows.Forms.TextBox статус_оплатыTextBox;
        private System.Windows.Forms.ComboBox iD_ЧленаComboBox;
        private System.Windows.Forms.BindingNavigator штрафыBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton штрафыBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView штрафыDataGridView;
        private MyDataSetTableAdapters.Члены_кооперативаTableAdapter члены_кооперативаTableAdapter;
        private System.Windows.Forms.BindingSource членыкооперативаBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn5;
    }
}