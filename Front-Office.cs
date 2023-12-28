using DevExpress.Charts.Native;
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
    public partial class Front_Office : Form
    {

        private FormStack formStack = new FormStack();
        private void ShowNewForm()
        {

            var newForm = new AnotherForm(formStack);
            formStack.Push(newForm);
            newForm.Show();
        }

        public Front_Office()
        {
            InitializeComponent();
        }

        private void HomeReservationButton_Click(object sender, EventArgs e)
        {




        }


        private void HomeReservationButton_Click_1(object sender, EventArgs e)
        {
            Reservation_Form reservation_Form = new Reservation_Form();
            reservation_Form.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ShowRoomInfoButton_Click(object sender, EventArgs e)
        {
            // Reservation_Form reservation_Form = new Reservation_Form();
            Room_Status rs = new Room_Status();
            rs.Show();

        }

        private void Dresrvation_Click(object sender, EventArgs e)
        {

        }

        private void BackButton_Edit_Click(object sender, EventArgs e)
        {
            var previousForm = formStack.Pop();

            // Check if there is a previous form
            if (previousForm != null)
            {
                // Show the previous form
                previousForm.Show();
            }
            else
            {

                this.Hide();
            }
        }

        private void FsReservationFormButton_Click(object sender, EventArgs e)
        {
            GuestForm gf = new GuestForm();
            gf.Show();
        }

        private void FsShowRoomInfoButton_Click(object sender, EventArgs e)
        {
            Room_Info_Report rs = new Room_Info_Report();
            rs.Show();
        }

        private void Dresrvation_Click_1(object sender, EventArgs e)
        {
            Reservation_Data rs = new Reservation_Data();
            rs.Show();

        }

        private void EmptyRooms_Click(object sender, EventArgs e)
        {
            Room_Status rst = new Room_Status();
            rst.Show();
        }
    }
}
