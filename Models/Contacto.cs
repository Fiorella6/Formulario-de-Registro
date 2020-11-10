using System.ComponentModel.DataAnnotations;


namespace Formulario_de_Registro.Models
{
    public class Contacto
    {
          [Required]
        public string nombre { get; set; }

        [Required]
        [EmailAddress]
         public string correo { get; set; }
    }
}
