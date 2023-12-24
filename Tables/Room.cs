using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UHotel9.Tables
{

   
    public enum RoomType {Single,Double,Suite }
 //   public enum RoomStatus { Booked, UnBOOKED }
    [Table("Rooms")]
    public class Room
    {

       [Key]
        public int roomId { get; set; }

        [Required]
        public RoomType type { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "floor number must be a Postive value ")]
        public int floorNumber { get; set; }
        [Required]
        [Column(TypeName = "decimal")]
        public decimal price { get; set; }

        //collection navigation 
        public ICollection<Reservation> Reservations { get; set; }
        //collection navigation
        public ICollection<Guest> Guests { get; set; }

    }
}

