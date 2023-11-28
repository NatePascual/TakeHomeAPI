using TakeHome.API.Infrastructures.Implementations;
using TakeHome.API.Infrastructures.Interfaces.Specifications;

namespace TakeHome.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            //Populate Test People
            Data.TestData.GeneratePeople.ExecuteNames();
            // Add services to the container.
            builder.Services.AddControllers();
            builder.Services.AddScoped<IPersonRepository, PersonRepository>();
            builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            var app = builder.Build();

            // Configure the HTTP request pipeline.


            app.UseHttpsRedirection();
          
           // app.UseAuthorization();


            app.MapControllers();

            app.UseRouting();

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapControllerRoute(
            //    name: "default",
            //    pattern: "{controller=People}/{action=people}");
            //});

            app.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=greet}/{id?}");
            app.Run();
        }
    }
}
