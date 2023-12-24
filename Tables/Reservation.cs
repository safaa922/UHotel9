using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UHotel9.Tables
{
   
        [Table("Reservations")]
        public class Reservation
        {
            [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int reservationId { get; set; }

            [Required]
            public DateTime checkInDate { get; set; }

            [Required]
            public DateTime checkOutDate { get; set; }
            [RegularExpression("^[0-9]*$", ErrorMessage = "Only numeric values are allowed.")]
            public string guestId { get; set; }  //foreignkey
            public int? roomId { set; get; }        //foreign key
                                                   //navigation 
            [ForeignKey("roomId")]
            public virtual Room Room { get; set; }
            //navigation
            [ForeignKey("guestId")]
            public virtual Guest Guest { get; set; }


        }
    }

