using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OpportunIT_Platform.Entities
{
    public class Login
    {
        [Key]
        public int IdLogin { get; set; }
        public decimal IdUser { get; set; } 
        public string UsPassword { get; set; }

        public DateTime DueDay { get; set; }

        public DateTime LogDate { get; set; }

        public char IsActive { get; set; }


     
    }
}
