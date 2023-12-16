using toplantýserver.HUBS;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSignalR();
var app = builder.Build();

app.MapHub<genelislemlerhub>("genelhub");

app.Run();
