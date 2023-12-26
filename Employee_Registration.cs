//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Data.Entity.Infrastructure;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Text.RegularExpressions;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using UHotel9.Tables;
//using static UHotel9.Employee_Registration;
//using BCryptNet = BCrypt.Net.BCrypt;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using UHotel9.Tables;
using static UHotel9.Employee_Registration;
using BCryptNet = BCrypt.Net.BCrypt;
namespace UHotel9
{
    public partial class Employee_Registration : Form
    {
        string selectedImgPath = "";
        string ProjImgPath = Environment.CurrentDirectory + "\\Emp_Images";




        private FormStack formStack = new FormStack();
        private void ShowNewForm()
        {
            // Show the new form and push it onto the stack
            var newForm = new AnotherForm(formStack);
            formStack.Push(newForm);
            newForm.Show();
        }



        public Employee_Registration()
        {
            InitializeComponent();
        }

        public class UserService
        {
            public bool VerifyPassword(string enteredPassword, string savedPasswordHash)
            {
                return BCryptNet.Verify(enteredPassword, savedPasswordHash);
            }

            public string HashPassword(string password)
            {
                return BCryptNet.HashPassword(password);
            }
        }




        //private void Employee_ButtonBox_Click(object sender, EventArgs e)
        //{




        //public byte[] ImageToByteArray(Image image)

        //{
        //    using (MemoryStream ms = new MemoryStream())
        //    {

        //        if (image != null)
        //        {
        //            image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
        //            return ms.ToArray();
        //        }

        //        return null;
        //    }


        private void Employee_AgeBox_TextChanged(object sender, EventArgs e)
        {
            // [Range(1, int.MaxValue, ErrorMessage = "Age must be a Postive value ")]
        }

        private void Photo_Upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog Dialog = new OpenFileDialog();
            if (Dialog.ShowDialog() == DialogResult.OK)
            {
                Employee_PictureBox.ImageLocation = Dialog.FileName;
                selectedImgPath = Dialog.FileName;
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

        private void Employee_ButtonBox_Click_1(object sender, EventArgs e)
        {



            ApplicationDbContext db = new ApplicationDbContext();
            UserService userr = new UserService();
            try
            {
                Employee e1 = new Employee()
                {

                    // nametx is the name of the textbox
                    // _Gender is casting male =0 and female =1
                    employeeId = Employee_IdBox.Text,
                    employeeFname = Employee_FNameBox.Text,
                    employeeLname = Employee_LNameBox.Text,
                    // Employye_UserName = Employee.UserNameBox.Text,
                    // Password pass_tx.Text,
                    email = Employee_EmailBox.Text,

                    gender = (EmployeeGender)Employee_GenderBox.SelectedIndex,

                    city = Employee_CityBox.Text,
                    country = Employee_CountryBox.Text,
                    employeeSalary = decimal.Parse(Employee_SalaryBox.Text),

                    employeeAge = int.Parse(Employee_AgeBox.Text),


                    employeePhone = Employee_PhoneBox.Text,

                    department = (EmployeeDepartment)Employee_DepartmentBox.SelectedIndex,
                    status = (EmployeeStatus)EmployeeStatusBox.SelectedIndex,

                    // employeePhoto = ImageToByteArray(Employee_PictureBox.Image),

                    // employeePhoto = Employee_PictureBox.Text,

                    employeePhoto = "NoImg",
                    Password = Employee_PasswordBox.Text,

                    username = Employee_UserNameBox.Text

                };

                int c = 0;
                if (string.IsNullOrWhiteSpace(e1.Password))
                {

                    MessageBox.Show("Invalid password");
                    c++;

                }

                if (e1.employeeAge <= 18 || e1.employeeAge >= 70)
                {
                    MessageBox.Show("enter age from 18 to 70");
                    c++;
                }

                if (e1.Password.Length >= 8 && e1.Password.Any(char.IsDigit) && e1.Password.Any(char.IsLetter) && e1.Password.Any(c => c == '@' || c == '#'))
                {
                    e1.Password = userr.HashPassword(Employee_PasswordBox.Text);
                }
                else
                {
                    MessageBox.Show("Password does not meet the requirements.");
                    c++;
                }

                if (e1.department == EmployeeDepartment.IT || e1.department == EmployeeDepartment.Kitchen || e1.department == EmployeeDepartment.Purchase
                    || e1.department == EmployeeDepartment.FrontOffice || e1.department == EmployeeDepartment.EngineeringAndMaintenance ||
                    e1.department == EmployeeDepartment.Accounts || e1.department == EmployeeDepartment.FoodAndBeverageService ||
                    e1.department == EmployeeDepartment.Housekeeping || e1.department == EmployeeDepartment.HumanResources ||
                    e1.department == EmployeeDepartment.SalesAndMarketing || e1.department == EmployeeDepartment.Security ||
                    e1.department == EmployeeDepartment.DataEntry || e1.department == EmployeeDepartment.Managment)
                {

                }
                else
                {
                    MessageBox.Show("Invalid Department, please choose from the list");
                    c++;
                }
                if (e1.gender == EmployeeGender.Female || e1.gender == EmployeeGender.Male)
                {


                }
                else
                {
                    c++;
                    MessageBox.Show("Invalid Gender, please choose from the list");
                }
                if (e1.status == EmployeeStatus.married || e1.status == EmployeeStatus.engaged || e1.status == EmployeeStatus.single)
                {

                }
                else
                {
                    c++;
                    MessageBox.Show("Invalid Status, please choose from the list");
                }
                if (e1.employeeId.Length != 14)
                {
                    c++;
                    MessageBox.Show("Invalid ID, ID is 14 Digit");
                }
                if (!e1.employeeFname.All(char.IsLetter))
                {
                    c++;
                    MessageBox.Show("Invalid FristName");

                }
                if (!e1.employeeLname.All(char.IsLetter))
                {
                    c++;
                    MessageBox.Show("Invalid LastName");

                }

                if (int.TryParse(e1.employeePhone, out _))
                {
                    // The value is numeric (integer)
                    // Console.WriteLine("Numeric value");
                }
                else
                {
                    // The value is not numeric
                    MessageBox.Show("Invalid Phone Number, Enter Only Numbers");
                    c++;
                }
                if (!e1.city.All(char.IsLetter))
                {
                    c++;
                    MessageBox.Show("Invalid City Name");

                }
                if (!e1.country.All(char.IsLetter))
                {
                    c++;
                    MessageBox.Show("Invalid Country Name");

                }
                if (e1.employeeSalary < 0)
                {
                    c++;
                    MessageBox.Show("Invalid Salary");
                }
                if (IsValidEmail(Employee_EmailBox.Text))
                {

                }
                else
                {
                    //Console.WriteLine("Email is not valid.");
                    MessageBox.Show("Email is not valid.");
                    c++;

                }
                if (c == 0)
                {
                    db.Employees.Add(e1);
                    db.SaveChanges();
                    if (!string.IsNullOrWhiteSpace(selectedImgPath))
                    {
                        string newImgPath = ProjImgPath + "\\" + e1.employeeId + "_.jpg";
                        File.Copy(selectedImgPath, newImgPath);
                    }

                    MessageBox.Show("added successfully");
                    Employee_Log_In l = new Employee_Log_In();
                    l.Show();
                    this.Hide();

                }
                static bool IsValidEmail(string email)
                {
                    // Define a regular expression for email validation
                    string pattern = @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+(?:\.[a-zA-Z]{2,}){1,3}$";

                    // Create a Regex object
                    Regex regex = new Regex(pattern);

                    // Use the IsMatch method to validate the email
                    return regex.IsMatch(email);

                }
            }
            catch (FormatException)
            {
                if (!string.IsNullOrEmpty(Employee_AgeBox.Text))
                {
                    if (!(int.TryParse(Employee_AgeBox.Text, out _)))
                    {
                        MessageBox.Show("Invalid age");
                    }

                }
                if (!(string.IsNullOrEmpty(Employee_SalaryBox.Text)))
                {
                    if (!(decimal.TryParse(Employee_SalaryBox.Text, out _)))
                    {
                        MessageBox.Show("Invalid Salary");

                    }
                }


                MessageBox.Show("all fields are required");
                
            }

            catch (DbUpdateException ex)
            {
                //var sqlException = ex.GetBaseException() as SqlException;
                MessageBox.Show("this Employee already exsists");
                //if (ex.InnerException is SqlException sqlException && sqlException.Number == 2627)
                //{
                //    MessageBox.Show("this Guest is already exsits");

                //}
                //else
                //{

                //    MessageBox.Show("");
                //   // throw ex;
                //}
            }



        }

        private void Photo_Upload_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog Dialog = new OpenFileDialog();
            if (Dialog.ShowDialog() == DialogResult.OK)
            {
                Employee_PictureBox.ImageLocation = Dialog.FileName;
                selectedImgPath = Dialog.FileName;
            }
        }
    }
}



