using CalculateBitrates.Api.ServiceInterfaces;
using CalculateBitrates.BusinessLayer;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//register services
builder.Services.AddSingleton<IBitrateCalculator, BitrateCalculatorService>();
builder.Services.AddSingleton<INICService, NICService>();
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "CalculateBit");
});
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseRouting();

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.Run();
