using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

using techlink.Persons;

namespace techlink.Auth
{
    [ApiController]
    [Route("auth")]
    public class AuthController : Controller
    {
        [HttpPost("login")]
        public JsonResult login()
        {
            return Json(new JsonResponse<PersonResource>("LOGIN-200", "User has been logged in successfully."));
        }

        [HttpPost("register")]
        public JsonResult register()
        {
            return Json(new JsonResponse<PersonResource>("REGISTER-201", "User has been registerd successfully."));
        }
    }
}