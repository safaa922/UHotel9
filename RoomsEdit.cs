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
    public partial class RoomsEdit : Form
    {
        private Room room;
        ApplicationDbContext db = new ApplicationDbContext();



        private FormStack formStack = new FormStack();
        private void ShowNewForm()
        {
            
            var newForm = new AnotherForm(formStack);
            formStack.Push(newForm);
            newForm.Show();
        }


        public RoomsEdit(Room room)
        {
            InitializeComponent();
            this.room = room;
        }


        private void RoomsEdit_Load(object sender, EventArgs e)
        {
            //Room EditedRoom = db.Rooms.Where(rE => rE.roomId == this.room.roomId).FirstOrDefault();
            //if(EditedRoom != null)
            //{
            RoomTypeEditBox.SelectedIndex = (int)(RoomType)this.room.type;
            RoomPriceEditBox.Text = this.room.price.ToString();
            RoomFloorNumberEditBox.Text = this.room.floorNumber.ToString();
            //}
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            //Room EditedRoom = db.Rooms.Where(rE => rE.roomId == this.room.roomId).FirstOrDefault();
            //if (EditedRoom != null)
            //{
           
            //}

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

        private void SaveButton_Click_1(object sender, EventArgs e)
        {
            this.room.type = (RoomType)RoomTypeEditBox.SelectedIndex;
            this.room.price = decimal.Parse(RoomPriceEditBox.Text);
            this.room.floorNumber = int.Parse(RoomFloorNumberEditBox.Text);

            db.Rooms.Update(this.room);
            db.SaveChanges();
            MessageBox.Show("Updated");
            Room_Info_Report rir = new Room_Info_Report();
        }
    }
}
