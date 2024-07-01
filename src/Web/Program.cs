DotNetEnv.Env.Load();

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddPresentationLayer(builder.Environment, builder.Configuration);
builder.Services.AddApplicationLayer(builder.Environment, builder.Configuration);
builder.Services.AddInfrastructureLayer(builder.Environment, builder.Configuration);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{

}

app.MapGet("/", () => "Hello World!");

app.Run();
