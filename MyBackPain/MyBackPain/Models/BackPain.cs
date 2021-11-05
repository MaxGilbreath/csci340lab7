using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MyBackPain.Models
{
    public class BackPain
    {
        public int ID { get; set; }
        [StringLength(60, MinimumLength = 1)]
        [Required]
        public string DoIHaveBackPain { get; set; }
        [Display(Name = "Date")]

        [DataType(DataType.Date)]
        public DateTime Day { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string IsItMyFault { get; set; }
        [StringLength(60, MinimumLength = 1)]
        [Required]
        public string DidITakeIbuprofen { get; set; }
        [StringLength(60, MinimumLength = 1)]
        [Required]
        public string DoIShakeMyFistsAtTheSky { get; set; }
    }
}
