using System;
using System.Linq;
using System.Windows.Forms;

namespace GarageGoopApp.View.OwnerForms
{
    public partial class ServicesForm : Form
    {
        private string ownerId;

        public ServicesForm()
        {
            InitializeComponent();
        }

        private void ServicesForm_Load(object sender, EventArgs e)
        {
            var taOwners = new MyDataSetTableAdapters.СобственникTableAdapter();
            taOwners.Fill(myDataSet.Собственник);

            try
            {
                ownerId = myDataSet.Собственник
                    .Where(_ => _.ID_Пользователя == Models.AuthorizedUser.User.ID_пользователя)
                    .FirstOrDefault().ID_Собственника;
            }
            catch { }

            try
            {
                this.моиУслугиTableAdapter.Fill(this.myDataSet.МоиУслуги, ownerId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}