using System;
using System.Collections.Generic;
using System.Text;
using Template.Core.Entities;

namespace Template.Core.Interfaces
{
    public interface IUserRepository
    {
        void Insert(User user);
    }
}
