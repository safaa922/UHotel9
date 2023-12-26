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
           
            var newForm = new AnotherForm(formStack);
            formStack.Push(newForm);
            newForm.Show();
        }




        private DateTime selectedDate;

        public Revenue(DateTime selectedDate)
        {
            InitializeComponent();
            this.selectedDate = selectedDate;
            
        }

        

        private void showRevenueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var dbContext = new ApplicationDbContext())
            {

                PopulateRevenueGrid();
                

            }

        }

        private void revenueDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void PopulateRevenueGrid()
        {
           
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

                
                revenueDataGridView.DataSource = revenueData;
                revenueDataGridView.AutoGenerateColumns = true;
                revenueDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
           
        }

        private void totalRevenueToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                decimal totalRevenue = 0;
                using (var dbContext = new ApplicationDbContext())
                {
                    var reservations = dbContext.Reservations
                        .Where(r => r.checkInDate >= selectedDate && r.checkInDate <= DateTime.Now)
                        .ToList();
                    if (reservations.Any())
                    {
                        foreach (var reservation in reservations)
                        {

                            int stayingDays = (int)(reservation.checkOutDate - reservation.checkInDate).TotalDays;


                            decimal? roomPrice = dbContext.Rooms.FirstOrDefault(room => room.roomId == reservation.roomId)?.price;

                            if (roomPrice.HasValue)
                            {

                                decimal totalPriceForReservation = stayingDays * roomPrice.Value;

                                totalRevenue += totalPriceForReservation;
                            }

                        }

                        var revenueData = reservations.Select(r => new
                        {
                            ReservationId = r.reservationId,
                            RoomId = r.roomId,
                            StayingDays = (int)(r.checkOutDate - r.checkInDate).TotalDays,
                            RoomPrice = dbContext.Rooms.FirstOrDefault(room => room.roomId == r.roomId)?.price,
                            TotalPrice = (int)(r.checkOutDate - r.checkInDate).TotalDays * dbContext.Rooms.FirstOrDefault(room => room.roomId == r.roomId)?.price
                        }).ToList();
                        //add row

                        revenueDataGridView.DataSource = revenueData;

                        revenueDataGridView.AutoGenerateColumns = true;
                    }

                    else
                    {
                        MessageBox.Show("No reservations found for the selected period");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Revenue_Load(object sender, EventArgs e)
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
    }
}
