using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Configuration;

using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace YoursTruly.Models
{
    public class Skill
    {


        [Key]
        [Display(AutoGenerateField = true, Name = "I.D.")]
        public int ID { get; set; }

        [Display(Name = "Name")]
        [Required]
        [MaxLength(100, ErrorMessage = "Must be less than 100 characters long")]
        public string Name { get; set; } = "Default Name";

        [Required]
        public Int32 Rank { get; set;  }




        public Skill()
        {
            //Width = 640;
            //Height = 480; 
        }

    }
}