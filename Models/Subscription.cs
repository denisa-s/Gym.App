using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proiect1.Models;
using SQLite;

namespace Proiect1.Models
{
    public class Subscription
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public int? ClientID { get; set; }
       // public ClientInfo? Client { get; set; } //navigation property
        public int? GymID { get; set; }
        //public GymInfo? Gym { get; set; }  //navigation property
        [DataType(DataType.Date)]

        [Display(Name = "Subscription expiration date")]
        public DateTime ReturnDate { get; set; }
    }
}
