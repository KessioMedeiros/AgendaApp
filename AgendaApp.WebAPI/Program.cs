using AgendaApp.WebAPI.Mappings;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddRouting(options => options.LowercaseUrls = true);

builder.Services.AddAutoMapper(typeof(ProfileMap));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Configuração para que o projeto Angular possa fazer requisições para a API
builder.Services.AddCors(
    config => config.AddPolicy("DefaultPolicy", builder =>
    {
        builder.WithOrigins("http://localhost:4200")
        .AllowAnyMethod()
        .AllowAnyHeader();
    })
);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.UseCors("DefaultPolicy");

app.MapControllers();

app.Run();
