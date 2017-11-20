using System;
using System.Linq.Expressions;

namespace SpecificationRepository.Repository.Specifications
{
    public abstract class Specification<T>: Expression
    {
        public abstract Expression<Func<T, bool>> Condition();
    }
}