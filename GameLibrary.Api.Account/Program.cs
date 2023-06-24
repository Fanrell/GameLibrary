using GameLibrary.Api.Common;

var builder = WebApplication.CreateBuilder(args);

var app = SetupHelper.SetupApplication(builder);

app = SetupHelper.SetupBaseServices(app);

app.Run();
