using DomainValidation.Interfaces.Specification;
using Monkeyn.Domain.Models;

namespace Monkeyn.Domain.Specifications.Hanois.Status
{
    class HanoiMustHaveStatusSpecification : ISpecification<Hanoi>
    {
        public bool IsSatisfiedBy(Hanoi hanoi)
        {
            return !string.IsNullOrWhiteSpace(hanoi.Status);
        }
    }
}
