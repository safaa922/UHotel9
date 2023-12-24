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

namespace UHotel9
{
    public partial class check_Room : Form
    {
        int c = 0;
        int empty = 0;
        public check_Room()
        {
            InitializeComponent();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {

            var db = new ApplicationDbContext();


            int roomId = int.Parse(RoomIDReservationBox.Text);
            DateTime checkInDate = CheckInDateBox.Value;
            DateTime checkOutDate = CheckOutDateBox.Value;





            //if (checkInDate < DateTime.Now)
            //{
            //    c++;
            //    MessageBox.Show("choose valid Date, this Date has passed");
            //}
            if (checkOutDate <= checkInDate)
            {
                c++;
                MessageBox.Show("Check Out Date must be after Check In Date");
            }
            if(c==0)
            {
                FreeRooms(checkInDate, checkOutDate);
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
                    if (r.roomId == int.Parse(RoomIDReservationBox.Text))
                    {
                        empty++;
                       
                        break;
                    }
                  
                }
                if (empty == 0)
                {
                    MessageBox.Show("This room is empty");

                }
                else
                {
                    MessageBox.Show("This room is already booked");
                    empty = 0;
                }
            }
        }
    }
}
 