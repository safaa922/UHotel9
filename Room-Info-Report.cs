using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UHotel9.Tables;

namespace UHotel9
{
    public partial class Room_Info_Report : Form
    {
        private List<Room> RoomsData; 


        private FormStack formStack = new FormStack();
        private void ShowNewForm()
        {
            // Show the new form and push it onto the stack
            var newForm = new AnotherForm(formStack);
            formStack.Push(newForm);
            newForm.Show();
        }


        public Room_Info_Report()
        {
            InitializeComponent();
            RoomsData = new List<Room>(); // Initialize RoomsData list
        }


        private void ShowRoomInfoButton_Click(object sender, EventArgs e)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            RoomsData = db.Rooms.ToList(); // Assign data directly to the class-level variable
            RoomGridView.DataSource = RoomsData;
            RoomGridView.Columns.Add(new DataGridViewButtonColumn { Text = "Edit", Name = "Edit", UseColumnTextForButtonValue = true });
            RoomGridView.Columns.Add(new DataGridViewButtonColumn { Text = "Show", Name = "Show", UseColumnTextForButtonValue = true });
            RoomGridView.Columns.Add(new DataGridViewButtonColumn { Text = "Delete", Name = "Delete", UseColumnTextForButtonValue = true });
            RoomGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            ApplicationDbContext db = new ApplicationDbContext();

            if (e.RowIndex >= 0)
            {
                var row = RoomGridView.Rows[e.RowIndex];
                int r_ID = Convert.ToInt32(row.Cells["roomId"].Value);

                Room Selected = db.Rooms.Where(r => r.roomId == r_ID).FirstOrDefault();

                if (e.ColumnIndex == RoomGridView.Columns["Show"].Index)
                {
                    MessageBox.Show("Show");
                }
                if (e.ColumnIndex == RoomGridView.Columns["Edit"].Index)
                {
                    if (Selected != null)
                    {
                        MessageBox.Show("Edit Room Number " + Selected.roomId);
                        RoomsEdit re = new RoomsEdit(Selected);
                        re.ShowDialog();
                        this.Close();

                    }


                }
                //exception 
                if (e != null && RoomGridView.Columns["Delete"] != null && e.ColumnIndex == RoomGridView.Columns["Delete"].Index)
                {


                    if (Selected != null)
                    {
                        DialogResult result = MessageBox.Show("Are you sure you want to delete this room?", "Confirmation", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            // Delete the room from the database
                            db.Rooms.Remove(Selected);
                            db.SaveChanges();

                            // Delete the room from the data source
                            RoomsData.Remove(Selected);

                            // Rebind the data source to refresh the DataGridView
                            RoomGridView.DataSource = null;
                            RoomGridView.DataSource = RoomsData;

                            MessageBox.Show("Room deleted successfully.");
                            this.Close();

                        }
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

        private void GuestSearch_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(RoomSearchTextBox.Text))
            {
                MessageBox.Show("Please enter a Room Number to search.");
                return;
            }

            if (!long.TryParse(RoomSearchTextBox.Text, out long r_ID))
            {
                MessageBox.Show("Invalid Room Number. Please enter a valid numeric Number.");
                return;
            }

            var context = new ApplicationDbContext();
            var room = context.Rooms.FirstOrDefault(r=>r.roomId.Equals(r_ID.ToString()));

            if (room != null)
            {
                RoomGridView.DataSource = new List<Room> { room };
                RoomGridView.Columns["Edit"].Visible = true;
                RoomGridView.Columns["Delete"].Visible = true;
                RoomGridView.Columns["Show"].Visible = true;
            }
            else
            {
                MessageBox.Show("Room not found.");
            }
        }
    }
}
