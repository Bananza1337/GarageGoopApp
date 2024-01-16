using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GarageGoopApp
{
    public partial class MyQueryForm : Form
    {
        public MyQueryForm()
        {
            InitializeComponent();
        }

        private void btnRunQuery_Click(object sender, EventArgs e)
        {
            if (tbQuery.Text.Trim().Length == 0)
            {
                MessageBox.Show("Запрос пуст");
                return;
            }

            try
            {
                using (var connection = new SqlConnection(Properties.Settings.Default.ConnectionString))
                {
                    using (var adapter = new SqlDataAdapter(tbQuery.Text, connection))
                    {
                        var dt = new DataTable();
                        adapter.Fill(dt);
                        dgvResult.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}