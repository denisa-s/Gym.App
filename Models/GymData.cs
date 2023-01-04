using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect1.Models
{
    public class GymData
    {
        public IEnumerable<GymInfo> Gymss { get; set; }
        public IEnumerable<CategoryInfo> Categories { get; set; }
    }
}
