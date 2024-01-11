using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITIES
{
    public class WeekEmployee
    {
        [Key]
        public int IdWeekEmployee { get; set; }

        //public int IdWeek { get; set; }

        //public int IdEmployee { get; set; }

        //[ForeignKey("IdWeek")]
        public Week Week { get; set; }

        //[ForeignKey("IdEmployee")]
        public Employee Employee { get; set; }       
    }
}
