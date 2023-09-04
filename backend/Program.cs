using RecruitersDairy.Data.JobRepositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<IJobsCosmosContext, JobsCosmosContext>();
builder.Services.AddScoped<IJobRepository, JobRepository>(); 

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
