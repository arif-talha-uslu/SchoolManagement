using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolManagement.Models.Entities
{
    public class Teacher
    {
        public int TeacherId { get; set; }

        [Column(TypeName = "VARCHAR")]
        [MaxLength(50)]
        public string TeacherName { get; set; }

        [Column(TypeName = "VARCHAR")]
        [MaxLength(100)]
        public string TeacherProfession { get; set; }
    }
}
