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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static UHotel9.Tables.Guest;

namespace UHotel9
{
    public partial class ViewGuests : Form
    {
       
        ApplicationDbContext context = new ApplicationDbContext();
        private Guest guest;

        public ViewGuests(Guest guest)
        {

            InitializeComponent();
            this.guest = guest;
        }

     
        private void GuestSaveButton_Click(object sender, EventArgs e)
        {
            guest_Info_Report Info_Report = new guest_Info_Report();
            Info_Report.Show();
            this.Close();

        }

        private void ViewGuests_Load(object sender, EventArgs e)
        {
            
           
                Guest_IdBox.Text = this.guest.guestId;
                Guest_FNameBox.Text = this.guest.guestFname;
                 Guest_LNameBox.Text= this.guest.guestLname;
               
                Guest_EmailBox.Text= this.guest.email;

                Guest_GenderBox.SelectedIndex = (int)(GuestGender)this.guest.gender;

                Guest_CityBox.Text= this.guest.city;
                Guest_CountryBox.Text=this.guest.country;

                Guest_PhoneBox.Text= this.guest.phone;
                GuestRoomNumberBox.Text = this.guest.roomId.ToString();
                GuestStatusBox.SelectedIndex= (int)(Status)this.guest.status;
            
        }
    }
}
