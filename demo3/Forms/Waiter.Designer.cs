namespace demo3
{
    partial class Waiter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Waiter));
            this.ordersDataGrid = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtbx_email = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbx_phone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbx_status = new System.Windows.Forms.ComboBox();
            this.btn_add_order = new System.Windows.Forms.Button();
            this.txtbx_num_table = new System.Windows.Forms.TextBox();
            this.txtbx_surname = new System.Windows.Forms.TextBox();
            this.txtbx_count_clients = new System.Windows.Forms.TextBox();
            this.txtbs_patronomic = new System.Windows.Forms.TextBox();
            this.txtbx_name = new System.Windows.Forms.TextBox();
            this.txt_data_employeer = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGrid)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ordersDataGrid
            // 
            this.ordersDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersDataGrid.Location = new System.Drawing.Point(7, 7);
            this.ordersDataGrid.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ordersDataGrid.Name = "ordersDataGrid";
            this.ordersDataGrid.Size = new System.Drawing.Size(910, 428);
            this.ordersDataGrid.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(844, 499);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-2, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(938, 472);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ordersDataGrid);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Size = new System.Drawing.Size(930, 444);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Заказы";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.checkedListBox1);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.txtbx_email);
            this.tabPage2.Controls.Add(this.dateTimePicker1);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.txtbx_phone);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.cmbx_status);
            this.tabPage2.Controls.Add(this.btn_add_order);
            this.tabPage2.Controls.Add(this.txtbx_num_table);
            this.tabPage2.Controls.Add(this.txtbx_surname);
            this.tabPage2.Controls.Add(this.txtbx_count_clients);
            this.tabPage2.Controls.Add(this.txtbs_patronomic);
            this.tabPage2.Controls.Add(this.txtbx_name);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Size = new System.Drawing.Size(930, 444);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Создание заказа";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(201, 39);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(201, 112);
            this.checkedListBox1.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 382);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Email";
            // 
            // txtbx_email
            // 
            this.txtbx_email.Location = new System.Drawing.Point(7, 401);
            this.txtbx_email.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtbx_email.Name = "txtbx_email";
            this.txtbx_email.Size = new System.Drawing.Size(167, 23);
            this.txtbx_email.TabIndex = 13;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(7, 347);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 328);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Дата рождения";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 273);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Телефон";
            // 
            // txtbx_phone
            // 
            this.txtbx_phone.Location = new System.Drawing.Point(12, 291);
            this.txtbx_phone.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtbx_phone.Name = "txtbx_phone";
            this.txtbx_phone.Size = new System.Drawing.Size(167, 23);
            this.txtbx_phone.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 224);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Количество клиентов";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 170);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Номер столика";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 112);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Отчество";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Фамилия";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Имя";
            // 
            // cmbx_status
            // 
            this.cmbx_status.FormattingEnabled = true;
            this.cmbx_status.Items.AddRange(new object[] {
            "Принят",
            "Оплачен"});
            this.cmbx_status.Location = new System.Drawing.Point(201, 188);
            this.cmbx_status.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbx_status.Name = "cmbx_status";
            this.cmbx_status.Size = new System.Drawing.Size(140, 23);
            this.cmbx_status.TabIndex = 3;
            // 
            // btn_add_order
            // 
            this.btn_add_order.ImageKey = "Добавить.png";
            this.btn_add_order.ImageList = this.imageList1;
            this.btn_add_order.Location = new System.Drawing.Point(855, 385);
            this.btn_add_order.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_add_order.Name = "btn_add_order";
            this.btn_add_order.Size = new System.Drawing.Size(63, 53);
            this.btn_add_order.TabIndex = 2;
            this.btn_add_order.UseVisualStyleBackColor = true;
            this.btn_add_order.Click += new System.EventHandler(this.btn_add_order_Click);
            // 
            // txtbx_num_table
            // 
            this.txtbx_num_table.Location = new System.Drawing.Point(12, 188);
            this.txtbx_num_table.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtbx_num_table.Name = "txtbx_num_table";
            this.txtbx_num_table.Size = new System.Drawing.Size(167, 23);
            this.txtbx_num_table.TabIndex = 0;
            // 
            // txtbx_surname
            // 
            this.txtbx_surname.Location = new System.Drawing.Point(12, 85);
            this.txtbx_surname.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtbx_surname.Name = "txtbx_surname";
            this.txtbx_surname.Size = new System.Drawing.Size(167, 23);
            this.txtbx_surname.TabIndex = 0;
            // 
            // txtbx_count_clients
            // 
            this.txtbx_count_clients.Location = new System.Drawing.Point(12, 242);
            this.txtbx_count_clients.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtbx_count_clients.Name = "txtbx_count_clients";
            this.txtbx_count_clients.Size = new System.Drawing.Size(167, 23);
            this.txtbx_count_clients.TabIndex = 0;
            // 
            // txtbs_patronomic
            // 
            this.txtbs_patronomic.Location = new System.Drawing.Point(12, 130);
            this.txtbs_patronomic.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtbs_patronomic.Name = "txtbs_patronomic";
            this.txtbs_patronomic.Size = new System.Drawing.Size(167, 23);
            this.txtbs_patronomic.TabIndex = 0;
            // 
            // txtbx_name
            // 
            this.txtbx_name.Location = new System.Drawing.Point(12, 39);
            this.txtbx_name.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtbx_name.Name = "txtbx_name";
            this.txtbx_name.Size = new System.Drawing.Size(167, 23);
            this.txtbx_name.TabIndex = 0;
            // 
            // txt_data_employeer
            // 
            this.txt_data_employeer.AutoSize = true;
            this.txt_data_employeer.Location = new System.Drawing.Point(12, 479);
            this.txt_data_employeer.Name = "txt_data_employeer";
            this.txt_data_employeer.Size = new System.Drawing.Size(0, 16);
            this.txt_data_employeer.TabIndex = 3;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Добавить.png");
            // 
            // Waiter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 552);
            this.Controls.Add(this.txt_data_employeer);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.MaximumSize = new System.Drawing.Size(949, 591);
            this.MinimumSize = new System.Drawing.Size(949, 591);
            this.Name = "Waiter";
            this.Text = "Waiter";
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGrid)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ordersDataGrid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtbx_count_clients;
        private System.Windows.Forms.TextBox txtbs_patronomic;
        private System.Windows.Forms.TextBox txtbx_name;
        private System.Windows.Forms.Button btn_add_order;
        private System.Windows.Forms.ComboBox cmbx_status;
        private System.Windows.Forms.TextBox txtbx_num_table;
        private System.Windows.Forms.TextBox txtbx_surname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtbx_email;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtbx_phone;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label txt_data_employeer;
        private System.Windows.Forms.ImageList imageList1;
    }
}