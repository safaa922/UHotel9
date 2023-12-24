using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UHotel9.Tables;

namespace UHotel9
{

    public partial class Reservation_Form : Form
    {
        Guest g;
        private FormStack formStack = new FormStack();
        private void ShowNewForm()
        {

            var newForm = new AnotherForm(formStack);
            formStack.Push(newForm);
            newForm.Show();
        }


        int c = 0;

        decimal totalCostForGuest = 0;
        public Reservation_Form(Guest g)
        {
            InitializeComponent();
            this.g = g;

            //ReservationLabell.Parent = pictureBox2;
            //ReservationLabell.BackColor = Color.Transparent;
            ////label4.Parent = pictureBox2;
            ////label4.BackColor = Color.Transparent;

        }

        public Reservation_Form()
        {
        }

        private void NextButton_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void RoomFormLabel_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {



        }

        private void NextButton_Click_1(object sender, EventArgs e)
        {
            try
            {

                var db = new ApplicationDbContext();
                Reservation rs = new Reservation()
                {
                    //  guestId = GuestIDReservationBox.Text,
                    //  roomId = int.Parse(RoomIDReservationBox.Text),
                    checkInDate = CheckInDateBox.Value,
                    checkOutDate = CheckOutDateBox.Value


                };

                if ((long.TryParse(rs.guestId, out _)) && (rs.guestId.Length == 14))
                {

                }
                else
                {

                    MessageBox.Show("Invalid Guest ID Number, Enter Only  14 Numbers");
                    c++;
                }
                if (rs.checkInDate < DateTime.Today)
                {
                    c++;
                    MessageBox.Show("choose valid Date, this Date has passed");
                }
                if (rs.checkOutDate <= rs.checkInDate)
                {
                    c++;
                    MessageBox.Show("Check Out Date must be after Check In Date");
                }
                if (!string.IsNullOrEmpty(rs.guestId))
                {
                    DateTime CurrentDateTime = DateTime.Today;
                    FreeRooms(CheckInDateBox.Value, CheckOutDateBox.Value);

                }

                if (c == 0)
                {
                    db.Reservations.Add(rs);
                    db.SaveChanges();
                    MessageBox.Show("Done^_-");
                    GuestForm s = new GuestForm();
                    //s.Show();
                    // this.Hide();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("all fields are required");
            }

            catch (DbUpdateException ex)
            {
                //var sqlException = ex.GetBaseException() as SqlException;
                MessageBox.Show("this reservation is already exsist");
                //if (ex.InnerException is SqlException sqlException && sqlException.Number == 2627)
                //{
                //    MessageBox.Show("this Guest is already exsits");

                //}
                //else
                //{

                //    MessageBox.Show("");
                //   // throw ex;
                //}
            }
        }

        //private void button1_Click_1(object sender, EventArgs e)
        //{
        //    Front_Office fo = new Front_Office();
        //    fo.Show();
        //    this.Hide();
        //}


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
                // If there is no previous form, you might want to close the current form or take other actions.
                // For example, you can close the current form:
                this.Close();
            }
        }

        private void TotalCost_Click(object sender, EventArgs e)
        {
          

        }
        public void FreeRooms(DateTime checkInDate, DateTime checkOutDate)
        {
            using (var context = new ApplicationDbContext())
            {
                string g_id = GuestIDReservationBox.Text;
                Guest SelectedGuest = context.Guests.Where(g => g.guestId == g_id).FirstOrDefault();
                var rooms = context.Rooms.ToList(); // Assuming "Rooms" is the DbSet property in your DbContext
                var occupiedRooms = context.Reservations
                 .Where(reservation => !(checkInDate >= reservation.checkOutDate || checkOutDate <= reservation.checkInDate))
                 .Select(reservation => reservation.roomId)
                 .ToList();

                var occupied = context.Rooms
                      .Where(room => occupiedRooms.Contains(room.roomId))
                      .ToList();
                foreach (var r in occupied)
                {
                    if (r.roomId == int.Parse(this.RoomIDReservationBox.Text))
                    {
                        c++;
                        MessageBox.Show("This room is already booked");
                        break;
                    }
                }


            }
        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void Reservation_Form_Load(object sender, EventArgs e)
        {
            GuestIDReservationBox.Text = this.g.guestId;
            RoomIDReservationBox.Text = this.g.roomId.ToString();


        }

        private void totalCost_Click_1(object sender, EventArgs e)
        {
            decimal Cost = TotalCost(CheckInDateBox.Value, CheckOutDateBox.Value, int.Parse(RoomIDReservationBox.Text));
            MessageBox.Show("the Tolal Cost = " + totalCostForGuest);
        }
        decimal TotalCost(DateTime CheckInDate, DateTime CheckOutDate, int RoomId)
        {
            using (var dbContext = new ApplicationDbContext())
            {

                // Calculate staying days
                int stayingDays = (int)(CheckOutDate - CheckInDate).TotalDays;

                // Retrieve room price from the Rooms table
                decimal roomPrice = dbContext.Rooms.FirstOrDefault(room => room.roomId == RoomId)?.price ?? 0;


                // Calculate total price for the reservation
                totalCostForGuest = stayingDays * roomPrice;

                return totalCostForGuest;

            }

        }

        //private void totalCost_Click(object sender, EventArgs e)
        //{

        //}

    }
}
