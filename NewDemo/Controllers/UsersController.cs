using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NewDemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewDemo.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        public UsersController() { }
        [HttpGet]
        public UserInfo GetUser()
        {
            return new UserInfo()
            {
                UserAge = 20,
                UserName = "ershao",
                Gender = "男"
            };
        }
        [HttpGet]
        public List<UserInfo> GetUsers()
        {
            List<UserInfo> list = new List<UserInfo>();
            for(int i = 0; i < 2; i++)
            {
                UserInfo user = new UserInfo()
                {
                    UserAge = i,
                    UserName = "ershao",
                    Gender = "男    "
                };
                list.Add(user);
            }
            return list;
        }
    }
}
