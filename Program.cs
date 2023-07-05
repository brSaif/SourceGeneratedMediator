using MediatorSGSample;
using MediatorSGSample.Requests;


// Source Generated Mediator Sample app, credit to Nick Chapsas.
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMediator(opt => opt.ServiceLifetime = ServiceLifetime.Scoped);

var app = builder.Build();

app.MediatorGet<ExampleRequest>("api/{name}");
app.MediatorPost<ExampleRequest>("api/name");

app.Run();