
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace DotNetMySqlEFRestAPI.Data.Models
{
    public class PersonContext : DbContext
    {
        private readonly IConfiguration _configuration;
        private readonly string _connectionString;
        public PersonContext(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = configuration.GetConnectionString("default");
        }
        public DbSet<Person> People { get; set; }   

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("connectionstring");
        }
    }
}
