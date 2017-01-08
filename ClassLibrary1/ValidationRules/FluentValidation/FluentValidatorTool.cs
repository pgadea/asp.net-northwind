using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace ClassLibrary1.ValidationRules.FluentValidation
{
    public class FluentValidatorTool
    {
        public static void Validate(IValidator validator, object entity)
        {
            var result = validator.Validate(entity);
            throw new ValidationException(result.Errors);
        }
    }
}
