using Microsoft.VisualBasic.ApplicationServices;
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
using static UHotel9.Employee_Registration;

namespace UHotel9
{
    public partial class Employee_Log_In : Form
    {

        private FormStack formStack = new FormStack();
        private void ShowNewForm()
        {
            // Show the new form and push it onto the stack
            var newForm = new AnotherForm(formStack);
            formStack.Push(newForm);
            newForm.Show();
        }



        private UserService userService; // Create an instance of the UserService class

        public Employee_Log_In()
        {
            InitializeComponent();
            userService = new UserService(); // Initialize the UserService instance
        }

        private void Employee_LogInBox_Click(object sender, EventArgs e)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            try
            {
                // Employee e1 = new Employee();
                string un = EmployeeUserName_Log.Text;
                string pass = EmployeePassword_Log.Text;
                if (!string.IsNullOrWhiteSpace(un) && !string.IsNullOrWhiteSpace(pass))
                {
                    var Empp = db.Employees.Where(e => e.username == un).FirstOrDefault();
                    if (Empp != null && userService.VerifyPassword(pass, Empp.Password))
                    {


                        if (Empp.department == EmployeeDepartment.FrontOffice)
                        {


                            MessageBox.Show("Welcome " + Empp.username);
                            Front_Office fo = new Front_Office();
                            fo.Show();
                            this.Hide();
                        }
                        else if (Empp.department == EmployeeDepartment.DataEntry)
                        {


                            MessageBox.Show("Welcome " + Empp.username);
                            Data_Entry de = new Data_Entry();
                            de.Show();
                            this.Hide();
                        }
                        else if (Empp.department == EmployeeDepartment.Managment)
                        {


                            MessageBox.Show("Welcome " + Empp.username);
                            Administrator_Home_page Admin = new Administrator_Home_page();
                            Admin.Show();
                            this.Hide();
                        }
                        else if (Empp.department == EmployeeDepartment.Accounts)
                        {


                            MessageBox.Show("Welcome " + Empp.username);
                            Accountant aa = new Accountant();
                            aa.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Welcome " + Empp.username);
                        }
                        //else
                        //{
                        //    MessageBox.Show("Invalid username or password");
                        //}
                    }
                    else
                    {
                        MessageBox.Show("Check Your UserName Or Your PassWord");
                    }

                    //if (e1.department == EmployeeDepartment.Managment) ;
                    //DashBoard d = new DashBoard();
                    //d.Show();
                    //this.Hide();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("please, enter your username and password");
                //if(string.IsNullOrEmpty(EmployeeUserName_Log.Text))
                //{
                //    MessageBox.Show("please enter your User Name");
                //}
                //if (string.IsNullOrEmpty(EmployeePassword_Log.Text))
                //{
                //    MessageBox.Show("please enter your password");
                //}

            }
        }
        private void Registrate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Employee_Registration s = new Employee_Registration();
            s.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Welcome_Click(object sender, EventArgs e)
        {

        }

        private void Employee_Log_In_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomePage_ h = new HomePage_();
            h.Show();
            this.Hide();
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