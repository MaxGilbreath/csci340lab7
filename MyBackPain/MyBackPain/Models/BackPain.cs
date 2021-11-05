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
        public string DoIHaveBackPain { get; set; }
        [Display(Name = "Date")]

        [DataType(DataType.Date)]
        public DateTime Day { get; set; }
        public string IsItMyFault { get; set; }
        public string DidITakeIbuprofen { get; set; }
        public string DoIShakeMyFistsAtTheSky { get; set; }
    }
}
