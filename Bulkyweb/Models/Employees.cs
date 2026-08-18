using System.ComponentModel.DataAnnotations;

namespace Bulkyweb.Models
{
    public class Employees
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public string Married { get; set; }

    }
    public enum Gender
    {
        Male, Female
    }
}
