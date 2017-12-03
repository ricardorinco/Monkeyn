using DomainValidation.Validation;
using Monkeyn.Domain.Validations.Moves;

namespace Monkeyn.Domain.Models
{
    public class Move
    {
        public char FromPin { get; set; }
        public char ToPin { get; set; }

        public ValidationResult ValidationResult { get; set; }

        public bool IsValid()
        {
            ValidationResult = new MoveIsConsistentValidation().Validate(this);

            return ValidationResult.IsValid;
        }
    }
}
