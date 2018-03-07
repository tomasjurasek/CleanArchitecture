using System;
using System.Collections.Generic;
using System.Text;

namespace Template.Infrastructure.UseCases.AddUserUseCase
{
    public class AddUserRequest
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
