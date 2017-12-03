using System;
using System.Collections.Generic;

namespace Monkeyn.Application.ViewModels
{
    public class HanoiViewModel
    {
        public Guid Id { get; set; }
        public string Status { get; set; }

        public DataViewModel Data { get; set; }
        public List<MoveViewModel> Moves { get; set; }

        public DomainValidation.Validation.ValidationResult ValidationResult { get; set; }
    }
}
