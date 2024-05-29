using System.Data.SqlClient;

class Program
{
    static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        var app = builder.Build();
        app.MapGet("/", () => "Hola Mundo CICD" + DateTime.Now );
        app.Run()
    }
}