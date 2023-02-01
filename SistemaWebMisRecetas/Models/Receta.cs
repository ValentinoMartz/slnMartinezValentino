using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using SistemaWebMisRecetas.Validations;

namespace SistemaWebMisRecetas.Models
{
    [Table("Receta")]
    public class Receta
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El Nombre es obligatorio")]
        [Column(TypeName = "varchar(50)")]
        public string Nombre { get; set; }


        [Required(ErrorMessage = "La categoria es obligatoria")]
        [Column(TypeName = "varchar(8)")]
        [Display(Name = "Desayuno")]
        [Categoria]
        public string Categoria { get; set; }

        [Required(ErrorMessage = "Los ingredientes son obligatorios")]
        [DataType(DataType.MultilineText)]
        [Column(TypeName = "varchar(150)")]
        public string Ingredientes { get; set; }

        [Required(ErrorMessage = "Las instrucciones son obligatorias")]
        [DataType(DataType.MultilineText)]
        [Column(TypeName = "varchar(500)")]
        public string Instrucciones { get; set; }
        [Required(ErrorMessage = "El autor es obligatorio")]
        [Column(TypeName = "varchar(40)")]
        public string Autor { get; set; }

        [Required(ErrorMessage = "El apellido es obligatorio")]
        [Column(TypeName = "varchar(40)")]
        public string Apellido { get; set; }

        [MayorDeEdad]
        public int Edad { get; set; }

        [Required(ErrorMessage = "El mail es obligatorio")]
        [Column(TypeName = "varchar(50)")]
        [RegularExpression("^[^@]+@[^@]+\\.[a-zA-Z]{2,}$")]
        public string Email { get; set; }
    }
}
