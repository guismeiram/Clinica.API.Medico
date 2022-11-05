using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.Bussines.Models.Validations
{
    public class ConvenioValidation : AbstractValidator<Convenio>
    {
        public ConvenioValidation()
        {
           RuleFor(c => c.Nome)
               .NotEmpty().WithMessage("O campo {PropertyName} precisa de Nome")
               .Length(2, 200).WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");

            RuleFor(c => c.NCarteira)
               .NotEmpty().WithMessage("O campo {PropertyName} precisado Numero da Carteira")
               .Length(2, 200).WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");

            RuleFor(person => person.Vencimento).NotEmpty().WithMessage("O campo {PropertyName} precisa de uma Data");
        }

        /*public String Nome { get; set; }
        public String NCarteira { get; set; }
        public DateTime Vencimento { get; set; }*/
    }
}
