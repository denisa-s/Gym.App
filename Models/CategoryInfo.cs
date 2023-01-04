using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect1.Models
{
    public class CategoryInfo
    {
        [PrimaryKey,AutoIncrement]
        public int ID { get; set; }
        public string CategoryName { get; set; }
        [OneToMany]
        public List<TrainerCategory>? TrainerCategories { get; set; }
    }
}
