using System;
using System.Windows.Forms;

namespace GarageGoopApp
{
    public partial class EquipmentsForm : Form
    {
        public EquipmentsForm()
        {
            InitializeComponent();
        }

        private void EquipmentsForm_Load(object sender, EventArgs e)
        {
            this.члены_кооперативаTableAdapter.Fill(this.myDataSet.Члены_кооператива);
            this.оборудование_кооперативаTableAdapter.Fill(this.myDataSet.Оборудование_кооператива);
        }

        private void оборудование_кооперативаBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.оборудование_кооперативаBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.myDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void оборудование_кооперативаDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}