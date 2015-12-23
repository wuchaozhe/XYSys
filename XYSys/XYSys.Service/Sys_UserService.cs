using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYSys.Service
{
    public class Sys_UserService
    {
        public object Login(Sys_User sys_User) 
        {
            return null;
        }
    }

    public class Sys_User 
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
    }
}
