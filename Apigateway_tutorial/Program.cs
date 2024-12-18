using Microsoft.AspNetCore.Authentication.Negotiate;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddReverseProxy()
    .LoadFromConfig(builder.Configuration.GetSection("ApiGateway"));

var app = builder.Build();
app.MapGet("/", () => "hêloo");


app.Run();


