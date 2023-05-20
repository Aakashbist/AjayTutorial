using AjayTutoral.Model;
using AjayTutoral.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddHttpClient();//HttpClient client=new HttpClient();


builder.Services.AddTransient<IChallengeService, ChallengeService>();

builder.Services.Configure<ApiSetting>(builder.Configuration.GetSection("Api"));
// IChallengeService service=new ChallengeService();
//builder.Services.AddTransient<IChallengeService, NewChallengeService>(); IChallengeService service=new NewChallengeService();  

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

//Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();