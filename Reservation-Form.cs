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


        int c = 0;

        decimal totalCostForGuest = 0;
        

        public Reservation_Form()
        {
            InitializeComponent();
        }



        private void NextButton_Click_1(object sender, EventArgs e)
        {
            try
            {

                var db = new ApplicationDbContext();
                Reservation rs = new Reservation()
                {
                    guestId = GuestIDReservationBox.Text,
                    roomId = int.Parse(RoomIDReservationBox.Text),
                    checkInDate = CheckInDateBox.Value,
                    checkOutDate = CheckOutDateBox.Value


                };
                int exsist = 0;
                var guests = db.Guests.ToList();
                foreach(var guest in guests)
                {
                    if(GuestIDReservationBox.Text == guest.guestId)
                    {
                        exsist++;
                        break;
                    }
                    else
                    {
                        
                    }
                }
                if(exsist ==0 )
                {
                    c++;
                    MessageBox.Show("this guest doesn't exsist");
                }

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
                    //GuestForm s = new GuestForm();
                    //s.Show();
                     this.Hide();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("all fields are required");
            }

            catch (DbUpdateException ex)
            {

                MessageBox.Show("this reservation already exists");

            }
        }






        public void FreeRooms(DateTime checkInDate, DateTime checkOutDate)
        {
            using (var context = new ApplicationDbContext())
            {
               
                var rooms = context.Rooms.ToList();
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


       
        private void BackButton_Edit_Click(object sender, EventArgs e)
        {
            Front_Office front_Office = new Front_Office();
            front_Office.Show();
            this.Close();
        }

        private void totalCost_Click(object sender, EventArgs e)
        {

            try
            {
                decimal Cost = TotalCost(CheckInDateBox.Value, CheckOutDateBox.Value, int.Parse(RoomIDReservationBox.Text));

                MessageBox.Show("the Tolal Cost = " + totalCostForGuest);
            }
            catch(FormatException)
            {
                MessageBox.Show("check your data please");
            }
        }
        decimal TotalCost(DateTime CheckInDate, DateTime CheckOutDate, int RoomId)
        {
            using (var dbContext = new ApplicationDbContext())
            {


                int stayingDays = (int)(CheckOutDate - CheckInDate).TotalDays;


                decimal roomPrice = dbContext.Rooms.FirstOrDefault(room => room.roomId == RoomId)?.price ?? 0;



                totalCostForGuest = stayingDays * roomPrice;

                return totalCostForGuest;

            }
        }
    }
}
