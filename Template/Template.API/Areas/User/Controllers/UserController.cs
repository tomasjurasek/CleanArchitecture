using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Template.Core.UseCases.Common;
using Template.Core.User.UseCases.AddUserUseCase;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Template.API.Areas.User.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly IHandleUseCase<AddUserRequest, AddUserResponse> addUserUseCase;

        public UserController(IHandleUseCase<AddUserRequest, AddUserResponse> addUserUseCase)
        {
            this.addUserUseCase = addUserUseCase;
        }


        [HttpPost]
        public IActionResult CreateUser(AddUserRequest request)
        {
            var response = addUserUseCase.Handle(request);
            return Ok(response);
        }
       

        
    }
}
