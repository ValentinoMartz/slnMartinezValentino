using System.ComponentModel.DataAnnotations;

namespace SistemaWebMisRecetas.Validations
{
    public class CategoriaAttribute : ValidationAttribute
    {
        public CategoriaAttribute()
        {
            ErrorMessage = "La categoria ingresada debe ser desayuno";
        }

        public override bool IsValid(object value)
        {
            if (value.ToString() != "desayuno" && value.ToString() != "Desayuno") {
                return false;
            }
            return true;
        }
    }
}
