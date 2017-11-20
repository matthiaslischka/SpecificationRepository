using System.Collections.Generic;
using SpecificationRepository.Entities;
using SpecificationRepository.Queries;
using SpecificationRepository.Repository;
using SpecificationRepository.Repository.Specifications;

namespace SpecificationRepository.QueryHandler
{
    public class GetUserByUsernameQueryHandler
    {
        private readonly Repository<User> _userRepository;

        public GetUserByUsernameQueryHandler(Repository<User> userRepository)
        {
            _userRepository = userRepository;
        }

        public List<User> Handle(GetUserByUsernameQuery query)
        {
            return _userRepository.Get(new UserByUsernameSpecification(query.Username));
        }
    }
}