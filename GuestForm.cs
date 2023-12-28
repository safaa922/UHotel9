//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Data.Entity.Infrastructure;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using UHotel9.Tables;
//using static UHotel9.Tables.Guest;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
using UHotel9.Tables;
using static UHotel9.Tables.Guest;


namespace UHotel9
{
    public partial class GuestForm : Form
    {
        private FormStack formStack = new FormStack();
        private void ShowNewForm()
        {
           
            var newForm = new AnotherForm(formStack);
            formStack.Push(newForm);
            newForm.Show();
        }


        public GuestForm()
        {
            InitializeComponent();
        }

        

       
        private void GuestSaveButton_Click(object sender, EventArgs e)
        {
            ApplicationDbContext db2 = new ApplicationDbContext();
            int counterOnrequiredField = 0;
            int validationFlag = 0;
            try
            {
                Guest g1 = new Guest()
                {

                    
                    guestId = Guest_IdBox.Text,
                    guestFname = Guest_FNameBox.Text,
                    guestLname = Guest_LNameBox.Text,
                   
                    email = Guest_EmailBox.Text,

                    gender = (GuestGender)Guest_GenderBox.SelectedIndex,

                    city = Guest_CityBox.Text,
                    country = Guest_CountryBox.Text,

                    phone = Guest_PhoneBox.Text,
                    roomId = int.Parse(GuestRoomNumberBox.Text),
                    status = (Status)GuestStatusBox.SelectedIndex,


                };
                if ((g1.guestId.Length != 14))
                {
                    validationFlag++;
                    MessageBox.Show("Invalid ID, Enter 14 Numbers");

                }

                if (!g1.guestFname.All(char.IsLetter))
                {
                    validationFlag++;
                    MessageBox.Show("Invalid FristName");

                }

                if (!g1.guestLname.All(char.IsLetter))
                {
                    validationFlag++;
                    MessageBox.Show("Invalid LastName");

                }
                if (string.IsNullOrEmpty(g1.email))
                {

                    counterOnrequiredField++;
                    MessageBox.Show("email is required " + counterOnrequiredField);

                }

                if (g1.gender == GuestGender.Female || g1.gender == GuestGender.Male)
                {


                }
                else
                {
                    counterOnrequiredField++;
                    validationFlag++;
                    MessageBox.Show("Invalid Gender, please choose from the list");
                }

                if (!g1.city.All(char.IsLetter))
                {
                    validationFlag++;
                    MessageBox.Show("Invalid City");

                }

                if (!g1.country.All(char.IsLetter))
                {
                    validationFlag++;
                    MessageBox.Show("Invalid Country");

                }

                if (long.TryParse(g1.phone, out _))
                {


                }
                else
                {

                   
                    MessageBox.Show("Invalid Phone Number, Enter Only Numbers");
                    validationFlag++;
                }

                if (g1.status == Status.married || g1.status == Status.engaged || g1.status == Status.single)
                {

                }
                else
                {
                    validationFlag++;
                    counterOnrequiredField++;
                    MessageBox.Show("Invalid Status, please choose from the list");
                }


                if (validationFlag == 0 && counterOnrequiredField == 0)
                {

                    db2.Guests.Add(g1);
                    db2.SaveChanges();
                    MessageBox.Show("added successfully");
                    Reservation_Form r = new Reservation_Form();
                    r.Show();
                    this.Hide();
                }

            }
            catch (FormatException)
            {
                MessageBox.Show("all filds is required, please fill the form");
            }


            catch (DbUpdateException ex)
            {
                
                MessageBox.Show("this guest already exsist");
                Reservation_Form r = new Reservation_Form();
                r.Show();
               
            }

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
               
                this.Hide();
            }
        }
    }
}
