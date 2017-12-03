using DomainValidation.Interfaces.Specification;
using Monkeyn.Domain.Helpers;
using Monkeyn.Domain.Models;

namespace Monkeyn.Domain.Specifications.Moves.FromPin
{
    public class FromPinMustHavePinLetterValidSpecification : ISpecification<Move>
    {
        public bool IsSatisfiedBy(Move move)
        {
            foreach (var pinLetter in Constants.AcceptedPinLetters)
                if (move.FromPin == pinLetter)
                    return true;

            return false;
        }
    }
}
