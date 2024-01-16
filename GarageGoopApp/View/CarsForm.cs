using System;
using System.Windows.Forms;

namespace GarageGoopApp
{
    public partial class CarsForm : Form
    {
        public CarsForm()
        {
            InitializeComponent();
        }

        private void автомобильBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.автомобильBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.myDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CarsForm_Load(object sender, EventArgs e)
        {
            this.гаражTableAdapter.Fill(this.myDataSet.Гараж);
            this.автомобильTableAdapter.Fill(this.myDataSet.Автомобиль);
        }

        private void автомобильDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}