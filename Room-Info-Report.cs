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
            
            var newForm = new AnotherForm(formStack);
            formStack.Push(newForm);
            newForm.Show();
        }


        public Room_Info_Report()
        {
            InitializeComponent();
            RoomsData = new List<Room>();
        }


        private void ShowRoomInfoButton_Click(object sender, EventArgs e)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            RoomsData = db.Rooms.ToList(); 
            RoomGridView.DataSource = RoomsData;
            RoomGridView.Columns.Add(new DataGridViewButtonColumn { Text = "Edit", Name = "Edit", UseColumnTextForButtonValue = true });
          //  RoomGridView.Columns.Add(new DataGridViewButtonColumn { Text = "Show", Name = "Show", UseColumnTextForButtonValue = true });
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

                //if (e.ColumnIndex == RoomGridView.Columns["Show"].Index)
                //{
                //    MessageBox.Show("Show");
                //}
                if (e.ColumnIndex == RoomGridView.Columns["Edit"].Index)
                {
                    if (Selected != null)
                    {
                        MessageBox.Show("Edit Room Number " + Selected.roomId);
                        RoomsEdit re = new RoomsEdit(Selected);
                        re.ShowDialog();
                        this.Hide();

                    }


                }
               
                if (e != null && RoomGridView.Columns["Delete"] != null && e.ColumnIndex == RoomGridView.Columns["Delete"].Index)
                {


                    if (Selected != null)
                    {
                        DialogResult result = MessageBox.Show("Are you sure you want to delete this room?", "Confirmation", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                          
                            db.Rooms.Remove(Selected);
                            db.SaveChanges();

                            
                            RoomsData.Remove(Selected);

                           
                            RoomGridView.DataSource = null;
                            RoomGridView.DataSource = RoomsData;

                            MessageBox.Show("Room deleted successfully.");
                            this.Hide();

                        }
                    }
                }


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

        private void RoomSearch_Click(object sender, EventArgs e)
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
            var room = context.Rooms.FirstOrDefault(RoomsData => RoomsData.roomId.Equals(r_ID.ToString()));

            if (room != null)
            {
                RoomGridView.DataSource = new List<Room> { room };
                RoomGridView.Columns["Edit"].Visible = true;
                RoomGridView.Columns["Delete"].Visible = true;
               
            }
            else
            {
                MessageBox.Show("Room not found.");
            }
        }
    }
}
