using AspNetBrokenResponse;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddSingleton<UserRepository>();

var app = builder.Build();
app.UseDeveloperExceptionPage();

app.UseAuthorization();
app.MapControllers();

app.Run();