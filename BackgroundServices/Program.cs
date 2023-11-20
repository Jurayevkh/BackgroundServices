using BackgroundServices;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHostedService<HostedLIfeCycleServiceDemo>();
builder.Services.AddHostedService<HostedServiceDemo>();
//builder.Services.AddHostedService<BackgroundServiceDemo>();


builder.Services.Configure<HostOptions>(options =>
{
    options.StartupTimeout = TimeSpan.FromMinutes(1);
    options.ShutdownTimeout = TimeSpan.FromMinutes(1);
    options.ServicesStartConcurrently = true;
    options.ServicesStopConcurrently = false;
});

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();

