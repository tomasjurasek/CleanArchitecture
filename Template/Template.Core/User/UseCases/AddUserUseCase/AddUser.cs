using Microsoft.Extensions.Logging;
using System;
using Template.Core.UseCases.Common;

namespace Template.Core.User.UseCases.AddUserUseCase
{
    public class AddUser : IHandleUseCase<AddUserRequest, AddUserResponse>
    {
        private readonly IUserRepository userRepository;
        private readonly ILogger logger;

        public AddUser(IUserRepository userRepository, ILogger logger)
        {
            this.userRepository = userRepository;
            this.logger = logger;
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
            catch (ArgumentException ex)
            {
                logger.LogWarning($"ArgumentException - {ex.Message}");
                throw;
            }
            catch(Exception ex)
            {
                logger.LogError(ex.Message);
                throw;
            }
           
        }
    }
}
