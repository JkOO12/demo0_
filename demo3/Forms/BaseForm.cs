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
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
            this.BackColor = Color.White;
            this.Load += BaseForm_Load;
            this.Font = new Font("Times New Roman", 10);
            this.BackColor = Color.FromArgb(217, 207, 217);
            Icon appIcon = new Icon("C:\\Users\\Даниил\\source\\repos\\demo3\\demo3\\Resource\\logo.ico");
            this.Icon = appIcon;
        }

        private void BaseForm_Load(object sender, EventArgs e)
        {
            Color backColocBtn = Color.FromArgb(188, 158, 188);
            ChangeControlColors(this, backColocBtn);
        }

        private void ChangeControlColors(Control parent, Color color)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is Button || control is TextBox ||
                    control is DataGridView || control is ComboBox ||
                    control is CheckBox || control is DateTimePicker ||
                    control is ListView || control is TabControl)
                {
                    control.BackColor = color;
                }
                
                if (control.Controls.Count > 0)
                {
                    ChangeControlColors(control, color);
                }
            }
        }


    }


}
