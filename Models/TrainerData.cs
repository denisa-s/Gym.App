using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect1.Models
{
    public class TrainerData
    {
        public IEnumerable<TrainerInfo> Trainers { get; set; }
        public IEnumerable<CategoryInfo> Categories { get; set; }
        public IEnumerable<TrainerCategory> TrainerCategories { get; set; }
    }
}
