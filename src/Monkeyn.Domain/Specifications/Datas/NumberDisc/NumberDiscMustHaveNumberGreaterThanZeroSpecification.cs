using DomainValidation.Interfaces.Specification;
using Monkeyn.Domain.Models;

namespace Monkeyn.Domain.Specifications.Datas.NumberDisc
{
    public class NumberDiscMustHaveNumberGreaterThanZeroSpecification : ISpecification<Data>
    {
        public bool IsSatisfiedBy(Data data)
        {
            return data?.NumberDiscs > 0;
        }
    }
}
