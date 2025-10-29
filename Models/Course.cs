using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StudentManagementSystem.Models
{
    public class Course
    {
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Title { get; set; }

        public ICollection<Student>? Students { get; set; }
    }
}
