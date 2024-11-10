class Program
{
    static bool DevMode = false;


    static void Main(String[] args)
    {
        if (args.Contains("--dev")) DevMode = true;
        var builder = WebApplication.CreateBuilder(args);
        var app = builder.Build();
        if (DevMode)
            app.UseDeveloperExceptionPage();

        app.Run();
    }
}
