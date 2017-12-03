using DomainValidation.Interfaces.Specification;
using Monkeyn.Domain.Models;
using System;

namespace Monkeyn.Domain.Specifications.Datas.InitialDateTime
{
    public class InitialDateTimeMustHaveDateSpecification : ISpecification<Data>
    {
        public bool IsSatisfiedBy(Data data)
        {
            return data?.InitialDateTime != new DateTime(0001, 01, 01);
        }
    }
}
