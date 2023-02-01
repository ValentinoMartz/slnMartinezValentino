using System;
using System.ComponentModel.DataAnnotations;

namespace SistemaWebMisRecetas.Validations
{
    public class MayorDeEdadAttribute : ValidationAttribute
    {
        public MayorDeEdadAttribute()
        {
            ErrorMessage = "El autor debe ser mayor de edad para ingresar una receta";
        }

        public override bool IsValid(object value)
        {
            if ((int)value > 18)
            {
                return true;
            }
            return false;
        }
    }
}
