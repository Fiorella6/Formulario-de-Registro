using System.ComponentModel.DataAnnotations;


namespace Formulario_de_Registro.Models
{
    public class Contacto
    {
          [Required]
        public string nombre { get; set; }

        [Required]
         public string precio { get; set; }

         [Required]
         public string descripcion { get; set; }
    }
}
