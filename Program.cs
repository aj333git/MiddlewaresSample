//Minimal API
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//example of an Middleware
app.Use(async (context, next) =>{
    await context.Response.WriteAsync("^^^^^^");
    await next();
    await context.Response.WriteAsync("^^^^^^");
});
app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("###### ");
    //Middleware chaining
    await next();
    await context.Response.WriteAsync(" ######");
});
app.Run(async context =>
{
    await context.Response.WriteAsync("Hello AspNet Core!");
});

app.Run();


