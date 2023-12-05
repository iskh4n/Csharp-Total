using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.Utilities
{
   public static class ValidationTool
    {
        public static void Validate(IValidator validator, object entity)
        {
            //Fluent kurallarını çağırıyoruz.


            // ProductValidator productValidator = new ProductValidator();
            // var result = validator.Validate(entity); eski kullanım 
            var context = new ValidationContext<object>(entity);
            var result = validator.Validate(context);

            if (result.Errors.Count > 0)
            {
                throw new ValidationException(result.Errors);//fluent validation
            }

        }


    }
}
