using SQLite;
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

        //public List<TrainerCategory>? TrainerCategories { get; set; }
    }
}
