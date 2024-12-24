var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

////http status code
//app.Run(async (HttpContext context) =>
//{
//	if (10 == 10)
//	{
//		context.Response.StatusCode = 200;
//	}
//	else
//	{
//		context.Response.StatusCode = 400;
//	}
//	await context.Response.WriteAsync("Hello");
//	await context.Response.WriteAsync(" World");
//});

////http response headers
//app.Run(async (HttpContext context) =>
//{
//	context.Response.Headers["MyKey"] = "my value";
//	context.Response.Headers["Server"] = "My server";
//	context.Response.Headers["Content-Type"] = "text/html";
//	await context.Response.WriteAsync("<h1>Hello</h1>");
//	await context.Response.WriteAsync("<h2>World</h2>");
//});

////http request
//app.Run(async (HttpContext context) =>
//{
//	string path = context.Request.Path;
//	string method = context.Request.Method;

//	context.Response.Headers["Content-type"] = "text/html";
//	await context.Response.WriteAsync($"<p>{path}</p>");
//	await context.Response.WriteAsync($"<p>{method}</p>");
//});

//query string
app.Run(async (HttpContext context) =>
{
	context.Response.Headers["Content-type"] = "text/html";
	if (context.Request.Method == "GET")
	{
		if (context.Request.Query.ContainsKey("id"))
		{
			string id = context.Request.Query["id"];
			await context.Response.WriteAsync($"<p>{id}</p>");
		}
	}
});

app.Run();
