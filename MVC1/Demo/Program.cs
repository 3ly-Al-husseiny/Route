namespace Demo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews(); // Register Built-in Services 
            var app = builder.Build();

            //app.MapGet("/", () => "You Are Login"); // Will Return Hello World 
            //app.MapGet("/", SignIn);
            //app.Run();

            app.UseStaticFiles();

            // MVC 
            app.MapControllerRoute(
                name: "default",
                pattern:"{controller=Home}/{action=Index}"
                );
        }


        public static string SignIn() 
        {
            return "You Are Login";
        }
    }
}
