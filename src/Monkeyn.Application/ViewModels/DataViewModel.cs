using System;

namespace Monkeyn.Application.ViewModels
{
    public class DataViewModel
    {
        public int NumberDiscs { get; set; }
        public DateTime InitialDateTime { get; set; }
        public DateTime? FinalDateTime { get; set; }

        public DomainValidation.Validation.ValidationResult ValidationResult { get; set; }
    }
}
