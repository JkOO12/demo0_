namespace demo3
{
    partial class Cooker
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
            this.ordersDataGrid = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_data_employeer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ordersDataGrid
            // 
            this.ordersDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersDataGrid.Location = new System.Drawing.Point(13, 12);
            this.ordersDataGrid.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ordersDataGrid.Name = "ordersDataGrid";
            this.ordersDataGrid.Size = new System.Drawing.Size(907, 386);
            this.ordersDataGrid.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Готовится ",
            "Готов"});
            this.comboBox1.Location = new System.Drawing.Point(780, 413);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(140, 23);
            this.comboBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(432, 464);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 25);
            this.button1.TabIndex = 2;
            this.button1.Text = "Применить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(832, 500);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 30);
            this.button2.TabIndex = 2;
            this.button2.Text = "Выход";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_data_employeer
            // 
            this.txt_data_employeer.AutoSize = true;
            this.txt_data_employeer.Location = new System.Drawing.Point(12, 487);
            this.txt_data_employeer.Name = "txt_data_employeer";
            this.txt_data_employeer.Size = new System.Drawing.Size(0, 16);
            this.txt_data_employeer.TabIndex = 6;
            // 
            // Cooker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 552);
            this.Controls.Add(this.txt_data_employeer);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ordersDataGrid);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.MaximumSize = new System.Drawing.Size(949, 591);
            this.MinimumSize = new System.Drawing.Size(949, 591);
            this.Name = "Cooker";
            this.Text = "Cooker";
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ordersDataGrid;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label txt_data_employeer;
    }
}