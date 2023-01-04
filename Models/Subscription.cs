using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proiect1.Models;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace Proiect1.Models
{
    public class Subscription
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [ForeignKey(typeof(ClientInfo))]
        public int? ClientID { get; set; }
  
        [ForeignKey(typeof(GymInfo))]
        public int? GymID { get; set; }
        [DataType(DataType.Date)]

        [Display(Name = "Subscription expiration date")]
        public DateTime ReturnDate { get; set; }
    }
}
