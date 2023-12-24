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
    public partial class Data_Entry : Form
    {


        private FormStack formStack = new FormStack();
        private void ShowNewForm()
        {
            // Show the new form and push it onto the stack
            var newForm = new AnotherForm(formStack);
            formStack.Push(newForm);
            newForm.Show();
        }



        public Data_Entry()
        {
            InitializeComponent();
        }

        private void DataEntryEmployeeInfo_Click(object sender, EventArgs e)
        {
            Employee_Registration em = new Employee_Registration();
            em.Show();
        }

        private void DataEntryRoomInfo_Click(object sender, EventArgs e)
        {
            Rooms_Form rf = new Rooms_Form();
            rf.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
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
    }
}
