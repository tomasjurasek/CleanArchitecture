using System;
using System.Collections.Generic;
using System.Text;
using Template.Core.Entities;
using Template.Core.Interfaces;

namespace Template.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        public void Insert(User user)
        {
            //SAVE TO DB.
            //USER IS NOT YOUR DB ENTITY IT IS YOUR DOMAIL MODEL
        }



        public class UserRecord
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
        }
    }
}
