

using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

string policy = "customPolicy";

//builder.Services.AddCors(opt => opt.AddPolicy(policy, opt =>
//{
//    opt
//    .AllowAnyOrigin()
//    .AllowAnyMethod()
//    .AllowAnyHeader()
//    .AllowCredentials();
//}));

builder.Services.AddDbContext<ApuntesDominoAPI.Models.apuntesdominodbContext>(opt => opt.UseSqlServer("Data Source=apuntesdominoserver.database.windows.net;Initial Catalog=apuntesdominodb; User Id=cristhianrolandoquezada; Password=Crq55803422109999; Integrated Security=False"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors(policy);
app.UseAuthorization();

app.MapControllers();

app.Run();
