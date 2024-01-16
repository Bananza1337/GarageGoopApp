using System;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;


namespace GarageGoopApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            Text = label1.Text = $"Гаражный кооператив. {Models.AuthorizedUser.User.Роль}";
        }

        private void кооперативBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.кооперативBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.myDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            this.кооперативTableAdapter.Fill(this.myDataSet.Кооператив);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.собственникTableAdapter.Fill(this.myDataSet.Собственник);
            this.члены_кооперативаTableAdapter.Fill(this.myDataSet.Члены_кооператива);
            this.сотрудники_кооперативаTableAdapter.Fill(this.myDataSet.Сотрудники_кооператива);
            this.услугиTableAdapter.Fill(this.myDataSet.Услуги);
            this.кооперативTableAdapter.Fill(this.myDataSet.Кооператив);

            if (Models.AuthorizedUser.User.Роль == "Сотрудник")
            {
                сотрудники_кооперативаDataGridView.ReadOnly = true;
                tabPage2.Controls.Remove(bindingNavigator2);

                услугиDataGridView.ReadOnly = true;
                услугиDataGridView.AllowUserToAddRows = false;
                tabPage1.Controls.Remove(bindingNavigator1);

                menuStrip1.Items.Remove(штрафыToolStripMenuItem);
                menuStrip1.Items.Remove(оборудованиеToolStripMenuItem);
            }
        }

        private void кооперативDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.услугиBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.myDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripButton14_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.сотрудники_кооперативаBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.myDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripButton21_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.члены_кооперативаBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.myDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void собственникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new OwnersForm().ShowDialog();
        }

        private void автомобилиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CarsForm().ShowDialog();
        }

        private void штрафыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FinesForm().ShowDialog();
        }

        private void оборудованиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new EquipmentsForm().ShowDialog();
        }

        private void выполнитьПроизвольныйЗапросToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new MyQueryForm().ShowDialog();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Owner == null)
            {
                Application.Exit();
            }
            else
            {
                Owner.Show();
            }
        }
        internal void GenerateReportWord(string filePath)
        {
            try
            {
                using (WordprocessingDocument wordDocument = WordprocessingDocument.Create(filePath, WordprocessingDocumentType.Document))
                {
                    MainDocumentPart mainPart = wordDocument.AddMainDocumentPart();
                    mainPart.Document = new Document();
                    Body body = mainPart.Document.AppendChild(new Body());

                    // Пример для таблицы Услуги
                    Paragraph tableHeader2 = new Paragraph(new Run(new Text("Таблица 'Услуги':")));
                    body.AppendChild(tableHeader2);

                    foreach (var row in myDataSet.Услуги)
                    {
                        Paragraph rowData = new Paragraph(new Run(new Text($"ID: {row.ID_Услуги}, Название: {row.Наименование}, Цена: {row.Стоимость}")));
                        body.AppendChild(rowData);
                    }

                    

                    MessageBox.Show("Отчет успешно сгенерирован в формате Word.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при формировании отчета: {ex.Message}");
            }
        }





        internal void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовые файлы (*.docx)|*.docx|Все файлы (*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                GenerateReportWord(filePath);
            }
        }
    }
}
