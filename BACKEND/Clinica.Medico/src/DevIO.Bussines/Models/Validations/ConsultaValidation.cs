using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.Bussines.Models.Validations
{
    public class ConsultaValidation : AbstractValidator<Consulta>
    {
        public ConsultaValidation()
        {/*
            RuleFor(f => f.Data)
                .NotEmpty().WithMessage("Data required");
            */
        }
    }
}
