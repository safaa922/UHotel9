﻿using System;
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
    public partial class Room_Status : Form
    {


        private FormStack formStack = new FormStack();
        private void ShowNewForm()
        {
            // Show the new form and push it onto the stack
            var newForm = new AnotherForm(formStack);
            formStack.Push(newForm);
            newForm.Show();
        }



        public Room_Status()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            // ApplicationDbContext db = new ApplicationDbContext();
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "Room Number";
            dataGridView1.Columns[1].Name = "Room Type";
            dataGridView1.Columns[2].Name = "Room Floor";
            dataGridView1.Columns[3].Name = "Room Price";

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DateTime CurrentDateTime = DateTime.Now;
            using (var context = new ApplicationDbContext())
            {
                var rooms = context.Rooms.ToList(); // Assuming "Rooms" is the DbSet property in your DbContext
                var occupiedRooms = context.Reservations
                 .Where(reservation => !(CurrentDateTime >= reservation.checkOutDate || CurrentDateTime <= reservation.checkInDate))
                 .Select(reservation => reservation.roomId)
                 .ToList();

                var freeRooms = context.Rooms
                    .Where(room => !occupiedRooms.Contains(room.roomId))
                    .ToList();
                foreach (var room in freeRooms)
                {
                    dataGridView1.Rows.Add(room.roomId, room.type, room.floorNumber, room.price);
                }

                //  dataGridView1.Rows.Add(room.roomId, room.type, room.floorNumber, room.price);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Front_Office fo = new Front_Office();
            fo.Show();
            this.Hide();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void RoomSearch_Click(object sender, EventArgs e)
        {

        }
    }
}

