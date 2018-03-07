using Autofac;
using Template.Core.UseCases;
using Template.Core.UseCases.Common;
using Template.Core.User;
using Template.Core.User.UseCases.AddUserUseCase;

namespace Template.Infrastructure.Installers
{
    public class CoreInstaller
    {

        public static void Install(ContainerBuilder builder)
        {
            builder.RegisterType<UserRepository>()
                .As<IUserRepository>()
                .InstancePerDependency();


            builder.RegisterType<AddUser>()
               .As<IHandleUseCase<AddUserRequest, AddUserResponse>>()
               .InstancePerDependency();

        }

        
    }
}
