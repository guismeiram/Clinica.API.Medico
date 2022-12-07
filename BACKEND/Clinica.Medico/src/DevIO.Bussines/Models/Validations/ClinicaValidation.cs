using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.Bussines.Models.Validations
{
    public class ClinicaValidation : AbstractValidator<Clinica>
    {
        public ClinicaValidation()
        {
            RuleFor(c => c.NomeClinica)
              .NotEmpty().WithMessage("O campo {PropertyName} precisa de um Nome")
              .Length(2, 200).WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");


        }
    }
}
