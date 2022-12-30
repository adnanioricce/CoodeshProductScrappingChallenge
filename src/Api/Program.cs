using ProductScrapper;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
IApiDefinition[] apiDefs = new []
{
    new ProductEndpoints()
};
foreach (var apiDef in apiDefs) {
    apiDef.SetupServices(builder.Services);
}
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.MapGet("/", () => Results.Ok("Fullstack Challenge 20201026"));
foreach(var apiDef in apiDefs)
{
    apiDef.SetupEndpoints(app);
}
app.Run();