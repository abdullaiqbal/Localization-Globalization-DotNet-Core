using System.Globalization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Localization
builder.Services.AddLocalization();
var localizationOptions = new RequestLocalizationOptions();
List<CultureInfo> supportedCultures = new List<CultureInfo>
{
    new CultureInfo("en"),
    new CultureInfo("de"),
    new CultureInfo("fr"),
    new CultureInfo("es"),
    new CultureInfo("en-GB")
};

//var suportCultures = new[]
//{
//    "en-US",
//    "es-ES"
//};

localizationOptions.SupportedCultures = supportedCultures;
localizationOptions.SupportedUICultures = supportedCultures;
localizationOptions.SetDefaultCulture("en-US");
localizationOptions.ApplyCurrentCultureToResponseHeaders = true;


var app = builder.Build();
//Localization
app.UseRequestLocalization(localizationOptions);

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
