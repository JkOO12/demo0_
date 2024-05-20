# Шпора

### Описание 
Это шпора для демо экзамена храни вас господь

## Подключение. Класс Connection 

class Connection 
{
    private MySqlConnection connection;
    private string connectionString = "Server=айпи панели; Port=3306; Database=имя базы данных; Uid=логин; Pwd=пароль";

    public Connection()
    {
        connection = new MySqlConnection(connectionString);
    }

    public MySqlConnection getConnection()
    {
        return connection;
    }

    public void OpenConnection()
    {
        if (connection.State == ConnectionState.Closed)
        {
            connection.Open();
        }
    }

    public void CloseConnection()
    {
        if(connection.State == ConnectionState.Open)
        {
            connection.Close();
        }
    }
}

## Пример использования запроса на принятие из сервера Select 

select * from table_name

### Сортировка по получению

select surname, name, patronomic from user where login = '{login}'

### Получение определенных полей
select id, name, surname,status from employeers

## Запрос update. Обновление таблицы
update employeers set status = 'Уволен' where id = {employeeChangeStatus} 

## Запрос insert. Ввод в базу данных

insert into table_name (name, surname) values ('value 1', 'value 2')

## Загрузка данных из базы данных в datagridView

 string loadDataEmployeersQuery = "select * from employeers";

 MySqlCommand loadDataEmployeers = new MySqlCommand(loadDataEmployeersQuery, db_connection.getConnection());
 MySqlDataAdapter load = new MySqlDataAdapter(loadDataEmployeers);

 DataTable dt = new DataTable();
 load.Fill(dt);
 dataGridEmployeers.DataSource = dt;

## Пример того, как зменять поля в БД по выбранному полю в datagrid
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

## Полезная плююшка с обновлением dataGrid 
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

### Пример использования 
  updateDataGrid.RefreshDataGrid(shiftDataGrid, shiftTable);

## Пример загрузки ФИО пользователя в зависимоти от аккаунта
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

## Пример ввода в базу данных 
 string addEmployeeQuery = $"INSERT INTO employeers (role, name, surname, patronomic, login, password, date_last_enter, tine_last_enter, status) VALUES " +
 $"('{cmbx_role.SelectedItem.ToString()}', '{txtbx_Name.Text}', '{txtbx_surname.Text}', " +
 $"'{txtbx_patronomic.Text}', '{txtbx_login.Text}', '{txtbx_password.Text}', " +
 $"'{DateTime.Today.ToString("yyyy-MM-dd")}', '{DateTime.Now.ToString("HH:mm:ss")}', 'Работает')";

 MySqlCommand addEmployee = new MySqlCommand(addEmployeeQuery, dbConnection.getConnection());
 addEmployee.ExecuteNonQuery();

 ### Когда нужно запихнуть результат запроса в переменную 
  string addClientQuery = $"insert into client (name, surname, patronomic, phone, date_birth, email) values ('{txtbx_name.Text}', '{txtbx_surname.Text}', " +
      $"'{txtbs_patronomic.Text}', '{txtbx_phone.Text}', '{dateTimePicker1.Value.ToString("yy-MM-dd")}', '{txtbx_email.Text}')";
  MySqlCommand addClient = new MySqlCommand(addClientQuery, db_connection.getConnection());
  addClient.ExecuteScalar();
      string id = Convert.ToString(getClient.ExecuteScalar());


## Загрузка в chekedListBox
  string loadDishesQuery = "select name from dishes";
  MySqlCommand loadDishes = new MySqlCommand(loadDishesQuery, db_connection.getConnection());
  MySqlDataReader loadDishesReader = loadDishes.ExecuteReader();
  while (loadDishesReader.Read())
  {
      string value = loadDishesReader.GetString(0);
      checkedListBox1.Items.Add(value);
  }
  loadDishesReader.Close();


## Пример загрузки в БД плюшек из chekListBox
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


# Читерский метод если будет возможность загрузить с VPS шаблон проета по ssh 

В консоли windows ssh root@айпи потом ввести пароль - ////

Далее написать в консоль git clone https://github.com/JkOO12/demo0_
 
И далее scp [имя пользователя]@[имя сервера/ip-адрес]:[путь к файлу] [путь к файлу]

scp -r root@123.123.123.123:/home/directory /local/directory это пример ебанаты

# Если будет возможность скачать прямо с гита,через cmd 

git clone https://github.com/JkOO12/demo0_ 

Лучше сначала перейти в какой-то репозиторий на пк и залить туда ,типо скрытнич все дела


