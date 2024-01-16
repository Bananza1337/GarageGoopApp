using GarageGoopApp.Models;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GarageGoopApp
{
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
        }
        public void SetLoginAndPasswordForTest(string login, string password)
        {
            tbLogin.Text = login;
            tbPassword.Text = password;
        }
        public bool IsHidden
        {
            get { return this.Visible == false; }
        }

        public Form MainForm { get; private set; }

        public Form GetMainForm()
        {
            // Ваш код для получения главной формы
            // Например, если у вас есть свойство MainForm у формы AuthorizationForm
            return this.MainForm;
        }

        // Метод для выполнения действий при нажатии кнопки входа
        public void PerformLoginAction()
        {
            btnLogin_Click(null, EventArgs.Empty);
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbLogin.Text.Trim().Length == 0)
            {
                MessageBox.Show("Заполните логин");
                return;
            }
            if (tbPassword.Text.Trim().Length == 0)
            {
                MessageBox.Show("Заполните пароль");
                return;
            }

            var ds = new MyDataSet();
            var ta = new MyDataSetTableAdapters.ПользователиTableAdapter();

            ta.Fill(ds.Пользователи);

            var user = ds.Пользователи.Where(_ => _.Имя_пользователя == tbLogin.Text).FirstOrDefault();

            if (user == null)
            {
                MessageBox.Show("Пользователя с заданным логином не существует");
                return;
            }
            if (user.Пароль != tbPassword.Text)
            {
                MessageBox.Show("Пароль пользователя задан не верно");
                return;
            }

            AuthorizedUser.User = user;

            tbLogin.Clear();
            tbPassword.Clear();

            switch (user.Роль)
            {
                case "Администратор":
                    new MainForm() { Owner = this }.Show();
                    break;
                case "Собственник":
                    new OwnerMainForm() { Owner = this }.Show();
                    break;
                case "Сотрудник":
                    new MainForm() { Owner = this }.Show();
                    break;
                case "Директор кооператива":
                    new MainForm() { Owner = this }.Show();
                    break;
            }

            Hide();
        }
    }
}