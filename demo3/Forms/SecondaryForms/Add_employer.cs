using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo3.Forms.SecondaryForms
{
    public partial class Add_employer : BaseForm
    {
        Connection dbConnection;
        public Add_employer()
        {
            InitializeComponent();
            dbConnection = new Connection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dbConnection.OpenConnection();
            button1.BackColor = Color.FromArgb(159, 85, 159);
            if (string.IsNullOrEmpty(txtbx_Name.Text) || string.IsNullOrEmpty(txtbx_surname.Text) || string.IsNullOrEmpty(txtbx_login.Text) || string.IsNullOrEmpty(txtbx_password.Text))
            {
                MessageBox.Show("Необходимо заполнить все обязательные поля.");
            }
            else
            {

                string addEmployeeQuery = $"INSERT INTO employeers (role, name, surname, patronomic, login, password, date_last_enter, tine_last_enter, status) VALUES " +
                $"('{cmbx_role.SelectedItem.ToString()}', '{txtbx_Name.Text}', '{txtbx_surname.Text}', " +
                $"'{txtbx_patronomic.Text}', '{txtbx_login.Text}', '{txtbx_password.Text}', " +
                $"'{DateTime.Today.ToString("yyyy-MM-dd")}', '{DateTime.Now.ToString("HH:mm:ss")}', 'Работает')";

                MySqlCommand addEmployee = new MySqlCommand(addEmployeeQuery, dbConnection.getConnection());
                addEmployee.ExecuteNonQuery();

            }




        }
    }
}
