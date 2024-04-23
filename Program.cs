using VueBase;
using VueBase.Data;
using VueBase.Data.SeedDatabase;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

//Enable CORS
app.UseCors(x => x
    .AllowAnyOrigin()
	.AllowAnyMethod()
	.AllowAnyHeader());

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

using var context = new PCContext();

// check if the database exists
if (context.Database.CanConnect())
{
    context.Database.EnsureDeleted(); // if the database exists deletes it
}
context.Database.EnsureCreated(); // if the database dosnt exist creates it

app.SeedSSD(context);
app.SeedCase(context);
app.SeedMotherboard(context);
app.SeedCPU(context);
app.SeedGPU(context);
app.SeedPSU(context);
app.SeedRAM(context);
app.SeedHDD(context);
app.SeedCaseCooler(context);
app.SeedCPUCooler(context);

app.Run();
