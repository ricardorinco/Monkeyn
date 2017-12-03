using DomainValidation.Validation;
using Monkeyn.Domain.Helpers;
using Monkeyn.Domain.Models;
using Monkeyn.Domain.Specifications.Hanois.Id;
using Monkeyn.Domain.Specifications.Hanois.Status;

namespace Monkeyn.Domain.Validations.Hanois
{
    public class HanoiIsConsistentValidation : Validator<Hanoi>
    {
        public HanoiIsConsistentValidation()
        {
            #region Id
            var hanoiMustHaveIdSpecification = new HanoiMustHaveIdSpecification();
            Add("hanoiMustHaveIdSpecification", new Rule<Hanoi>(hanoiMustHaveIdSpecification, ErrorMessages.HanoiMustHaveIdErrorMessage));
            #endregion

            #region Status
            var hanoiMustHaveStatusSpecification = new HanoiMustHaveStatusSpecification();
            Add("hanoiMustHaveStatusSpecification", new Rule<Hanoi>(hanoiMustHaveStatusSpecification, ErrorMessages.HanoiMustHaveStatusErrorMessage));
            #endregion
        }
    }
}