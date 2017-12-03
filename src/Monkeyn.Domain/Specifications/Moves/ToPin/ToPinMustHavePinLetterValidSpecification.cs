using DomainValidation.Interfaces.Specification;
using Monkeyn.Domain.Helpers;
using Monkeyn.Domain.Models;

namespace Monkeyn.Domain.Specifications.Moves.ToPin
{
    public class ToPinMustHavePinLetterValidSpecification : ISpecification<Move>
    {
        public bool IsSatisfiedBy(Move move)
        {
            foreach (var pinLetter in Constants.AcceptedPinLetters)
                if (move.ToPin == pinLetter)
                    return true;

            return false;
        }
    }
}
