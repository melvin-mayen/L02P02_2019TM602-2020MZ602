using System.ComponentModel.DataAnnotations;

namespace L02P02_2019TM602_2020MZ602.Models
{
    public class departamentos
    {


        [Key]

        [Display(Name = "Id")]
        public int id { get; set; }

        
        [Display(Name = "Departamento")]
        public string? departamento { get; set; }

        
        [Display(Name = "Estado")]
        public string? estado { get; set; }

      
        [Display(Name = "Created_at")]
        public DateTime created_at { get; set; }


    }
}
