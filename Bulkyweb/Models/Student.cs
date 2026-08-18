using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bulkyweb.Models
{
    public class Student
    {

        [Key]
        public int Id { get; set; }

        [Column("StudentName", TypeName = "varchar(100)")]
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
    }
}
