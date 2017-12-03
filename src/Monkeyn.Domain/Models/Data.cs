using DomainValidation.Validation;
using Monkeyn.Domain.Validations.Datas;
using System;

namespace Monkeyn.Domain.Models
{
    public class Data
    {
        public int NumberDiscs { get; set; }
        public DateTime InitialDateTime { get; set; }
        public DateTime? FinalDateTime { get; set; }

        public ValidationResult ValidationResult { get; set; }

        public bool IsValid()
        {
            ValidationResult = new DataIsConsistentValidation().Validate(this);

            return ValidationResult.IsValid;
        }
    }
}
