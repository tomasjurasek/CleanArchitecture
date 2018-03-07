using Autofac;
using System;
using System.Collections.Generic;
using System.Text;
using Template.Core.Interfaces;
using Template.Core.Repositories;
using Template.Core.UseCases.AddUserUseCase;
using Template.Core.UseCases.Interface;

namespace Template.Infrastructure.Installers
{
    public class CoreInstaller
    {

        public static void Install(ContainerBuilder builder)
        {
            builder.RegisterType<UserRepository>()
                .As<IUserRepository>()
                .InstancePerDependency();


            builder.RegisterType<IHandleUseCase<AddUserRequest, AddUserResponse>>()
               .As<AddUser>()
               .InstancePerDependency();

        }

        
    }
}
