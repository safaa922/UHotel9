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
using UHotel9.Tables;
using static UHotel9.Employee_Registration;

namespace UHotel9
{


    public partial class Edit_Reservation : Form
    {
        int c = 0;
        private Reservation reservation;
        ApplicationDbContext context = new ApplicationDbContext();




        private FormStack formStack = new FormStack();
        private void ShowNewForm()
        {
            // Show the new form and push it onto the stack
            var newForm = new AnotherForm(formStack);
            formStack.Push(newForm);
            newForm.Show();
        }


        // Updated constructor to accept an Employee parameter
        public Edit_Reservation(Reservation reservation)
        {
            InitializeComponent();
            this.reservation = reservation;
            var res = context.Reservations;
        }

        private void NextButton_Edit_Click(object sender, EventArgs e)
        {
            this.reservation.guestId = GuestIDReservationBox_Edit.Text;
            this.reservation.roomId = int.Parse(RoomID_Reservation_Box_Edit.Text);
            this.reservation.checkInDate = CheckInDateBox_Edit.Value;
            this.reservation.checkOutDate = CheckOutDateBox_Edit.Value;

            if ((long.TryParse(reservation.guestId, out _)) && (reservation.guestId.Length == 14))
            {
                // The value is numeric (integer)
                // Console.WriteLine("Numeric value");
            }
            else
            {
                // The value is not numeric
                MessageBox.Show("Invalid ID Number, Enter Only  14 Numbers");
                c++;
            }



            if (c == 0)
            {
                context.Reservations.Update(reservation);
                context.SaveChanges();

                GuestForm s = new GuestForm();
                s.Show();
                this.Hide();
            }

        }



        private void Edit_Reservation_Load(object sender, EventArgs e)
        {

            GuestIDReservationBox_Edit.Text = this.reservation.guestId;
            RoomID_Reservation_Box_Edit.Text = this.reservation.roomId.ToString();
            CheckInDateBox_Edit.Value = this.reservation.checkInDate;
            CheckInDateBox_Edit.Value = this.reservation.checkOutDate;

        }

        private void BackButton_Edit_Click(object sender, EventArgs e)
        {
            var previousForm = formStack.Pop();

            
            if (previousForm != null)
            {
                // Show the previous form
                previousForm.Show();
            }
            else
            {
               
                this.Close();
            }
        }
    }

}

