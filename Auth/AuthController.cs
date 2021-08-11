using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace techlink.Auth
{
    [ApiController]
    [Route("auth")]
    public class AuthController
    {
        [HttpPost("login")]
        public async Task<ActionResult> login()
        {

        }
    }
}