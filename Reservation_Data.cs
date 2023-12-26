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

namespace UHotel9
{
    public partial class Reservation_Data : Form
    {


        private FormStack formStack = new FormStack();
        private void ShowNewForm()
        {
            // Show the new form and push it onto the stack
            var newForm = new AnotherForm(formStack);
            formStack.Push(newForm);
            newForm.Show();
        }



        public Reservation_Data()
        {

            InitializeComponent();

        }

        private void dataGridViewEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void sreservation_Click(object sender, EventArgs e)
        {
            var context = new ApplicationDbContext();
            var reservations = context.Reservations.ToList();
            var dr = from d in reservations select new { d.reservationId, d.guestId, d.roomId, d.checkInDate, d.checkOutDate };
            ReservationReportGridView.DataSource = dr.ToList();
            ReservationReportGridView.Columns.Add(new DataGridViewButtonColumn { Text = "Edit", Name = "Edit", UseColumnTextForButtonValue = true });
            //dataGridView1.Columns.Add(new DataGridViewButtonColumn { Text = "Show", Name = "Show", UseColumnTextForButtonValue = true });
            ReservationReportGridView.Columns.Add(new DataGridViewButtonColumn { Text = "Delete", Name = "Delete", UseColumnTextForButtonValue = true });
            ReservationReportGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var context = new ApplicationDbContext();
            var guests = context.Reservations.ToList();
           
                var row = ReservationReportGridView.Rows[e.RowIndex];
                int rr_id = (int)row.Cells["reservationId"].Value;
                Reservation Selected_Reservation = context.Reservations.Where(r => r.roomId == rr_id).FirstOrDefault();


                if (e.ColumnIndex == ReservationReportGridView.Columns["Edit"].Index)
                {
                    if (Selected_Reservation != null)
                    {
                        MessageBox.Show("Edit" + Selected_Reservation.roomId);
                        Edit_Reservation ef = new Edit_Reservation(Selected_Reservation);
                        ef.ShowDialog();
                        this.Close();
                    }

                }
                if (e != null && ReservationReportGridView.Columns["Delete"] != null && e.ColumnIndex == ReservationReportGridView.Columns["Delete"].Index)
                {


                    if (Selected_Reservation != null)
                    {
                        DialogResult result = MessageBox.Show("Are you sure you want to delete this Guest Info?", "Confirmation", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            // Delete the room from the database
                            context.Reservations.Remove(Selected_Reservation);
                            context.SaveChanges();

                            // Delete the room from the data source
                            context.Reservations.Remove(Selected_Reservation);

                            // Rebind the data source to refresh the DataGridView
                            ReservationReportGridView.DataSource = null;
                            ReservationReportGridView.DataSource = guests;

                            MessageBox.Show("Guest Info deleted successfully.");
                            this.Close();

                        }
                    }
                }
            
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

        private void ReservationSearch_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(ReservationSearchTextBox.Text))
            {
                MessageBox.Show("Please enter a Room Number to search.");
                return;
            }

            if (!long.TryParse(ReservationSearchTextBox.Text, out long dr))
            {
                MessageBox.Show("Invalid Room Number. Please enter a valid numeric Number.");
                return;
            }

            var context = new ApplicationDbContext();
            var rroom = context.Reservations.FirstOrDefault(r => r.roomId.Equals(dr.ToString()));

            if (rroom != null)
            {
                ReservationReportGridView.DataSource = new List<Reservation> { rroom };
                ReservationReportGridView.Columns["Edit"].Visible = true;
                ReservationReportGridView.Columns["Delete"].Visible = true;
                ReservationReportGridView.Columns["Show"].Visible = true;
            }
            else
            {
                MessageBox.Show("Room not found.");
            }
        }
    }
}