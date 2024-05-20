using demo3.Forms.SecondaryForms;
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
    public partial class Administrator : BaseForm
    {
        Connection db_connection;
        private UpdateDataGrid updateDataGrid = new UpdateDataGrid();
        public Administrator(string login)
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

            string loadDataEmployeersQuery = "select * from employeers";

            MySqlCommand loadDataEmployeers = new MySqlCommand(loadDataEmployeersQuery, db_connection.getConnection());
            MySqlDataAdapter load = new MySqlDataAdapter(loadDataEmployeers);

            DataTable dt = new DataTable();
            load.Fill(dt);
            dataGridEmployeers.DataSource = dt;

            string loadShiftQuery = "select * from shift";

            MySqlCommand loadShift = new MySqlCommand(loadShiftQuery, db_connection.getConnection());
            MySqlDataAdapter shift = new MySqlDataAdapter(loadShift);

            DataTable dtShift = new DataTable();
            shift.Fill(dtShift);
            shiftDataGrid.DataSource = dtShift;

            string loadDataEmployeersSurnameQuery = "select id, name, surname,status from employeers";

            MySqlCommand loadDataEmployeersSurname = new MySqlCommand(loadDataEmployeersSurnameQuery, db_connection.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter(loadDataEmployeersSurname);

            DataTable dt2 = new DataTable();
            adapter.Fill(dt2);
            employeersDataGrid.DataSource = dt2;

            string loadOrdersQuery = "select * from orders";

            MySqlCommand loadOrders = new MySqlCommand(loadOrdersQuery, db_connection.getConnection());
            MySqlDataAdapter load1 = new MySqlDataAdapter(loadOrders);

            DataTable dt3 = new DataTable();
            load1.Fill(dt3);
          
            ordersDataGrid.DataSource = dt3;



        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_registration_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(159, 85, 159);
            Add_employer add_Employer = new Add_employer();
            add_Employer.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            db_connection.OpenConnection();
            button2.BackColor = Color.FromArgb(159, 85, 159);
            if(dataGridEmployeers.SelectedRows.Count > 0)
            {
                string employeeChangeStatus = dataGridEmployeers.SelectedCells[0].Value.ToString();
                string QueryToChangeStatus = $"update employeers set status = 'Уволен' where id = {employeeChangeStatus} ";
                MySqlCommand changeStatus = new MySqlCommand(QueryToChangeStatus, db_connection.getConnection());

                int rowsAffected = changeStatus.ExecuteNonQuery();
                string loadDataEmployeersQuery = "select * from employeers";
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Сотрудник уволен");
                    updateDataGrid.RefreshDataGrid(dataGridEmployeers, loadDataEmployeersQuery);


                }
                else
                    MessageBox.Show("Вы не выбрали сотрудника");

            }
        }

        private void add_shift_Click(object sender, EventArgs e)
        {
            db_connection.OpenConnection();
            add_shift.BackColor = Color.FromArgb(159, 85, 159);
            string shiftTable = "select * from shift";
            if (employeersDataGrid.SelectedRows.Count > 0)
            {
                string employeeAddToShift = employeersDataGrid.SelectedCells[0].Value.ToString();
                string addShift = $"insert into shift (date, workers) values ('{dateTimePicker1.Value.ToString("yy-MM-dd")}','{employeeAddToShift}' )";
                MySqlCommand addToShift = new MySqlCommand(addShift, db_connection.getConnection());
                addToShift.ExecuteNonQuery();
                MessageBox.Show("На смену успешно назначен рабочий");

            }
            else
                MessageBox.Show("Вы не выбрали рабочего");

            updateDataGrid.RefreshDataGrid(shiftDataGrid, shiftTable);
        }
    }
}
