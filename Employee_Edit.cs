using DevExpress.UnitConversion;
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
    public partial class Employee_Edit : Form
    {

        private FormStack formStack = new FormStack();
        private void ShowNewForm()
        {
            // Show the new form and push it onto the stack
            var newForm = new AnotherForm(formStack);
            formStack.Push(newForm);
            newForm.Show();
        }





        string SelectedImagePath = "";
        private Employee employee;
        ApplicationDbContext context = new ApplicationDbContext();
        UserService userService = new UserService();


        // Updated constructor to accept an Employee parameter
        public Employee_Edit(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
            var Empp = context.Employees;
        }

        private void Employee_ButtonBox_Click(object sender, EventArgs e)
        {

            this.employee.employeeId = Employee_IdBox_Edit.Text;
            this.employee.employeeFname = Employee_FNameBox_Edit.Text;
            this.employee.employeeLname = Employee_LNameBox_Edit.Text;

            this.employee.email = Employee_EmailBox_Edit.Text;

            this.employee.gender = (EmployeeGender)Employee_GenderBox_Edit.SelectedIndex;

            this.employee.city = Employee_CityBox_Edit.Text;
            this.employee.country = Employee_CountryBox_Edit.Text;

            this.employee.employeePhone = Employee_PhoneBox_Edit.Text;
            this.employee.status = (EmployeeStatus)EmployeeStatusBox_Edit.SelectedIndex;
            this.employee.employeeSalary = decimal.Parse(Employee_SalaryBox_Edit.Text);
            //string un = EmployeeUserName_Log.Text;


            //string pass = Employee_PasswordBox_Edit.Text;
            //string un =Employee_UserNameBox_Edit.Text;



            // // Employee Empp = new Employee();

            // var Empp = context.Employees.Where(e => e.username == un).FirstOrDefault();
            // this.employee.Password = userService.VerifyPassword(pass, Empp.Password).ToString();


            this.employee.Password = Employee_PasswordBox_Edit.Text;
            this.employee.department = (EmployeeDepartment)Employee_DepartmentBox_Edit.SelectedIndex;
            this.employee.employeePhoto = Employee_PictureBox_Edit.ImageLocation;
            this.employee.employeeAge = int.Parse(Employee_AgeBox_Edit.Text);
            this.employee.username = Employee_UserNameBox_Edit.Text;
            context.Employees.Update(this.employee);
            context.SaveChanges();

            if (!string.IsNullOrEmpty(SelectedImagePath))
            {
                string destination_Path = Environment.CurrentDirectory + "\\Emp_Images\\" + this.employee.employeeId + ".jpg";
                if (!Directory.Exists(Environment.CurrentDirectory + "\\Emp_Images"))
                {
                    Directory.CreateDirectory(Environment.CurrentDirectory + "\\Emp_Images");
                }

                File.Copy(SelectedImagePath, destination_Path, true);
                this.employee.employeePhoto = destination_Path;
            }

            context.Employees.Update(this.employee);
            context.SaveChanges();
            MessageBox.Show("Updated");




        }

        private void Employee_Edit_Load(object sender, EventArgs e)
        {

            //Employee EditEmployee = context.Employees.Where(ep => ep.employeeId == this.employee.employeeId).FirstOrDefault();
            //if (EditEmployee != null)
            //{
            Employee_IdBox_Edit.Text = this.employee.employeeId;
            Employee_FNameBox_Edit.Text = this.employee.employeeFname;
            Employee_LNameBox_Edit.Text = this.employee.employeeLname;

            Employee_EmailBox_Edit.Text = this.employee.email;

            Employee_GenderBox_Edit.SelectedIndex = (int)(EmployeeGender)this.employee.gender;

            Employee_CountryBox_Edit.Text = this.employee.country;
            Employee_CityBox_Edit.Text = this.employee.city;

            Employee_PhoneBox_Edit.Text = this.employee.employeePhone;
            EmployeeStatusBox_Edit.SelectedIndex = (int)(EmployeeStatus)this.employee.status;
            Employee_SalaryBox_Edit.Text = this.employee.employeeSalary.ToString();
            Employee_PasswordBox_Edit.Text = this.employee.Password;
            Employee_DepartmentBox_Edit.Text = this.employee.department.ToString();
            Employee_PictureBox_Edit.ImageLocation = this.employee.employeePhoto;
            //  MessageBox.Show($"Image Path: {this.employee.employeePhoto}");

            Employee_AgeBox_Edit.Text = this.employee.employeeAge.ToString();
            Employee_UserNameBox_Edit.Text = this.employee.username;


            //}
        }

        private void Photo_Upload_Edit_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Employee_PictureBox_Edit.ImageLocation = dialog.FileName;
                SelectedImagePath = dialog.FileName;
            }
        }

        private void Employee_PictureBox_Edit_Click(object sender, EventArgs e)
        {

        }

        private void BackButton_Edit_Click(object sender, EventArgs e)
        {

        }
    }
}
