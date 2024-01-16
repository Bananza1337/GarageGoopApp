using System;
using System.Linq;
using System.Windows.Forms;

namespace GarageGoopApp.View.OwnerForms
{
    public partial class PaymentsForm : Form
    {
        private string ownerId;

        public PaymentsForm()
        {
            InitializeComponent();
        }

        private void платежиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < платежиDataGridView.RowCount; i++)
            {
                платежиDataGridView[3, i].Value = ownerId;
            }

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

        private void PaymentsForm_Load(object sender, EventArgs e)
        {
            this.платежиTableAdapter.Fill(this.myDataSet.Платежи);

            var taOwners = new MyDataSetTableAdapters.СобственникTableAdapter();
            taOwners.Fill(myDataSet.Собственник);

            try
            {
                ownerId = myDataSet.Собственник
                    .Where(_ => _.ID_Пользователя == Models.AuthorizedUser.User.ID_пользователя)
                    .FirstOrDefault().ID_Собственника;
            }
            catch { }

            платежиBindingSource.Filter = $"ID_Собственника = '{ownerId}'";
        }

        private void платежиDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            платежиDataGridView[3, платежиDataGridView.RowCount - 1].Value = ownerId;
        }
    }
}