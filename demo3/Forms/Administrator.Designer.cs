namespace demo3
{
    partial class Administrator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administrator));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridEmployeers = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_registration = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.employeersDataGrid = new System.Windows.Forms.DataGridView();
            this.add_shift = new System.Windows.Forms.Button();
            this.shiftDataGrid = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.ordersDataGrid = new System.Windows.Forms.DataGridView();
            this.btn_exit = new System.Windows.Forms.Button();
            this.txt_data_employeer = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmployeers)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeersDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shiftDataGrid)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(-2, -1);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(938, 489);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridEmployeers);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.btn_registration);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Size = new System.Drawing.Size(930, 461);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Пользователи";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridEmployeers
            // 
            this.dataGridEmployeers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEmployeers.Location = new System.Drawing.Point(12, 17);
            this.dataGridEmployeers.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridEmployeers.Name = "dataGridEmployeers";
            this.dataGridEmployeers.Size = new System.Drawing.Size(905, 286);
            this.dataGridEmployeers.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(786, 410);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 45);
            this.button2.TabIndex = 0;
            this.button2.Text = "Уволить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_registration
            // 
            this.btn_registration.ImageKey = "Добавить.png";
            this.btn_registration.ImageList = this.imageList1;
            this.btn_registration.Location = new System.Drawing.Point(830, 359);
            this.btn_registration.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_registration.Name = "btn_registration";
            this.btn_registration.Size = new System.Drawing.Size(60, 45);
            this.btn_registration.TabIndex = 0;
            this.btn_registration.UseVisualStyleBackColor = true;
            this.btn_registration.Click += new System.EventHandler(this.btn_registration_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.employeersDataGrid);
            this.tabPage2.Controls.Add(this.add_shift);
            this.tabPage2.Controls.Add(this.shiftDataGrid);
            this.tabPage2.Controls.Add(this.dateTimePicker1);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Size = new System.Drawing.Size(930, 461);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Смены";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // employeersDataGrid
            // 
            this.employeersDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeersDataGrid.Location = new System.Drawing.Point(471, 17);
            this.employeersDataGrid.Name = "employeersDataGrid";
            this.employeersDataGrid.Size = new System.Drawing.Size(452, 231);
            this.employeersDataGrid.TabIndex = 3;
            // 
            // add_shift
            // 
            this.add_shift.Location = new System.Drawing.Point(438, 302);
            this.add_shift.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.add_shift.Name = "add_shift";
            this.add_shift.Size = new System.Drawing.Size(104, 45);
            this.add_shift.TabIndex = 2;
            this.add_shift.Text = "Назначить на смену";
            this.add_shift.UseVisualStyleBackColor = true;
            this.add_shift.Click += new System.EventHandler(this.add_shift_Click);
            // 
            // shiftDataGrid
            // 
            this.shiftDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.shiftDataGrid.Location = new System.Drawing.Point(12, 17);
            this.shiftDataGrid.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.shiftDataGrid.Name = "shiftDataGrid";
            this.shiftDataGrid.Size = new System.Drawing.Size(452, 231);
            this.shiftDataGrid.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(374, 272);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(233, 23);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.ordersDataGrid);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(930, 461);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Заказы";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // ordersDataGrid
            // 
            this.ordersDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersDataGrid.Location = new System.Drawing.Point(0, 3);
            this.ordersDataGrid.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ordersDataGrid.Name = "ordersDataGrid";
            this.ordersDataGrid.Size = new System.Drawing.Size(925, 291);
            this.ordersDataGrid.TabIndex = 0;
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(832, 513);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(88, 27);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.Text = "Выход";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // txt_data_employeer
            // 
            this.txt_data_employeer.AutoSize = true;
            this.txt_data_employeer.Location = new System.Drawing.Point(12, 491);
            this.txt_data_employeer.Name = "txt_data_employeer";
            this.txt_data_employeer.Size = new System.Drawing.Size(0, 16);
            this.txt_data_employeer.TabIndex = 5;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Добавить.png");
            // 
            // Administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 552);
            this.Controls.Add(this.txt_data_employeer);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.MaximumSize = new System.Drawing.Size(949, 591);
            this.MinimumSize = new System.Drawing.Size(949, 591);
            this.Name = "Administrator";
            this.Text = "Administrator";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmployeers)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.employeersDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shiftDataGrid)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridEmployeers;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_registration;
        private System.Windows.Forms.Button add_shift;
        private System.Windows.Forms.DataGridView shiftDataGrid;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView ordersDataGrid;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.DataGridView employeersDataGrid;
        private System.Windows.Forms.Label txt_data_employeer;
        private System.Windows.Forms.ImageList imageList1;
    }
}