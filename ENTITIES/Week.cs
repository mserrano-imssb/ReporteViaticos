using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITIES
{
    public class Week
    {
        [Key] 
        public int Id { get; set; }
        
        public int Year { get; set; }
        
        public int Month { get; set; }
        
        public int Number { get; set; }
        
        public string Description { get; set; }
    }
}
