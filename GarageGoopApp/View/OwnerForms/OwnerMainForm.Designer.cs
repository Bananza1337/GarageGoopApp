
namespace GarageGoopApp
{
    partial class OwnerMainForm
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
            System.Windows.Forms.Label имяLabel;
            System.Windows.Forms.Label фамилияLabel;
            System.Windows.Forms.Label адресLabel;
            System.Windows.Forms.Label номер_телефонаLabel;
            System.Windows.Forms.Label электронная_почтаLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OwnerMainForm));
            this.myDataSet = new GarageGoopApp.MyDataSet();
            this.собственникBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.собственникTableAdapter = new GarageGoopApp.MyDataSetTableAdapters.СобственникTableAdapter();
            this.tableAdapterManager = new GarageGoopApp.MyDataSetTableAdapters.TableAdapterManager();
            this.имяTextBox = new System.Windows.Forms.TextBox();
            this.фамилияTextBox = new System.Windows.Forms.TextBox();
            this.адресTextBox = new System.Windows.Forms.TextBox();
            this.номер_телефонаMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.электронная_почтаTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.собственникBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.собственникBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.автомобилиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.платежиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.счетаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.услугиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            имяLabel = new System.Windows.Forms.Label();
            фамилияLabel = new System.Windows.Forms.Label();
            адресLabel = new System.Windows.Forms.Label();
            номер_телефонаLabel = new System.Windows.Forms.Label();
            электронная_почтаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.myDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.собственникBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.собственникBindingNavigator)).BeginInit();
            this.собственникBindingNavigator.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // имяLabel
            // 
            имяLabel.AutoSize = true;
            имяLabel.Location = new System.Drawing.Point(13, 69);
            имяLabel.Name = "имяLabel";
            имяLabel.Size = new System.Drawing.Size(32, 13);
            имяLabel.TabIndex = 1;
            имяLabel.Text = "Имя:";
            // 
            // фамилияLabel
            // 
            фамилияLabel.AutoSize = true;
            фамилияLabel.Location = new System.Drawing.Point(13, 95);
            фамилияLabel.Name = "фамилияLabel";
            фамилияLabel.Size = new System.Drawing.Size(59, 13);
            фамилияLabel.TabIndex = 3;
            фамилияLabel.Text = "Фамилия:";
            // 
            // адресLabel
            // 
            адресLabel.AutoSize = true;
            адресLabel.Location = new System.Drawing.Point(13, 121);
            адресLabel.Name = "адресLabel";
            адресLabel.Size = new System.Drawing.Size(41, 13);
            адресLabel.TabIndex = 5;
            адресLabel.Text = "Адрес:";
            // 
            // номер_телефонаLabel
            // 
            номер_телефонаLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            номер_телефонаLabel.AutoSize = true;
            номер_телефонаLabel.Location = new System.Drawing.Point(13, 190);
            номер_телефонаLabel.Name = "номер_телефонаLabel";
            номер_телефонаLabel.Size = new System.Drawing.Size(96, 13);
            номер_телефонаLabel.TabIndex = 7;
            номер_телефонаLabel.Text = "Номер телефона:";
            // 
            // электронная_почтаLabel
            // 
            электронная_почтаLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            электронная_почтаLabel.AutoSize = true;
            электронная_почтаLabel.Location = new System.Drawing.Point(13, 216);
            электронная_почтаLabel.Name = "электронная_почтаLabel";
            электронная_почтаLabel.Size = new System.Drawing.Size(107, 13);
            электронная_почтаLabel.TabIndex = 9;
            электронная_почтаLabel.Text = "Электронная почта:";
            // 
            // myDataSet
            // 
            this.myDataSet.DataSetName = "MyDataSet";
            this.myDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // собственникBindingSource
            // 
            this.собственникBindingSource.DataMember = "Собственник";
            this.собственникBindingSource.DataSource = this.myDataSet;
            // 
            // собственникTableAdapter
            // 
            this.собственникTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.ПользователиTableAdapter = null;
            this.tableAdapterManager.СобственникTableAdapter = this.собственникTableAdapter;
            this.tableAdapterManager.Сотрудники_кооперативаTableAdapter = null;
            this.tableAdapterManager.СчетаTableAdapter = null;
            this.tableAdapterManager.УслугиTableAdapter = null;
            this.tableAdapterManager.Члены_кооперативаTableAdapter = null;
            this.tableAdapterManager.ШтрафыTableAdapter = null;
            // 
            // имяTextBox
            // 
            this.имяTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.имяTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.собственникBindingSource, "Имя", true));
            this.имяTextBox.Location = new System.Drawing.Point(126, 66);
            this.имяTextBox.Name = "имяTextBox";
            this.имяTextBox.Size = new System.Drawing.Size(325, 20);
            this.имяTextBox.TabIndex = 2;
            // 
            // фамилияTextBox
            // 
            this.фамилияTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.фамилияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.собственникBindingSource, "Фамилия", true));
            this.фамилияTextBox.Location = new System.Drawing.Point(126, 92);
            this.фамилияTextBox.Name = "фамилияTextBox";
            this.фамилияTextBox.Size = new System.Drawing.Size(325, 20);
            this.фамилияTextBox.TabIndex = 4;
            // 
            // адресTextBox
            // 
            this.адресTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.адресTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.собственникBindingSource, "Адрес", true));
            this.адресTextBox.Location = new System.Drawing.Point(126, 118);
            this.адресTextBox.Multiline = true;
            this.адресTextBox.Name = "адресTextBox";
            this.адресTextBox.Size = new System.Drawing.Size(325, 63);
            this.адресTextBox.TabIndex = 6;
            // 
            // номер_телефонаMaskedTextBox
            // 
            this.номер_телефонаMaskedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.номер_телефонаMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.собственникBindingSource, "Номер_телефона", true));
            this.номер_телефонаMaskedTextBox.Location = new System.Drawing.Point(126, 187);
            this.номер_телефонаMaskedTextBox.Mask = "+7 (000) 000-00-00";
            this.номер_телефонаMaskedTextBox.Name = "номер_телефонаMaskedTextBox";
            this.номер_телефонаMaskedTextBox.Size = new System.Drawing.Size(325, 20);
            this.номер_телефонаMaskedTextBox.TabIndex = 8;
            // 
            // электронная_почтаTextBox
            // 
            this.электронная_почтаTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.электронная_почтаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.собственникBindingSource, "Электронная_почта", true));
            this.электронная_почтаTextBox.Location = new System.Drawing.Point(126, 213);
            this.электронная_почтаTextBox.Name = "электронная_почтаTextBox";
            this.электронная_почтаTextBox.Size = new System.Drawing.Size(325, 20);
            this.электронная_почтаTextBox.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.собственникBindingNavigator);
            this.groupBox1.Controls.Add(имяLabel);
            this.groupBox1.Controls.Add(this.электронная_почтаTextBox);
            this.groupBox1.Controls.Add(this.имяTextBox);
            this.groupBox1.Controls.Add(электронная_почтаLabel);
            this.groupBox1.Controls.Add(фамилияLabel);
            this.groupBox1.Controls.Add(this.номер_телефонаMaskedTextBox);
            this.groupBox1.Controls.Add(this.фамилияTextBox);
            this.groupBox1.Controls.Add(номер_телефонаLabel);
            this.groupBox1.Controls.Add(адресLabel);
            this.groupBox1.Controls.Add(this.адресTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(469, 255);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ваши личные данные";
            // 
            // собственникBindingNavigator
            // 
            this.собственникBindingNavigator.AddNewItem = null;
            this.собственникBindingNavigator.BindingSource = this.собственникBindingSource;
            this.собственникBindingNavigator.CountItem = null;
            this.собственникBindingNavigator.DeleteItem = null;
            this.собственникBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.собственникBindingNavigatorSaveItem});
            this.собственникBindingNavigator.Location = new System.Drawing.Point(3, 16);
            this.собственникBindingNavigator.MoveFirstItem = null;
            this.собственникBindingNavigator.MoveLastItem = null;
            this.собственникBindingNavigator.MoveNextItem = null;
            this.собственникBindingNavigator.MovePreviousItem = null;
            this.собственникBindingNavigator.Name = "собственникBindingNavigator";
            this.собственникBindingNavigator.PositionItem = null;
            this.собственникBindingNavigator.Size = new System.Drawing.Size(463, 25);
            this.собственникBindingNavigator.TabIndex = 11;
            this.собственникBindingNavigator.Text = "bindingNavigator1";
            // 
            // собственникBindingNavigatorSaveItem
            // 
            this.собственникBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.собственникBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("собственникBindingNavigatorSaveItem.Image")));
            this.собственникBindingNavigatorSaveItem.Name = "собственникBindingNavigatorSaveItem";
            this.собственникBindingNavigatorSaveItem.Size = new System.Drawing.Size(114, 22);
            this.собственникBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.собственникBindingNavigatorSaveItem.Click += new System.EventHandler(this.собственникBindingNavigatorSaveItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.автомобилиToolStripMenuItem,
            this.платежиToolStripMenuItem,
            this.счетаToolStripMenuItem,
            this.услугиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(493, 29);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // автомобилиToolStripMenuItem
            // 
            this.автомобилиToolStripMenuItem.Name = "автомобилиToolStripMenuItem";
            this.автомобилиToolStripMenuItem.Size = new System.Drawing.Size(111, 25);
            this.автомобилиToolStripMenuItem.Text = "Автомобили";
            this.автомобилиToolStripMenuItem.Click += new System.EventHandler(this.автомобилиToolStripMenuItem_Click);
            // 
            // платежиToolStripMenuItem
            // 
            this.платежиToolStripMenuItem.Name = "платежиToolStripMenuItem";
            this.платежиToolStripMenuItem.Size = new System.Drawing.Size(85, 25);
            this.платежиToolStripMenuItem.Text = "Платежи";
            this.платежиToolStripMenuItem.Click += new System.EventHandler(this.платежиToolStripMenuItem_Click);
            // 
            // счетаToolStripMenuItem
            // 
            this.счетаToolStripMenuItem.Name = "счетаToolStripMenuItem";
            this.счетаToolStripMenuItem.Size = new System.Drawing.Size(64, 25);
            this.счетаToolStripMenuItem.Text = "Счета";
            this.счетаToolStripMenuItem.Click += new System.EventHandler(this.счетаToolStripMenuItem_Click);
            // 
            // услугиToolStripMenuItem
            // 
            this.услугиToolStripMenuItem.Name = "услугиToolStripMenuItem";
            this.услугиToolStripMenuItem.Size = new System.Drawing.Size(69, 25);
            this.услугиToolStripMenuItem.Text = "Услуги";
            this.услугиToolStripMenuItem.Click += new System.EventHandler(this.услугиToolStripMenuItem_Click);
            // 
            // OwnerMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 312);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Name = "OwnerMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Гаражный кооператив";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OwnerMainForm_FormClosing);
            this.Load += new System.EventHandler(this.OwnerMainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.собственникBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.собственникBindingNavigator)).EndInit();
            this.собственникBindingNavigator.ResumeLayout(false);
            this.собственникBindingNavigator.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyDataSet myDataSet;
        private System.Windows.Forms.BindingSource собственникBindingSource;
        private MyDataSetTableAdapters.СобственникTableAdapter собственникTableAdapter;
        private MyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox имяTextBox;
        private System.Windows.Forms.TextBox фамилияTextBox;
        private System.Windows.Forms.TextBox адресTextBox;
        private System.Windows.Forms.MaskedTextBox номер_телефонаMaskedTextBox;
        private System.Windows.Forms.TextBox электронная_почтаTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingNavigator собственникBindingNavigator;
        private System.Windows.Forms.ToolStripButton собственникBindingNavigatorSaveItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem автомобилиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem платежиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem счетаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem услугиToolStripMenuItem;
    }
}