using System;
using System.Windows.Forms;

namespace GarageGoopApp
{
    public partial class FinesForm : Form
    {
        public FinesForm()
        {
            InitializeComponent();
        }

        private void штрафыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.штрафыBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.myDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FinesForm_Load(object sender, EventArgs e)
        {
            this.члены_кооперативаTableAdapter.Fill(this.myDataSet.Члены_кооператива);
            this.штрафыTableAdapter.Fill(this.myDataSet.Штрафы);
        }

        private void штрафыDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}