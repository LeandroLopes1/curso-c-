using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Apiauth.Models;
using Apiauth.Repositories;
using ServiceStack.Redis;
using ApiAuth.Services;
using Apiauth.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var connectionStringSQLServer = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<AppDataContext>(opt => opt.UseSqlServer(connectionStringSQLServer));


builder.Services.AddControllersWithViews();

var key = Encoding.ASCII.GetBytes("fedaf7d8863b48e197b9287d492b708e");

builder.Services.AddAuthentication( options => {
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
    .AddJwtBearer( options => {
    options.RequireHttpsMetadata = false;
    options.SaveToken = true;
    options.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
    {
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(key),
        ValidateIssuer = false,
        ValidateAudience = false
    };
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

// app.MapGet("ready/", () => new  {messagem  = "API foi iniciada", status = "OK"});

app.Run();



/* var host = "localhost:6379";
var redis = new RedisClient(host);
var redisManager = new RedisManagerPool(host);

var redisClient = redisManager.GetClient();

var user = new User
{
    Id = 1,
    Username = "batman",
    Password = "batman",
    Role = "manager"
};


redisClient.Set("user", user, TimeSpan.FromMinutes(1));

var userRedis = redisClient.Get<User>("user");

var tokenRedis = redisClient.Get<string>("token");

var token = TokenService.GenerateToken(user);

redisClient.Set<string>("token", token, TimeSpan.FromMinutes(1)); */
