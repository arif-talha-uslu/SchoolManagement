using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolManagement.Models.Entities
{
    public class Student
    {
        public int StudentId { get; set; }

        [Column(TypeName = "VARCHAR")]
        [MaxLength(50)]
        public string StudentName { get; set; }

        [Column(TypeName = "VARCHAR")]
        [MaxLength(70)]
        public string StudentSName { get; set; }
    }
}
