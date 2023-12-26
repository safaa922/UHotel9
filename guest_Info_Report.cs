using Cairo;
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
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace UHotel9
{


    public partial class guest_Info_Report : Form
    {

        private FormStack formStack = new FormStack();
        private void ShowNewForm()
        {
            // Show the new form and push it onto the stack
            var newForm = new AnotherForm(formStack);
            formStack.Push(newForm);
            newForm.Show();
        }


        public guest_Info_Report()
        {
            InitializeComponent();
          //  GuestDataGrid.CellContentClick += dataGridView1_CellContentClick_1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var context = new ApplicationDbContext();
            var guests = context.Guests.ToList();
            var gt = from g in guests select new { g.guestId, g.guestFname, g.guestLname, g.roomId };
            GuestDataGrid.DataSource = guests.ToList();
            GuestDataGrid.Columns.Add(new DataGridViewButtonColumn { Text = "Edit", Name = "Edit", UseColumnTextForButtonValue = true });
            GuestDataGrid.Columns.Add(new DataGridViewButtonColumn { Text = "Show", Name = "Show", UseColumnTextForButtonValue = true });
            GuestDataGrid.Columns.Add(new DataGridViewButtonColumn { Text = "Delete", Name = "Delete", UseColumnTextForButtonValue = true });
            GuestDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        //private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    var context = new ApplicationDbContext();
        //    if (e.RowIndex >= 0)
        //    {
        //        var row = dataGridView1.Rows[e.RowIndex];
        //        string g_id = row.Cells["guestId"].Value.ToString();
        //        Guest SelectedGuest = context.Guests.Where(g => g.guestId == g_id).FirstOrDefault();

        //        if (e.ColumnIndex == dataGridView1.Columns["Edit"].Index)
        //        {
        //            if (SelectedGuest != null)
        //            {
        //                MessageBox.Show("Edit" + SelectedGuest.guestFname);
        //                EditForm ef = new EditForm(SelectedGuest);
        //                ef.ShowDialog();
        //                this.Close();
        //            }

        //        }
        //        if (e.ColumnIndex == dataGridView1.Columns["Show"].Index)
        //        {
        //            if (SelectedGuest != null)
        //            {
        //                MessageBox.Show("Show" + SelectedGuest.guestFname);
        //                ViewGuests viewGuests = new ViewGuests();
        //                viewGuests.ShowDialog();
        //            }

        //        }
        //        //if (e.ColumnIndex == dataGridView1.Columns["Delete"].Index)
        //        //{
        //        //    MessageBox.Show("Do You Want To Delete" + SelectedGuest.guestFname + "From Guests");
        //        //    var DeleteGuest = context.Guests.Find(g_id);
        //        //    if (DeleteGuest != null)
        //        //    {
        //        //        context.Guests.Remove(DeleteGuest);
        //        //        MessageBox.Show("Done");
        //        //    }


        //        //}
        //    }
        //}

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (GuestDataGrid == null)
            {
                
                return;
            }

            var context = new ApplicationDbContext();
            var guests = context.Guests.ToList();
           
                var row = GuestDataGrid.Rows[e.RowIndex];
                string g_id = row.Cells["guestId"].Value.ToString();
                Guest SelectedGuest = context.Guests.Where(g => g.guestId == g_id).FirstOrDefault();

                if (e.ColumnIndex == GuestDataGrid.Columns["Edit"].Index)
                {
                    if (SelectedGuest != null)
                    {
                        MessageBox.Show("Edit" + SelectedGuest.guestFname);
                        Guest_Edit_Form ef = new Guest_Edit_Form(SelectedGuest);
                        ef.ShowDialog();
                        this.Hide();
                    }

                }
            if (e.ColumnIndex >= 0 && e.ColumnIndex < GuestDataGrid.Columns.Count && GuestDataGrid.Columns[e.ColumnIndex].HeaderText == "Show")
            {
                MessageBox.Show("Show" + SelectedGuest.guestFname);
                ViewGuests viewGuests = new ViewGuests(SelectedGuest);
                viewGuests.ShowDialog();
            }
            if (e.ColumnIndex >= 0 && e.ColumnIndex < GuestDataGrid.Columns.Count && GuestDataGrid.Columns[e.ColumnIndex].HeaderText == "Delete")
            {


                    if (SelectedGuest != null)
                    {
                        DialogResult result = MessageBox.Show("Are you sure you want to delete this Guest Info?", "Confirmation", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            // Delete the room from the database
                            context.Guests.Remove(SelectedGuest);
                            context.SaveChanges();

                            // Delete the room from the data source
                            context.Guests.Remove(SelectedGuest);

                            // Rebind the data source to refresh the DataGridView
                            GuestDataGrid.DataSource = null;
                            GuestDataGrid.DataSource = guests;

                            MessageBox.Show("Guest Info deleted successfully.");
                            this.Hide();

                        }
                    }
                }
            

        }

        private void GuestSearch_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(GuestSearchTextBox.Text))
            {
                MessageBox.Show("Please enter an Guest ID to search.");
                return;
            }

            if (!long.TryParse(GuestSearchTextBox.Text, out long G_Id))
            {
                MessageBox.Show("Invalid Guest ID. Please enter a valid numeric ID.");
                return;
            }

            var context = new ApplicationDbContext();
            var guest = context.Guests.FirstOrDefault(g => g.guestId.Equals(G_Id.ToString()));

            if (guest != null)
            {
                GuestDataGrid.DataSource = new List<Guest> { guest };
                GuestDataGrid.Columns["Edit"].Visible = true;
                GuestDataGrid.Columns["Delete"].Visible = true;
                GuestDataGrid.Columns["Show"].Visible = true;
            }
            else
            {
                MessageBox.Show("Guest not found.");
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
                this.Hide();
            }
        }
    }
}
    

