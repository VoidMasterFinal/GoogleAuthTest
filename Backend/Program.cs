var builder = WebApplication.CreateBuilder(args);

// Voeg services toe aan de container.
builder.Services.AddControllersWithViews();
builder.Services.AddSignalR();

// Configureer Swagger/OpenAPI
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configureer de HTTP-requestpipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();

// Map controllers
app.MapControllers();

app.Run();