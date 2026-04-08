using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aulas.Data.Model
{
    /// <summary>
    /// Classe do relacionamento entre alunos e disiplinas
    /// </summary>
    [PrimaryKey(nameof(StudentFK), nameof(CourseFK))] // Configura a chave primária composta
    public class Registration
    {
        public DateTime RegistrationDate { get; set; }

        // FK para Student
        // [Key, Column(Order = 1)] ---> valido para EF <=6 | não é necessário, pois a chave primária composta será configurada no DbContext
        public int StudentFK { get; set; }
        public Student Student { get; set; } = null!;

        // FK para Course
        // [Key, Column(Order = 2)] ---> valido para EF <=6 | não é necessário, pois a chave primária composta será configurada no DbContext
        public int CourseFK { get; set; }
        public Student Course { get; set; } = null!;
    }
}
