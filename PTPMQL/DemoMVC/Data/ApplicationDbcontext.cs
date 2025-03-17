using Microsoft.EntityFrameworkCore;
using DemoMVC.Models;
namespace DemoMVC.Data
{
    using Microsoft.EntityFrameworkCore;
    using DemoMVC.Models;

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        //Ánh xạ class Student vào trong csdl => tạo ra bảng Students
        public DbSet<Student> Students { get; set; }

        public DbSet<Person> Person { get; set; } = default!;

        public DbSet<Employee> Employee { get; set; } = default!;
    }
}