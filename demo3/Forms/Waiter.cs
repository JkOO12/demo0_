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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace demo3
{
    public partial class Waiter : BaseForm
    {
        Connection db_connection;
        public Waiter(string login)
        {
            InitializeComponent();
            db_connection = new Connection();
            db_connection.OpenConnection();

            string loadDataEmployeer = $"select surname, name, patronomic from employeers where login = '{login}'";
            MySqlCommand loadEmployeers = new MySqlCommand(loadDataEmployeer, db_connection.getConnection());
            MySqlDataReader loadData = loadEmployeers.ExecuteReader();

            if (loadData.Read())
            {
                string loadSurname = loadData["surname"].ToString();
                string loadName = loadData["name"].ToString();
                string loadPatronomic = loadData["patronomic"].ToString() ;

                txt_data_employeer.Text = loadSurname + "\n" + loadName + "\n" + loadPatronomic;
            }
            loadData.Close();

            string loadOrdersQuery = "select * from orders";

            MySqlCommand loadOrders = new MySqlCommand(loadOrdersQuery, db_connection.getConnection());
            MySqlDataAdapter load1 = new MySqlDataAdapter(loadOrders);

            DataTable dt3 = new DataTable();
            load1.Fill(dt3);

            ordersDataGrid.DataSource = dt3;

            string loadDishesQuery = "select name from dishes";
            MySqlCommand loadDishes = new MySqlCommand(loadDishesQuery, db_connection.getConnection());
            MySqlDataReader loadDishesReader = loadDishes.ExecuteReader();
            while (loadDishesReader.Read())
            {
                string value = loadDishesReader.GetString(0);
                checkedListBox1.Items.Add(value);
            }
            loadDishesReader.Close();


        }

        private void btn_add_order_Click(object sender, EventArgs e)
        {
            db_connection.OpenConnection();
            btn_add_order.BackColor = Color.FromArgb(159, 85, 159);

            string addClientQuery = $"insert into client (name, surname, patronomic, phone, date_birth, email) values ('{txtbx_name.Text}', '{txtbx_surname.Text}', " +
                $"'{txtbs_patronomic.Text}', '{txtbx_phone.Text}', '{dateTimePicker1.Value.ToString("yy-MM-dd")}', '{txtbx_email.Text}')";
            MySqlCommand addClient = new MySqlCommand(addClientQuery, db_connection.getConnection());
            addClient.ExecuteScalar();

            string getLastClient = $"SELECT id FROM client ORDER BY id DESC LIMIT 1;";
            MySqlCommand getClient = new MySqlCommand(getLastClient, db_connection.getConnection());
            string id = Convert.ToString(getClient.ExecuteScalar());
            string codeOrder = id + "/" + DateTime.Today.ToString("yyyy-MM-dd");
            string selectedDishes = "";

            foreach(object item in checkedListBox1.CheckedItems)
            {
                selectedDishes += item.ToString();
            }

            if(!string.IsNullOrEmpty(selectedDishes) )
            {
                selectedDishes = selectedDishes.Remove(selectedDishes.Length - 1);
            }
            string addOrder = $"INSERT INTO orders (code_order, date_add, time_add, id_client, dishes, status, table_num, count_clients) VALUES " +
     $"('{codeOrder}', '{DateTime.Today.ToString("yyyy-MM-dd")}', '{DateTime.Now.ToString("HH:mm:ss")}', {id}, @dishes, '{cmbx_status.SelectedItem.ToString()}', '{txtbx_num_table.Text}', '{txtbx_count_clients.Text}')";

            MySqlCommand addOrders = new MySqlCommand(addOrder, db_connection.getConnection());
            addOrders.Parameters.AddWithValue("@dishes", selectedDishes);
            addOrders.ExecuteNonQuery();
            

        }
    }
}
