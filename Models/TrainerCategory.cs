using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using SQLiteNetExtensions.Attributes;
namespace Proiect1.Models
{
    public class TrainerCategory
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [ForeignKey(typeof(TrainerInfo))]
        public int TrainerID { get; set; }
        [ForeignKey(typeof(CategoryInfo))]
        public int CategoryID { get; set; }
        public string Description { get; set; }
        public TrainerInfo TrainerInfo { get; set; }
        public CategoryInfo CategoryInfo { get; set; }
    }
}
