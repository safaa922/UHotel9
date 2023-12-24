using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UHotel9
{
    public partial class HomePage_ : Form
    {
        public HomePage_()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee_Log_In log_In = new Employee_Log_In();
            log_In.Show();

        }
    }
}
