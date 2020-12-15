using System.ComponentModel.DataAnnotations;
using System.Windows;
using System.Linq;
using System.Collections.Generic;

namespace OnlineStudy
{
    public static class ObjectExtension
    {
        public static bool IsValid(this object obj)
        {
            var result = new List<ValidationResult>();
            var context = new ValidationContext(obj);

            if (!Validator.TryValidateObject(obj, context, result, true))
            {
                MessageBox.Show(string.Join("\n", result.Select(s => s.ErrorMessage)), "Validation error", MessageBoxButton.OK, MessageBoxImage.Error);

                return true;
            }

            return false;
        }
    }
}
