using DevExpress.Xpo.DB;
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
    public partial class Revenue : Form
    {

        private FormStack formStack = new FormStack();
        private void ShowNewForm()
        {
            // Show the new form and push it onto the stack
            var newForm = new AnotherForm(formStack);
            formStack.Push(newForm);
            newForm.Show();
        }




        private DateTime selectedDate;

        public Revenue(DateTime selectedDate)
        {
            InitializeComponent();
            this.selectedDate = selectedDate;
            //PopulateRevenueGrid();
        }

        private void totalRevenueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            decimal totalPrice = 0;
            using (var dbContext = new ApplicationDbContext())
            {
                var reservations = dbContext.Reservations
                    .Where(r => r.checkInDate >= selectedDate && r.checkInDate <= DateTime.Now)
                    .ToList();

                var revenueData = reservations.Select(r => new
                {
                    ReservationId = r.reservationId,
                    RoomId = r.roomId,
                    Price = dbContext.Rooms.FirstOrDefault(room => room.roomId == r.roomId)?.price
                }).ToList();

                totalPrice = (decimal)revenueData.Sum(item => item.Price);

                // Create a new row for total price
                var totalRow = new
                {
                    ReservationId = "Total", // You can customize this based on your data
                    RoomId = "",             // You can customize this based on your data
                    Price = totalPrice
                };

                // Create a new list and add both detailed data and total row
                var combinedData = new List<object>(revenueData);
                combinedData.Add(totalRow);

                // Set DataGridView data source to the combinedData list
                revenueDataGridView.DataSource = combinedData;
                revenueDataGridView.AutoGenerateColumns = true;
            }
        }

        private void showRevenueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var dbContext = new ApplicationDbContext())
            {

                PopulateRevenueGrid();
                //// Use the dbContext here
                //Accountant accountantForm = new Accountant();
                //var reservationBeforeSelectedDate = accountantForm.GetReservationsBeforeSelectedDate(selectedDate).ToList(); // Convert query result to a list
                //revenueDataGridView.DataSource = reservationBeforeSelectedDate;
                //revenueDataGridView.AutoGenerateColumns = true;

            }

        }

        private void revenueDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void PopulateRevenueGrid()
        {
            //decimal totalPrice = 0;
            using (var dbContext = new ApplicationDbContext())
            {
                var reservations = dbContext.Reservations
                    .Where(r => r.checkInDate >= selectedDate && r.checkInDate <= DateTime.Now)
                    .ToList();

                var revenueData = reservations.Select(r => new
                {
                    ReservationId = r.reservationId,
                    RoomId = r.roomId,
                    checkInDate = r.checkInDate,
                    checkOutDate = r.checkOutDate,
                    Price = dbContext.Rooms.FirstOrDefault(room => room.roomId == r.roomId)?.price
                }).ToList();

                //totalPrice = (decimal)revenueData.Sum(item => item.Price);

                // Create a new row for total price
                //var totalRow = new
                //{
                //    ReservationId = "Total", // You can customize this based on your data
                //    RoomId = "",             // You can customize this based on your data
                //    Price = totalPrice
                //};

                // Create a new list and add both detailed data and total row
                // var combinedData = new List<object>(revenueData);
                // combinedData.Add(totalRow);

                //revenueDataGridView.ColumnCount = 5;
                //revenueDataGridView.Columns[0].Name = "Reservation number";
                //revenueDataGridView.Columns[1].Name = "Room number";
                //revenueDataGridView.Columns[2].Name = "Check in date";
                //revenueDataGridView.Columns[3].Name = "Check out date";
                //revenueDataGridView.Columns[4].Name = "Room price";
                // Set DataGridView data source to the combinedData list
                revenueDataGridView.DataSource = revenueData;
                revenueDataGridView.AutoGenerateColumns = true;
                revenueDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            //decimal totalPrice = 0;
            //using (var dbContext = new ApplicationDbContext())
            //{
            //    var reservations = dbContext.Reservations
            //        .Where(r => r.checkInDate >= selectedDate && r.checkInDate <= DateTime.Now)
            //        .ToList();

            //    var revenueData = reservations.Select(r => new
            //    {
            //        ReservationId = r.reservationId,
            //        RoomId = r.roomId,
            //        Price = dbContext.Rooms.FirstOrDefault(room => room.roomId == r.roomId)?.price
            //    }).ToList();

            //    revenueDataGridView.DataSource = revenueData;
            //    revenueDataGridView.AutoGenerateColumns = true;
            // //   var item = new Room();
            //    totalPrice = (decimal)revenueData.Sum(item => item.Price);


            //}

        }

        private void totalRevenueToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            decimal totalRevenue = 0;
            using (var dbContext = new ApplicationDbContext())
            {
                var reservations = dbContext.Reservations
                    .Where(r => r.checkInDate >= selectedDate && r.checkInDate <= DateTime.Now)
                    .ToList();

                foreach (var reservation in reservations)
                {
                    // Calculate staying days
                    int stayingDays = (int)(reservation.checkOutDate - reservation.checkInDate).TotalDays;

                    // Retrieve room price from the Rooms table
                    decimal roomPrice = dbContext.Rooms.FirstOrDefault(room => room.roomId == reservation.roomId)?.price ?? 0;

                    // Calculate total price for the reservation
                    decimal totalPriceForReservation = stayingDays * roomPrice;

                    // Accumulate total revenue
                    totalRevenue += totalPriceForReservation;
                }

                // Display total revenue or use it as needed
                // Console.WriteLine("Total Revenue: " + totalRevenue);

                // Display detailed revenue data in the DataGridView (if needed)
                var revenueData = reservations.Select(r => new
                {
                    ReservationId = r.reservationId,
                    RoomId = r.roomId,
                    StayingDays = (int)(r.checkOutDate - r.checkInDate).TotalDays,
                    RoomPrice = dbContext.Rooms.FirstOrDefault(room => room.roomId == r.roomId)?.price ?? 0,
                    TotalPrice = (int)(r.checkOutDate - r.checkInDate).TotalDays * dbContext.Rooms.FirstOrDefault(room => room.roomId == r.roomId)?.price
                }).ToList();

                var totalRow = new
                {
                    ReservationId = "Total", // You can customize this based on your data
                    RoomId = "",             // You can customize this based on your data
                    StayingDays = "",
                    RoomPrice = "",
                    TotalPrice = totalRevenue
                };

                // Create a new list and add both detailed data and total row
                var combinedData = new List<object>(revenueData);
                combinedData.Add(totalRow);

                // Set DataGridView data source to the combinedData list
                revenueDataGridView.DataSource = combinedData;

                //revenueDataGridView.DataSource = revenueData;
                revenueDataGridView.AutoGenerateColumns = true;
            }
        }

        private void Revenue_Load(object sender, EventArgs e)
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
                // If there is no previous form, you might want to close the current form or take other actions.
                // For example, you can close the current form:
                this.Close();
            }
        }
    }
}
