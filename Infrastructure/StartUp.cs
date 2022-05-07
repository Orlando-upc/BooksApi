using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure
{
    public static class StartUp
    {
        public static IServiceCollection AddPersistense(this IServiceCollection services, IConfiguration config)
        {

            Console.WriteLine("llego acfa");
            var a = config.GetConnectionString("DbBookConnection");
            return services.AddDbContext<BookDbContext>(DbContextOptionsBuilder  => {
                var cadena = config.GetConnectionString("DbBookConnection");
                DbContextOptionsBuilder.UseSqlServer(config.GetConnectionString("DbBookConnection"));
            });
        }

    }
}
