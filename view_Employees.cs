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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static UHotel9.Tables.Employee;

namespace UHotel9
{
    public partial class view_Employees : Form
    {
        private Employee employee;
        ApplicationDbContext context = new ApplicationDbContext();


        private FormStack formStack = new FormStack();
        private void ShowNewForm()
        {
            // Show the new form and push it onto the stack
            var newForm = new AnotherForm(formStack);
            formStack.Push(newForm);
            newForm.Show();
        }

        public view_Employees(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
        }

        private void view_Employees_Load(object sender, EventArgs e)
        {
            EmployeeIdBoxView.Text = this.employee.employeeId;
            EmployeeFNameBoxView.Text = this.employee.employeeFname;
            EmployeeLNameBoxView.Text = this.employee.employeeLname;

            EmployeeEmailBoxView.Text = this.employee.email;

            EmployeeGenderBoxView.SelectedIndex = (int)this.employee.gender;

            EmployeeCityBoxView.Text = this.employee.city;
            EmployeeCountryBoxView.Text = this.employee.country;

            EmployeePhoneBoxView.Text = this.employee.employeePhone;
            EmployeeStatusBoxView.SelectedIndex = (int)(EmployeeStatus)this.employee.status;
            EmployeeSalaryBoxView.Text = this.employee.employeeSalary.ToString();
            EmployeePasswordBoxView.Text = this.employee.Password;
            EmployeeDepartmentBoxView.Text = ((EmployeeDepartment)this.employee.department).ToString();
            Employee_PictureBox_View.ImageLocation = this.employee.employeePhoto;
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
