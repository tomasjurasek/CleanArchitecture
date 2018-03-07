using Template.Core.Data.Entities;
using Template.Core.Interfaces;
using Template.Core.UseCases.Interface;

namespace Template.Core.UseCases.AddUserUseCase
{
    public class AddUser : IHandleUseCase<AddUserRequest, AddUserResponse>
    {
        private readonly IUserRepository userRepository;

        public AddUser(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }
        public AddUserResponse Handle(AddUserRequest request)
        {
            //TODO VALIDATION

            var user = User.Create(request.Name, request.Age);
            userRepository.Insert(user);

            return new AddUserResponse
            {
                UserId = user.Id
            };
        }
    }
}
