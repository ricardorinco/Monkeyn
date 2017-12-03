using DomainValidation.Interfaces.Specification;
using Monkeyn.Domain.Models;

namespace Monkeyn.Domain.Specifications.Moves.FromPin
{
    public class FromPinMustHavePinLetterSpecification : ISpecification<Move>
    {
        public bool IsSatisfiedBy(Move move)
        {
            return char.IsLetter(move.FromPin);
        }
    }
}
