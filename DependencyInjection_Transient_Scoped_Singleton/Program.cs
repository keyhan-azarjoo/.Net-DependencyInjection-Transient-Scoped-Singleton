using DependencyInjection_Transient_Scoped_Singleton.Interfaces;
using DependencyInjection_Transient_Scoped_Singleton.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



//  you register your dependencies here
builder.Services.AddSingleton<ISingleton, AmazingService>();    // App Life Time
builder.Services.AddScoped<IScoped, AmazingService>();          // Request Life Time
builder.Services.AddTransient<ITransient, AmazingService>();    // Each instanse create a new object








var app = builder.Build();


// This is another way to create an endpoint but we create a controller in controller folder
// It do the same thing as otherone.
//app.MapGet("/getGuids",
//    (ISingleton singletonService, IScoped scopedService1, IScoped scopedService2, ITransient TransientService1,
//        ITransient TransientService2) =>
//    {
//        return new
//        {
//            singletonServise = singletonService.Value(),
//            scopedService1 = scopedService1.Value(),
//            scopedService2 = scopedService2.Value(),
//            transientService1 = TransientService1.Value(),
//            transientService2 = TransientService2.Value(),

//        };
//    });

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
