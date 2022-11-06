using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.Bussines.Models.Validations
{
    public class EspecialidadeValidation : AbstractValidator<Especialidade>
    {
        public EspecialidadeValidation()
        {
           /* RuleFor(c => c.Nome)
              .NotEmpty().WithMessage("O campo {PropertyName} precisa de uma Especialidade")
              .Length(2, 200).WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");
           */
        }
    }
}
