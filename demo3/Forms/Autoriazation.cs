using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo3
{
    public partial class Autoriazation : BaseForm
    {
        Connection db_connection;
        public Autoriazation()
        {
            InitializeComponent();
            db_connection = new Connection();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            string password = textBox2.Text;
            if (ValidPasswordLogin(login, password))
            {
                string role = GetRole(login);

                if (role == "Официант")
                {
                    Waiter waiter = new Waiter(login);
                    this.Hide();
                    waiter.Show();
                }
                else if (role == "Повар")
                {
                    Cooker cook = new Cooker(login);
                    this.Hide();
                    cook.Show();
                }
                else if (role == "Администратор")
                {
                    Administrator admin = new Administrator(login);
                    this.Hide();
                    admin.Show();
                }
                else
                    MessageBox.Show("Неверный логин или пароль");

            }
         


        }

        private bool ValidPasswordLogin(string login, string password)
        {
            db_connection.OpenConnection();
            string validQuery = $"select count(*) from employeers where login = '{login}' and password = '{password}'";
            MySqlCommand validation = new MySqlCommand(validQuery, db_connection.getConnection());
            int userCount = Convert.ToInt32(validation.ExecuteScalar());

            if (userCount > 0)
            {
                MessageBox.Show("Успешная авторизация");

            }
            else
                MessageBox.Show("Ошибка авторизации!");
            return userCount > 0;
        }

        private string GetRole(string login)
        {
            db_connection.OpenConnection();

            string getRoleQuery = $"select role from employeers where login = '{login}'";
            MySqlCommand roleCheck = new MySqlCommand(getRoleQuery, db_connection.getConnection());
            string role = Convert.ToString(roleCheck.ExecuteScalar());
            return role;
        }
    }
}
