using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using lab_2_web_design.Models;

namespace lab_2_web_design.Services
{
    public class UserService : IUser
    {
        public bool UserhasYarn(User user)
        {
            //if users.Yarns is not equal to null AND blah balh
            return user.Yarns?.Count > 0;
        }
    }
}