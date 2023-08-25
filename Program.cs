using GraphQL;
using GraphQL.Types;

using graphql_server.Data;
using graphql_server.Graphql;

using Microsoft.AspNetCore.Authentication;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSingleton<IDataService, DataService>();
builder.Services.AddSingleton<MyQuery>();
builder.Services.AddSingleton<ISchema, MySchema>();
builder.Services.AddGraphQL(b => b
    .AddSystemTextJson()
);
builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
}

app.UseAuthorization();

app.MapControllers();

app.UseGraphQL();

app.UseGraphQLAltair();

app.Run();
