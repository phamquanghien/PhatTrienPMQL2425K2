using System.ComponentModel.DataAnnotations;
namespace DemoMVC.Models
{
    public class Person
    {
        [Key]
        public string Id { get; set; } = default!;
        [MinLength(3)]
        public string FullName { get; set; } = default!;
        public string? Address { get; set; }
    }
}