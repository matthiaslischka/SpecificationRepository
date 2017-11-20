using System.Collections.Generic;
using System.Linq;
using SpecificationRepository.Entities;
using SpecificationRepository.Repository.Specifications;

namespace SpecificationRepository.Repository
{
    public class Repository<T> where T : Entity
    {
        private IQueryable<T> _queryable;

        public List<T> Get(Specification<T> specification)
        {
            return _queryable.Where(specification.Condition()).ToList();
        }
    }
}