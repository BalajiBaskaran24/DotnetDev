WebApplicationBuilder builder = WebApplication.CreateBuilder(args);//IConfiguration will be configured here


// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();//Needs Swashbuckle.AspNetCore nuget package

WebApplication app = builder.Build();//app : WebApplication

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

//Packages for authentication and authorization
//Microsoft.AspNetCore.Authentication.JwtBearer
//Microsoft.IdentityModel.Tokens
//Microsoft.IdentityModel.Tokens.Jwt

app.UseAuthorization();

app.MapControllers();

app.Run();
