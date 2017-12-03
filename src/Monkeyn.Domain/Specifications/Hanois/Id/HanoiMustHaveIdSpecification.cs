using DomainValidation.Interfaces.Specification;
using Monkeyn.Domain.Models;

namespace Monkeyn.Domain.Specifications.Hanois.Id
{
    public class HanoiMustHaveIdSpecification : ISpecification<Hanoi>
    {
        public bool IsSatisfiedBy(Hanoi hanoi)
        {
            return !string.IsNullOrWhiteSpace(hanoi.Id.ToString());
        }
    }
}
