using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo3
{
    internal class UpdateDataGrid
    {
        Connection db_connecion;
        
        public void RefreshDataGrid(DataGridView dataGridView,string query)
        {
            db_connecion = new Connection();
            db_connecion.OpenConnection();

            MySqlCommand updateDataGrid = new MySqlCommand(query, db_connecion.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter(updateDataGrid);

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView.DataSource = dt;
        }
    }
}
