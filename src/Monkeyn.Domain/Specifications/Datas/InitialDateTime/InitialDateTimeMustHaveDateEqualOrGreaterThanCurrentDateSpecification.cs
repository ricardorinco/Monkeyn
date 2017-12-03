using DomainValidation.Interfaces.Specification;
using Monkeyn.Domain.Models;
using System;

namespace Monkeyn.Domain.Specifications.Datas.InitialDateTime
{
    public class InitialDateTimeMustHaveDateEqualOrGreaterThanCurrentDateSpecification : ISpecification<Data>
    {
        public bool IsSatisfiedBy(Data data)
        {
            return data?.InitialDateTime >= DateTime.Now.AddMinutes(-1);
        }
    }
}
