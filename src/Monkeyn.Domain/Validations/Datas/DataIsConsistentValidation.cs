using DomainValidation.Validation;
using Monkeyn.Domain.Helpers;
using Monkeyn.Domain.Models;
using Monkeyn.Domain.Specifications.Datas.FinalDateTime;
using Monkeyn.Domain.Specifications.Datas.InitialDateTime;
using Monkeyn.Domain.Specifications.Datas.NumberDisc;

namespace Monkeyn.Domain.Validations.Datas
{
    public class DataIsConsistentValidation : Validator<Data>
    {
        public DataIsConsistentValidation()
        {
            #region NumberDiscs
            var numberDiscMustHaveNumberGreaterThanZeroSpecification = new NumberDiscMustHaveNumberGreaterThanZeroSpecification();
            Add("numberDiscMustHaveNumberGreaterThanZeroSpecification", new Rule<Data>(numberDiscMustHaveNumberGreaterThanZeroSpecification, ErrorMessages.NumberDiscMustHaveNumberGreaterThanZeroErrorMessage));
            #endregion

            #region InitalDateTime
            var initialDateTimeMustHaveDateEqualOrGreaterThanCurrentDateSpecification = new InitialDateTimeMustHaveDateEqualOrGreaterThanCurrentDateSpecification();
            Add("initialDateTimeMustHaveDateEqualOrGreaterThanCurrentDateSpecification", new Rule<Data>(initialDateTimeMustHaveDateEqualOrGreaterThanCurrentDateSpecification, ErrorMessages.InitialDateTimeMustHaveDateEqualOrGreaterThanCurrentDateErrorMessage));

            var initialDateTimeMustHaveDateSpecification = new InitialDateTimeMustHaveDateSpecification();
            Add("initialDateTimeMustHaveDateSpecification", new Rule<Data>(initialDateTimeMustHaveDateSpecification, ErrorMessages.InitialDateTimeMustHaveDateErrorMessage));
            #endregion

            #region FinalDateTime
            var finalDateTimeMustHaveDateEqualOrGreaterThanCurrentDateSpecification = new FinalDateTimeMustHaveDateEqualOrGreaterThanCurrentDateSpecification();
            Add("finalDateTimeMustHaveDateEqualOrGreaterThanCurrentDateSpecification", new Rule<Data>(finalDateTimeMustHaveDateEqualOrGreaterThanCurrentDateSpecification, ErrorMessages.FinalDateTimeMustHaveDateEqualOrGreaterThanCurrentDateErrorMessage));
            #endregion
        }
    }
}
