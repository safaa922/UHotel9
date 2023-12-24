using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlClient;
using UHotel9.Tables;
using DevExpress.DashboardWin.Design;
using static System.ComponentModel.Design.ObjectSelectorEditor;


namespace UHotel9
{
    public partial class employee_Info_Report : Form
    {
        // string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=UHotel;Integrated Security=True;Connect Timeout=30;Encrypt=False;";


        private FormStack formStack = new FormStack();
        private void ShowNewForm()
        {
            // Show the new form and push it onto the stack
            var newForm = new AnotherForm(formStack);
            formStack.Push(newForm);
            newForm.Show();
        }




        public employee_Info_Report()
        {
            InitializeComponent();
        }

        private void ShowEmployeeInfo_Click(object sender, EventArgs e)
        {
            var context = new ApplicationDbContext();
            var emp = context.Employees.ToList();
            var ep = from em in emp select new { em.employeeId, em.employeeFname, em.employeeLname, em.department };
            dataGridViewEmployee.DataSource = emp.ToList();

            // Add "Edit", "Show", and "Delete" button columns
            dataGridViewEmployee.Columns.Add(new DataGridViewButtonColumn { Text = "Edit", Name = "Edit", UseColumnTextForButtonValue = true });
            dataGridViewEmployee.Columns.Add(new DataGridViewButtonColumn { Text = "Show", Name = "Show", UseColumnTextForButtonValue = true });
            dataGridViewEmployee.Columns.Add(new DataGridViewButtonColumn { Text = "Delete", Name = "Delete", UseColumnTextForButtonValue = true });

            dataGridViewEmployee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }




        private void dataGridViewEmployee_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var context = new ApplicationDbContext();
            var emp = context.Employees.ToList();
            if (e.RowIndex >= 0)
            {

                var row = dataGridViewEmployee.Rows[e.RowIndex];
                string E_id = row.Cells["employeeId"].Value.ToString();
                string employeeId = E_id;

                Employee Selectedemployee = context.Employees.Where(e => e.employeeId == E_id).FirstOrDefault();

                if (e.ColumnIndex == dataGridViewEmployee.Columns["Edit"].Index)
                {
                    if (Selectedemployee != null)
                    {
                        MessageBox.Show("Edit " + Selectedemployee.employeeFname);
                        Employee_Edit ee = new Employee_Edit(Selectedemployee);
                        ee.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Not Found");
                    }
                }
                if (e.ColumnIndex >= 0 && e.ColumnIndex < dataGridViewEmployee.Columns.Count && dataGridViewEmployee.Columns[e.ColumnIndex].HeaderText == "Show")
                {




                    if (Selectedemployee != null)
                    {
                        MessageBox.Show("Show" + Selectedemployee.employeeFname);
                        view_Employees ve = new view_Employees(Selectedemployee);
                        ve.ShowDialog();
                    }

                }
                if (e != null && dataGridViewEmployee.Columns["Delete"] != null && e.ColumnIndex == dataGridViewEmployee.Columns["Delete"].Index)
                {


                    if (Selectedemployee != null)
                    {
                        DialogResult result = MessageBox.Show("Are you sure you want to delete this Employee Data ?", "Confirmation", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            // Delete the room from the database
                            context.Employees.Remove(Selectedemployee);
                            context.SaveChanges();

                            // Delete the room from the data source
                            emp.Remove(Selectedemployee);

                            // Rebind the data source to refresh the DataGridView
                            dataGridViewEmployee.DataSource = null;
                            dataGridViewEmployee.DataSource = emp;

                            MessageBox.Show("Employee Data deleted successfully.");
                            this.Close();

                        }
                    }
                }
            }

        }


        private void EmployeeSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(EmployeeSearchTextBox.Text))
            {
                MessageBox.Show("Please enter an employee ID to search.");
                return;
            }

            if (!long.TryParse(EmployeeSearchTextBox.Text, out long empId))
            {
                MessageBox.Show("Invalid employee ID. Please enter a valid numeric ID.");
                return;
            }

            var context = new ApplicationDbContext();
            var employee = context.Employees.FirstOrDefault(emp => emp.employeeId.Equals(empId.ToString()));

            if (employee != null)
            {
                dataGridViewEmployee.DataSource = new List<Employee> { employee };
                dataGridViewEmployee.Columns["Edit"].Visible = true;
                dataGridViewEmployee.Columns["Delete"].Visible = true;
                dataGridViewEmployee.Columns["Show"].Visible = true;
            }
            else
            {
                MessageBox.Show("Employee not found.");
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

        private void EmployeeSearchTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

