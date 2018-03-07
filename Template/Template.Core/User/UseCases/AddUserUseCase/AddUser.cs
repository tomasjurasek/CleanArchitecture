using Template.Core.UseCases.Common;

namespace Template.Core.User.UseCases.AddUserUseCase
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
            try
            {
                var user = Entities.User.Create(request.Name, request.Age);
                userRepository.Insert(user);

                return new AddUserResponse
                {
                    UserId = user.Id
                };
            }
            catch (System.Exception)
            {
                throw;
            }
           
        }
    }
}
