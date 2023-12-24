using Microsoft.EntityFrameworkCore;
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
    public partial class Rooms_Form : Form
    {


        private FormStack formStack = new FormStack();
        private void ShowNewForm()
        {
            // Show the new form and push it onto the stack
            var newForm = new AnotherForm(formStack);
            formStack.Push(newForm);
            newForm.Show();
        }



        public Rooms_Form()
        {
            InitializeComponent();

        }

        private void AddRoomBox_Click(object sender, EventArgs e)
        {

            //               context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT Rooms ON");


        }


        private void SaveButton_Click(object sender, EventArgs e)
        {

           
        }

        private void SaveButton_Click_1(object sender, EventArgs e)
        {
            ApplicationDbContext db1 = new ApplicationDbContext();

            Room room1 = new Room()
            {
                //  roomId = int.Parse(RoomIDBox.Text),
                type = (RoomType)RoomTypeBox.SelectedIndex,
                floorNumber = int.Parse(RoomFloorNumberBox.Text),
                price = decimal.Parse(RoomPriceBox.Text)
            };
            int c = 0;
            if (room1.type == RoomType.Single || room1.type == RoomType.Double || room1.type == RoomType.Suite)
            {


            }
            else
            {
                c++;
                MessageBox.Show("Invalid Room Type");
            }
            if (room1.floorNumber < 0 || room1.floorNumber > 10)
            {
                c++;
                MessageBox.Show("Invalid Floor Number");

            }
            db1.Rooms.Add(room1);
            MessageBox.Show("Room added successfully");
            db1.SaveChanges();


            // context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT Rooms OFF");


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
