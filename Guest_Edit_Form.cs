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
using static UHotel9.Tables.Guest;

namespace UHotel9
{
    public partial class Guest_Edit_Form : Form
    {

        private FormStack formStack = new FormStack();
        private void ShowNewForm()
        {
            // Show the new form and push it onto the stack
            var newForm = new AnotherForm(formStack);
            formStack.Push(newForm);
            newForm.Show();
        }

        private Guest guest;
        ApplicationDbContext context = new ApplicationDbContext();
        public Guest_Edit_Form(Guest guest)
        {
            InitializeComponent();
            this.guest = guest;
        }



        private void GuestSaveButton_Click_1(object sender, EventArgs e)
        {
            Guest editedGuest = context.Guests.FirstOrDefault(gt => gt.guestId == this.guest.guestId);

            if (editedGuest != null)
            {
                editedGuest.guestFname = Guest_FNameBoxEdit.Text;
                editedGuest.guestLname = Guest_LNameBoxEdit.Text;
                editedGuest.email = Guest_EmailBoxEdit.Text;
                editedGuest.gender = (GuestGender)Guest_GenderBoxEdit.SelectedIndex;
                editedGuest.city = Guest_CityBoxEdit.Text;
                editedGuest.country = Guest_CountryBoxEdit.Text;
                editedGuest.phone = Guest_PhoneBoxEdit.Text;
                editedGuest.roomId = int.Parse(GuestRoomNumberBoxEdit.Text);
                editedGuest.status = (Status)GuestStatusBoxEdit.SelectedIndex;

                context.SaveChanges(); // Save the changes to the database

                MessageBox.Show("Edits saved successfully.");
            }
            else
            {
                MessageBox.Show("Guest not found in the database.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            guest_Info_Report info_Report = new guest_Info_Report();
            info_Report.Show();
            this.Close();
        }

        private void EditForm_Load(object sender, EventArgs e)
        {

            Guest_IdBoxEdit.Text = this.guest.guestId;
            Guest_FNameBoxEdit.Text = this.guest.guestFname;
            Guest_LNameBoxEdit.Text = this.guest.guestLname;

            Guest_EmailBoxEdit.Text = this.guest.email;

            Guest_GenderBoxEdit.SelectedIndex = (int)this.guest.gender;

            Guest_CityBoxEdit.Text = this.guest.city;
            Guest_CountryBoxEdit.Text = this.guest.country;

            Guest_PhoneBoxEdit.Text = this.guest.phone;
            GuestRoomNumberBoxEdit.Text = this.guest.roomId.ToString();
            GuestStatusBoxEdit.SelectedIndex = (int)this.guest.status;


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
