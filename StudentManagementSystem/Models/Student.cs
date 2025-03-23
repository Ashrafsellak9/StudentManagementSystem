using System.ComponentModel.DataAnnotations;

namespace StudentManagementSystem.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Enter your valid name please: ")]
        [StringLength(100)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Enter your valid age please: ")]
        [Range(1, 100)]
        public int Age { get; set; }
        [Required]
        public string Course { get; set; }
    }
}
