using System;
using System.Windows.Forms;

namespace GarageGoopApp
{
    public partial class OwnerMainForm : Form
    {
        public OwnerMainForm()
        {
            InitializeComponent();

            Text = $"Гаражный кооператив. {Models.AuthorizedUser.User.Роль}";
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
            }
        }

        private void OwnerMainForm_Load(object sender, EventArgs e)
        {
            this.собственникTableAdapter.Fill(this.myDataSet.Собственник);
            собственникBindingSource.Filter = $"ID_Пользователя = {Models.AuthorizedUser.User.ID_пользователя}";
        }

        private void OwnerMainForm_FormClosing(object sender, FormClosingEventArgs e)
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

        private void автомобилиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new View.OwnerForms.CarsForm().ShowDialog();
        }

        private void платежиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new View.OwnerForms.PaymentsForm().ShowDialog();
        }

        private void счетаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new View.OwnerForms.BillsForm().ShowDialog();
        }

        private void услугиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new View.OwnerForms.ServicesForm().ShowDialog();
        }
    }
}