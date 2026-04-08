using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
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
        /* *******************************
         * Relacionamentos 1-N Regra 6
         * Tabela de relacionamento N-M entre Student e Course
        ********************************** */
        public DateTime RegistrationDate { get; set; }

        // FK para Student
        // [Key, Column(Order = 1)] ---> valido para EF <=6 | não é necessário, pois a chave primária composta será configurada no DbContext
        /// <summary>
        /// FK para estudante associado à disciplina
        /// </summary>
        [ForeignKey(nameof(Student))] // Especifica a FK para o Student
        [Display(Name = "Estudante")]
        public int StudentFK { get; set; }

        /// <summary>
        /// FK para estudante associado à disciplina
        /// </summary>
        [Display(Name = "Estudante")]
        [ValidateNever]
        public Student Student { get; set; } = null!;

        // FK para Course
        // [Key, Column(Order = 2)] ---> valido para EF <=6 | não é necessário, pois a chave primária composta será configurada no DbContext
        /// <summary>
        /// Fk para disciplina associada ao estudante
        /// </summary>
        [ForeignKey(nameof(Course))] // Especifica a FK para o Course
        [Display(Name = "Disciplina")]
        public int CourseFK { get; set; }

        /// <summary>
        /// Fk para disciplina associada ao estudante
        /// </summary>
        [Display(Name = "Disciplina")]
        [ValidateNever]
        public Course Course { get; set; } = null!;
    }
}
