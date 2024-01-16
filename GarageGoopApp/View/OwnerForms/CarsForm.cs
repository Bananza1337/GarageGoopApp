using System;
using System.Linq;
using System.Windows.Forms;

namespace GarageGoopApp.View.OwnerForms
{
    public partial class CarsForm : Form
    {
        private string ownerId;

        public CarsForm()
        {
            InitializeComponent();
        }

        private void CarsForm_Load(object sender, EventArgs e)
        {
            this.автомобильTableAdapter.Fill(this.myDataSet.Автомобиль);
            this.гаражTableAdapter.Fill(this.myDataSet.Гараж);

            var taOwners = new MyDataSetTableAdapters.СобственникTableAdapter();
            taOwners.Fill(myDataSet.Собственник);

            try
            {
                ownerId = myDataSet.Собственник
                    .Where(_ => _.ID_Пользователя == Models.AuthorizedUser.User.ID_пользователя)
                    .FirstOrDefault().ID_Собственника;
            }
            catch { }

            гаражBindingSource.Filter = $"ID_Собственника = '{ownerId}'";
        }

        private void автомобильDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void гаражBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < гаражDataGridView.RowCount; i++)
            {
                гаражDataGridView[3, i].Value = ownerId;
            }

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

            this.гаражTableAdapter.Fill(this.myDataSet.Гараж);
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
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

        private void гаражDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            гаражDataGridView[3, гаражDataGridView.RowCount - 1].Value = ownerId;
        }
    }
}