using System.ComponentModel.DataAnnotations;

namespace L02P02_2019TM602_2020MZ602.Models
{
    public class clientes
    {


        [Key]
        [Display(Name = "ID")]
        public int id { get; set; }

        [Display(Name = "Nombre")]
        public string? nombre { get; set; }

        [Display(Name = "Apellido")]
        public string? apellido { get; set; }

        [Display(Name = "Email")]
        public string? email { get; set; }

        [Display(Name = "Url Imagen")]
        public string? url_imagen { get; set; }

        [Display(Name = "Direccion")]
        public string direccion { get; set; }

        [Display(Name = "Genero")]
        public string? genero { get; set; }

        [Display(Name = "Id Departamento")]
        public int id_departamento { get; set; }


        [Display(Name = "Id Puesto")]
        public int id_puesto { get; set; }

        [Display(Name = "Estado Registro")]
        public string? estado_registro { get; set; }

        [Display(Name = "Created")]
        public DateTime created_at { get; set; }

        [Display(Name = "Updated")]
        public DateTime updated_at { get; set; }



    }
}
