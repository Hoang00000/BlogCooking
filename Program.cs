var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.MapGet("/", () => "Hello World!");
app.MapGet("/first", async context =>
    {
        string html = @"
                    <!DOCTYPE html>
                    <html>
                    <head>
                        <meta charset=""UTF-8"">
                        <title>Trang web đầu tiên</title>
                    </head>
                    <body>
                        <p>Đây là trang web đầu tiên</p>
                    </body>
                    </html>
        "; 
        
        await context.Response.WriteAsync(html);
    });

app.Run();
