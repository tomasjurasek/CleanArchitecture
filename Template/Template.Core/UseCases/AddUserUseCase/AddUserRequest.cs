using System;
using System.Collections.Generic;
using System.Text;

namespace Template.Core.UseCases.AddUserUseCase
{
    public class AddUserRequest
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
