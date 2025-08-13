using CompanyManagement.API.Configurations;
using CompanyManagement.API.Endpoints;
using CompanyManagement.API.Middleware;
using CompanyManagement.Infrastructure.DependencyInjection;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddOpenApi();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerDocumentation();
builder.Services.AddInfrastructure(builder.Configuration);
var app = builder.Build();

app.UseSwagger();
app.UseSwaggerDocumentation();


if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}
app.MapCompanyEndpoints();

app.UseHttpsRedirection();
app.Run();