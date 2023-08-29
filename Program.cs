using FiapStoreMinimalAPI.Entities;
using FiapStoreMinimalAPI.Interface;
using FiapStoreMinimalAPI.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<IUserRepository, UserRepository>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Endpoint GET
app.MapGet("/get-all-users", (IUserRepository userRepository) =>
{
    return userRepository.GetAllUsers();

});
// Endpoint GET

app.MapGet("/get-user/{id}", (int id ,IUserRepository userRepository) =>
{
    return userRepository.GetUserById(id);

});

// Endpoint POST

app.MapPost("/user", (User user, IUserRepository userRepository) =>
{
     userRepository.AddUser(user);

});

// Endpoint PUT

app.MapPut("/user", (User user, IUserRepository userRepository) =>
{
    userRepository.UpdateUser(user);

});

// Endpoint Delete

app.MapDelete("/user/{id}", (int id, IUserRepository userRepository) =>
{
    userRepository.DeleteUser(id);

});


app.Run();


