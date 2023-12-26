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
    public partial class Data_Entry : Form
    {


        private FormStack formStack = new FormStack();
        private void ShowNewForm()
        {

            var newForm = new AnotherForm(formStack);
            formStack.Push(newForm);
            newForm.Show();
        }



        public Data_Entry()
        {
            InitializeComponent();
        }

        private void DataEntryEmployeeInfo_Click(object sender, EventArgs e)
        {
            Employee_Registration em = new Employee_Registration();
            em.Show();
        }

        private void DataEntryRoomInfo_Click(object sender, EventArgs e)
        {
            Rooms_Form rf = new Rooms_Form();
            rf.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void BackButton_Edit_Click(object sender, EventArgs e)
        {
            var previousForm = formStack.Pop();


            if (previousForm != null)
            {

                previousForm.Show();
            }
            else
            {

                this.Close();
            }
        }

        private void RoomReport_Click(object sender, EventArgs e)
        {
            Room_Info_Report r = new Room_Info_Report();
            r.Show();
            this.Hide();
        }

        private void employeeInfoReport_Click(object sender, EventArgs e)
        {
            employee_Info_Report re = new employee_Info_Report();
            re.Show();
            this.Hide();
        }

        //private void res_Click(object sender, EventArgs e)
        //{
        //    Reservation_Form ree = new Reservation_Form();
        //    ree.Show();
        //    this.Hide();
        //}
    }
}
