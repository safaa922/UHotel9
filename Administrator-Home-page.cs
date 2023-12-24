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

namespace UHotel9
{
    public partial class Administrator_Home_page : Form
    {



        private FormStack formStack = new FormStack();
        private void ShowNewForm()
        {
            // Show the new form and push it onto the stack
            var newForm = new AnotherForm(formStack);
            formStack.Push(newForm);
            newForm.Show();
        }


        public Administrator_Home_page()
        {
            InitializeComponent();
        }

        private void HomeEmployeeReportInfo_Click(object sender, EventArgs e)
        {
            employee_Info_Report ef = new employee_Info_Report();
            ef.Show();
        }

        private void AdministratorRoomInfo_Click(object sender, EventArgs e)
        {
            Room_Info_Report rI = new Room_Info_Report();
            rI.Show();
        }

        private void AdministratorGuestInfoButton_Click(object sender, EventArgs e)
        {
            guest_Info_Report gs = new guest_Info_Report();
            gs.Show();
        }

        private void Home_Page_Label_Click(object sender, EventArgs e)
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
