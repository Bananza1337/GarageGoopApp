using System;
using System.Windows.Forms;

namespace GarageGoopApp
{
    public partial class OwnersForm : Form
    {
        public OwnersForm()
        {
            InitializeComponent();
        }

        private void собственникBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.собственникBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.myDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            this.собственникTableAdapter.Fill(this.myDataSet.Собственник);
        }

        private void OwnersForm_Load(object sender, EventArgs e)
        {
            this.счетаTableAdapter.Fill(this.myDataSet.Счета);
            this.платежиTableAdapter.Fill(this.myDataSet.Платежи);
            this.гаражTableAdapter.Fill(this.myDataSet.Гараж);
            this.собственникTableAdapter.Fill(this.myDataSet.Собственник);
        }

        private void собственникDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.гаражBindingSource.EndEdit();
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
                this.платежиBindingSource.EndEdit();
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
                this.счетаBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.myDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}