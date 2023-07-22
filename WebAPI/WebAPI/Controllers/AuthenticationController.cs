using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuthenticationController : ControllerBase
{
    public record AuthenticationData(string? UserName, string? Password);

    //api/Authentication/token
    //[HttpPost("token")]
    //public ActionResult<string> Authenticate([FromBody] AuthenticationData data)
    //{
    //
    //}

    //private user ValidateCredentials(AuthenticationData data)
    //{
    //    //This is only for demo - Do not use in real implementation
    //    if (CompareValues(data.UserName, "balaji") &&
    //            CompareValues(data.Password, "sam"))
    //    {

    //    }
    //}

    private bool CompareValues(string? actual, string? expected)
    {
        if (actual is not null)
        {
            if (actual.Equals(expected, StringComparison.InvariantCultureIgnoreCase))
                return true;
        }
        return false;
    }
}
