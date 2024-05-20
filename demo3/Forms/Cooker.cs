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

namespace demo3
{
    public partial class Cooker : BaseForm
    {
        Connection db_connection;
        UpdateDataGrid updateData = new UpdateDataGrid();
        public Cooker(string login)
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
                string loadPatronomic = loadData["patronomic"].ToString();

                txt_data_employeer.Text = loadSurname + "\n" + loadName + "\n" + loadPatronomic;
            }
            loadData.Close();

            string loadOrdersQuery = "select * from orders";

            MySqlCommand loadOrders = new MySqlCommand(loadOrdersQuery, db_connection.getConnection());
            MySqlDataAdapter load1 = new MySqlDataAdapter(loadOrders);

            DataTable dt3 = new DataTable();
            load1.Fill(dt3);

            ordersDataGrid.DataSource = dt3;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            db_connection.OpenConnection();
            button1.BackColor = Color.FromArgb(159, 85, 159);
            if(ordersDataGrid.SelectedRows.Count > 0)
            {
                string loadOrdersQuery = "select * from orders";
                string selectedOrder = ordersDataGrid.SelectedCells[0].Value.ToString();
                string changeStatusOrder = $"update orders set status = '{comboBox1.SelectedItem.ToString()}' where id = {selectedOrder}";

                MySqlCommand changeStatus = new MySqlCommand(changeStatusOrder, db_connection.getConnection());
                
                int rowsAffected = changeStatus.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Статус заказа изменен");
                    updateData.RefreshDataGrid(ordersDataGrid, loadOrdersQuery);
                }
                else
                    MessageBox.Show("Вы не выбрали заказ");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
