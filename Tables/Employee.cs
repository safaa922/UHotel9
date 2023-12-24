using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UHotel9.Tables
{

    public enum EmployeeGender { Male, Female }
    public enum EmployeeStatus { single, married, engaged }
    public enum EmployeeDepartment
    {
        IT, FrontOffice, Housekeeping, FoodAndBeverageService,
        Kitchen, Accounts, Security, HumanResources, SalesAndMarketing,
        Purchase, EngineeringAndMaintenance,Managment, DataEntry
    }
    [Table("Employees")]
    public class Employee
    {


        //   [MaxLength(14)]

        [Key]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Only numeric values are allowed.")]
        public string employeeId { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(200)")]
        public string employeeFname { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(200)")]
        public string employeeLname { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(200)")]
        public string username { get; set; }


        [Required]
        [Column(TypeName = "nvarchar(200)")]
        public string Password { get; set; }



        [Required]
        public EmployeeGender gender { set; get; }

        [Required]
        [EmailAddress]
        public string email { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(200)")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Only numeric values are allowed.")]
        public string employeePhone { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(200)")]
        public EmployeeStatus status { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(200)")]
        public string country { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(200)")]
        public string city { get; set; }
        [Required]
        [Column(TypeName = "int")]
        [Range(1, int.MaxValue, ErrorMessage = "Age must be a Postive value ")]
        public int employeeAge { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(200)")]

        public EmployeeDepartment department { get; set; }
        [Required]
        [Column(TypeName = "decimal")]
        public decimal employeeSalary { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(max)")]
        public string employeePhoto { set; get; }  //we will add package --> using System.ComponentModel.DataAnnotations.Schema; 




    }
}