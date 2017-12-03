using DomainValidation.Interfaces.Specification;
using Monkeyn.Domain.Models;

namespace Monkeyn.Domain.Specifications.Moves.ToPin
{
    public class ToPinMustHavePinLetterSpecification : ISpecification<Move>
    {
        public bool IsSatisfiedBy(Move move)
        {
            return char.IsLetter(move.ToPin);
        }
    }
}
