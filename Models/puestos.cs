using System.ComponentModel.DataAnnotations;

namespace L02P02_2019TM602_2020MZ602.Models
{
    public class puestos
    {



        [Key]
        [Display(Name = "ID")]
        public int id { get; set; }

        [Display(Name = "Puesto")]
        public string? puesto { get; set; }

        [Display(Name = "Estado")]
        public string? estado { get; set; }

        [Display(Name = "Created")]
        public DateTime created_at { get; set; }


    }
}
