namespace Monkeyn.Application.ViewModels
{
    public class MoveViewModel
    {
        public char FromPin { get; set; }
        public char ToPin { get; set; }

        public DomainValidation.Validation.ValidationResult ValidationResult { get; set; }
    }
}
