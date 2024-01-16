using System;
using System.Linq;
using System.Windows.Forms;

namespace GarageGoopApp.View.OwnerForms
{
    public partial class BillsForm : Form
    {
        private string ownerId;

        public BillsForm()
        {
            InitializeComponent();
        }

        private void счетаBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < счетаDataGridView.RowCount; i++)
            {
                счетаDataGridView[4, i].Value = ownerId;
            }

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

        private void BillsForm_Load(object sender, EventArgs e)
        {
            this.счетаTableAdapter.Fill(this.myDataSet.Счета);

            var taOwners = new MyDataSetTableAdapters.СобственникTableAdapter();
            taOwners.Fill(myDataSet.Собственник);

            try
            {
                ownerId = myDataSet.Собственник
                    .Where(_ => _.ID_Пользователя == Models.AuthorizedUser.User.ID_пользователя)
                    .FirstOrDefault().ID_Собственника;
            }
            catch { }

            счетаBindingSource.Filter = $"ID_Собственника = '{ownerId}'";
        }

        private void счетаDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            счетаDataGridView[4, счетаDataGridView.RowCount - 1].Value = ownerId;
        }
    }
}