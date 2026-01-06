using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MyAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SayHelloController : ControllerBase
    {
        [HttpGet]
        [Route("{username}")]
        public string SayHello(string username)
        {
            return $"Hello, {username}.";
        }
    }
}
