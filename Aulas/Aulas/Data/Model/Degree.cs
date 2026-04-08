using System.ComponentModel.DataAnnotations;

namespace Aulas.Data.Model
{
    public class Degree
    {
        /// <summary>
        /// PK
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Nome do curso
        /// </summary>
        [StringLength(100)]
        public String Name { get; set; } = String.Empty;

        /// <summary>
        /// Logotipo do curso
        /// </summary>
        [StringLength(50)]
        public String? Logotype { get; set; }

        /* *******************************
         * Relacionamentos 1-N
        ********************************** */
        /// <summary>
        /// Lista de disciplinas associadas ao curso
        /// </summary>
        public ICollection<Course> ListOfCourses { get; set; } = [];

        /// <summary>
        /// Lista de estudantes associados ao curso
        /// </summary>
        public ICollection<Student> ListOfStudents { get; set; } = [];
    }
}
