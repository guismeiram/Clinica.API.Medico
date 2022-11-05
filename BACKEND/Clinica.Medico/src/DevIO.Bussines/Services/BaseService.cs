using DevIO.Bussines.Interface;
using DevIO.Bussines.Models;
using DevIO.Bussines.Notificacoes;
using FluentValidation;
using FluentValidation.Results;

namespace DevIO.Bussines.Services
{
    public abstract class BaseService
    {
        private readonly INotificador _notificador;

        protected BaseService(INotificador notificador)
        {
            _notificador = notificador;
        }

        protected void Notificar(ValidationResult validationResult)
        {
            foreach (var error in validationResult.Errors)
            {
                Notificar(error.ErrorMessage);
            }
        }

        protected void Notificar(string mensagem)
        {
            _notificador.Handle(new Notificacao(mensagem));
        }

        protected bool ExecutarValidacao<TV, TE>(TV validacao, TE entidade) where TV : AbstractValidator<TE> where TE : Entity
        {
            var validator = validacao.Validate(entidade);

            if (validator.IsValid) return true;

            Notificar(validator);

            return false;
        }


        /*protected bool ValidateEntity<TV, TE>(TV validacao, TE entidade) where TV : AbstractValidator<TE> where TE : Entity
        {
            //do the base DataAnnotations/fluent validation mapping
            var result = base.ValidateEntity(entityEntry, items);

            //do additional validation for customer
            var customer = entityEntry.Entity as Customer;

            //could be added or updated (change ShouldValidateEntity to include deleted)
            if (entityEntry.State == EntityState.Added &&
                customer != null)
            {
                if (customer.FirstName.Contains("\t"))
                {
                    result.ValidationErrors.Add(
                        new DbValidationError("LastName", "Illegal character"));
                }
            }
            return result;
        }*/
    }
}
