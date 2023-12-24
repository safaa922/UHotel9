using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UHotel9.Tables
{
    
        [Table("Guests")]
        public class Guest
        {

            public enum GuestGender { Male, Female }
            public enum Status { single, married, engaged }

            [Key]
            [MaxLength(14)]
            [RegularExpression("^[0-9]*$", ErrorMessage = "Only numeric values are allowed.")]
            public string guestId { get; set; }
            [Required]
            [Column(TypeName = "nvarchar(200)")]
            public string guestFname { get; set; }
            [Required]
            [Column(TypeName = "nvarchar(200)")]
            public string guestLname { get; set; }
            [Required]
            public GuestGender gender { get; set; }

            [EmailAddress]
            public string email { get; set; }
            [Required]
            [Column(TypeName = "nvarchar(150)")]
            [RegularExpression("^[0-9]*$", ErrorMessage = "Only numeric values are allowed.")]
            public string phone { get; set; }
            [Required]
            [Column(TypeName = "nvarchar(200)")]
            public Status status { get; set; }
            [Required]
            [Column(TypeName = "nvarchar(200)")]
            public string country { set; get; }     //enum
            [Required]
            [Column(TypeName = "nvarchar(200)")]
            public string city { get; set; }      //enum
            public int roomId { get; set; }    //foreign key

            //navigation 
            [ForeignKey("roomId")]
            public Room Room { get; set; }
            //collection navigation 
            public ICollection<Reservation> Reservations { get; set; }
        }
    }
