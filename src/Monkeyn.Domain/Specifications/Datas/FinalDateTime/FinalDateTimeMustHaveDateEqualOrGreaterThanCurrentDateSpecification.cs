using DomainValidation.Interfaces.Specification;
using Monkeyn.Domain.Models;
using System;

namespace Monkeyn.Domain.Specifications.Datas.FinalDateTime
{
    public class FinalDateTimeMustHaveDateEqualOrGreaterThanCurrentDateSpecification : ISpecification<Data>
    {
        public bool IsSatisfiedBy(Data data)
        {
            return data?.FinalDateTime >= DateTime.Now.AddMinutes(-1);
        }
    }
}
