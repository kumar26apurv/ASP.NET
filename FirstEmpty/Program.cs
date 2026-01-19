var builder = WebApplication.CreateBuilder(args);
//registering the servuces
builder.Services.AddControllersWithViews();

var app = builder.Build();


app.MapControllerRoute(
	name:"default",
	pattern:"{controller=Home}/{action=Index}/{id?}"
	);
app.Run();

//MIDDLEWARES
//app.Use((context,next) => {
//	context.Response.WriteAsync("Response from midleware");
//	return next();
//});

//app.Run((context) =>
//	context.Response.WriteAsync("Response from midleware")
//);
//app.MapGet("/", () => "Hello World!");

