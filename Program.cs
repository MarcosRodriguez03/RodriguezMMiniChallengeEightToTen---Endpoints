
using RodriguezMMiniChallengeEightToTen___Endpoints.GuessIt;
using RodriguezMMiniChallengeEightToTen___Endpoints.Services.Magic8Ball;
using RodriguezMMiniChallengeEightToTen___Endpoints.Services.RestaurantPicker;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IMagic8Ball, Magic8BallService>();
builder.Services.AddScoped<IRestaurantPicker, RestaurantPickerService>();
builder.Services.AddScoped<IGuessIt, GuessItService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
