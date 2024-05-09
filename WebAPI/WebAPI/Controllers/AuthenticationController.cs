using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using System.Text;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuthenticationController : ControllerBase
{
    //private readonly IConfiguration config;

    //public record AuthenticationData(string? UserName, string? Password);
    //public record UserData(int UserId, string? UserName);

    //public AuthenticationController(IConfiguration config)
    //{
    //    this.config = config;
    //}


    ////api/Authentication/token
    ////[HttpPost("token")]
    //public ActionResult<string> Authenticate([FromBody] AuthenticationData data)
    //{
    //    var User = ValidateCredentials(data);
    //    if (User is null)
    //    {
    //        return Unauthorized();
    //    }
    //    else
    //    {
    //        return "";
    //    }
    //}

    //private string GenerateToken(UserData data)
    //{
    //    //Fetch data from secrets/appsettings.json, convert to byte[] and create symmetric security key
    //    //SymmetricSecurityKey:  
    //    var SecretKey = new SymmetricSecurityKey(
    //        Encoding.ASCII.GetBytes(
    //      config.GetValue<string>("Authentication:SecretKey")));

    //    var signingCredentials = new SigningCredentials(SecretKey, SecurityAlgorithms.HmacSha256);

    //    //Claims - data points
    //    List<Claim> claims = new List<Claim>();

    //    return "";

    //}



    //private UserData ValidateCredentials(AuthenticationData data)
    //{
    //    //This is only for demo - Do not use in real implementation
    //    //In real world this will be replaced with some other authentication system. Like OAuth or azure active directory
    //    if (CompareValues(data.UserName, "balaji") &&
    //            CompareValues(data.Password, "sam"))
    //    {
    //        return new UserData(1, data.UserName);
    //    }
    //    else if (CompareValues(data.UserName, "newuser") &&
    //            CompareValues(data.Password, "newus"))
    //    {
    //        return new UserData(1, data.UserName);
    //    }
    //    else
    //    {
    //        return null;
    //    }
    //}

    //private bool CompareValues(string? actual, string? expected)
    //{
    //    if (actual is not null)
    //    {
    //        if (actual.Equals(expected, StringComparison.InvariantCultureIgnoreCase))
    //            return true;
    //    }
    //    return false;
    //}
}
