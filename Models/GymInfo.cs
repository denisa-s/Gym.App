using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect1.Models
{
    public class GymInfo
    {
        [PrimaryKey,AutoIncrement]
        public int GymId { get; set; }  
        public string GymName { get; set; }
        public string GymAddress { get; set; }
        public decimal GymPrice { get; set; }
        public decimal GymReview { get; set; }
        public string GymPhone  { get; set; }
        public string GymDetails
        {
            get
            {
                return GymName + ""+GymAddress;
            } 
        }
        [OneToMany]
        public List<Subscription> Subscriptions { get; set; }
    }
}
