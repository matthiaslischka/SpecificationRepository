using System;
using System.Linq.Expressions;
using SpecificationRepository.Entities;

namespace SpecificationRepository.Repository.Specifications
{
    public class UserByUsernameSpecification : Specification<User>
    {
        private readonly string _username;

        public UserByUsernameSpecification(string username)
        {
            _username = username;
        }

        public override Expression<Func<User, bool>> Condition()
        {
            return u => u.Username == _username;
        }
    }
}