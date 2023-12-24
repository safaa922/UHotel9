using DevExpress.Charts.Native;
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

namespace UHotel9
{
    public partial class Accountant : Form
    {
        ApplicationDbContext db = new ApplicationDbContext();



        private FormStack formStack = new FormStack();
        private void ShowNewForm()
        {
            // Show the new form and push it onto the stack
            var newForm = new AnotherForm(formStack);
            formStack.Push(newForm);
            newForm.Show();
        }
        public Accountant()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void revenueButton_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = revenueBox.Value;
            Revenue revenueForm = new Revenue(selectedDate);
            revenueForm.Show();
            // DateTime selectedDate = revenueBox.Value;
            // var revenue = new Revenue(selectedDate);

            //// Revenue revenue = new Revenue();
            // revenue.Show();
            // this.Hide();

        }

        private void updateSalarybutton_Click(object sender, EventArgs e)
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        //public IQueryable<object> GetReservationsBeforeSelectedDate(DateTime selectedDate)
        //{
        //    using (var db = new ApplicationDbContext())
        //    {
        //        var reservationBeforeSelectedDate = db.Reservations
        //            .Where(r => r.checkInDate >= selectedDate && r.checkInDate <= DateTime.Now)
        //            .Select(r => new { r.reservationId, r.roomId, price = db.Rooms.FirstOrDefault(room => room.roomId == r.roomId).price });

        //        return reservationBeforeSelectedDate;
        //    }
        //}
    }
}
