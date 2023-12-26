using DevExpress.Charts.Native;
using DevExpress.Xpo.DB;
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
    public partial class Accountant : Form
    {
        ApplicationDbContext db = new ApplicationDbContext();



        private FormStack formStack = new FormStack();
        private void ShowNewForm()
        {
           
            var newForm = new AnotherForm(formStack);
            formStack.Push(newForm);
            newForm.Show();
        }
        public Accountant()
        {
            InitializeComponent();
        }

      

        private void revenueButton_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = revenueBox.Value;
            Revenue revenueForm = new Revenue(selectedDate);
            revenueForm.Show();     

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
               
                this.Close();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
       
    }
}
