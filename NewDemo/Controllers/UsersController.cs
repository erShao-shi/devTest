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
    }
}
