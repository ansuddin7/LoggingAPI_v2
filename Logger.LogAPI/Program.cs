using Logger.Logic.Delegates;
using Logger.Logic.FileLogger;
using Logger.Logic.LogHandler;
using System.Reflection;
using ILogger = Logger.Logic.Logger.ILogger;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(setupAction =>
{
    var xmlCommentsFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlCommentsFullPath = Path.Combine(AppContext.BaseDirectory, xmlCommentsFile);

    setupAction.IncludeXmlComments(xmlCommentsFullPath);
});

builder.Services.AddScoped<ILogHandler,LogHandler>();
builder.Services.AddScoped<ILogger, FileLogger>();
builder.Services.AddScoped<ILogger, ConsoleLogger>();

builder.Services.AddScoped<LogEntryDelegate>(context =>
{
    var logger = context.GetServices<ILogger>().Aggregate(default(LogEntryDelegate), (a,b) => a + b.AddEntry);
    return logger;
});

builder.Services.AddScoped<LogEntriesDelegate>(context =>
{
    var logger = context.GetServices<ILogger>().Aggregate(default(LogEntriesDelegate), (a, b) => a + b.AddEntries);
    return logger;
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.Run();
