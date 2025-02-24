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
    }
}