using MinimalApiEndpoints;
using RegisterServices;

var builder = WebApplication.CreateBuilder(args);
{
    var service = builder.Services;
    var configuration = builder.Configuration;


    service.AddEndpointsApiExplorer();

    service.AddServices(configuration);
}
var app = builder.Build();
{
    app.UseSwagger();
    app.UseSwaggerUI();

    app.UseHttpsRedirection();

    app.UseEndpoints();

    app.Run();
}
