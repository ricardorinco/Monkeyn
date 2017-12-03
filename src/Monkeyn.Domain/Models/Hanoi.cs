using DomainValidation.Validation;
using Monkeyn.Domain.Validations.Hanois;
using System;
using System.Collections.Generic;

namespace Monkeyn.Domain.Models
{
    public class Hanoi
    {
        public Hanoi()
        {
            Id = Guid.NewGuid();
            Moves = new List<Move>();
        }

        public Guid Id { get; set; }
        public string Status { get; set; }

        public Data Data { get; set; }
        public List<Move> Moves { get; set; }

        public ValidationResult ValidationResult { get; set; }

        public bool IsValid()
        {
            ValidationResult = new HanoiIsConsistentValidation().Validate(this);

            return ValidationResult.IsValid;
        }
    }
}
