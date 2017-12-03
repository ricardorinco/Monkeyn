using DomainValidation.Validation;
using Monkeyn.Domain.Helpers;
using Monkeyn.Domain.Models;
using Monkeyn.Domain.Specifications.Moves.FromPin;
using Monkeyn.Domain.Specifications.Moves.ToPin;

namespace Monkeyn.Domain.Validations.Moves
{
    public class MoveIsConsistentValidation : Validator<Move>
    {
        public MoveIsConsistentValidation()
        {
            #region FromPin
            var fromPinMustHavePinLetterSpecification = new FromPinMustHavePinLetterSpecification();
            Add("fromPinMustHavePinLetterSpecification", new Rule<Move>(fromPinMustHavePinLetterSpecification, ErrorMessages.PinMustHavePinLetterErrorMessage));

            var fromPinMustHavePinLetterValidSpecification = new FromPinMustHavePinLetterValidSpecification();
            Add("fromPinMustHavePinLetterValidSpecification", new Rule<Move>(fromPinMustHavePinLetterValidSpecification, ErrorMessages.PinMustHavePinLetterValidErrorMessage));
            #endregion

            #region ToPin
            var toPinMustHavePinLetterSpecification = new ToPinMustHavePinLetterSpecification();
            Add("toPinMustHavePinLetterSpecification", new Rule<Move>(toPinMustHavePinLetterSpecification, ErrorMessages.PinMustHavePinLetterErrorMessage));

            var toPinMustHavePinLetterValidSpecification = new ToPinMustHavePinLetterValidSpecification();
            Add("toPinMustHavePinLetterValidSpecification", new Rule<Move>(toPinMustHavePinLetterValidSpecification, ErrorMessages.PinMustHavePinLetterValidErrorMessage));
            #endregion
        }
    }
}
