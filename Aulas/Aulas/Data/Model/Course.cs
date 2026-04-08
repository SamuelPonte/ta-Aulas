using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aulas.Data.Model
{
    public class Course
    {
        /// <summary>
        /// PK
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Nome da disciplina
        /// </summary>
        [Required(ErrorMessage = "{0} é de preenchimento obrigatório")]
        [StringLength(30)]
        [Display(Name = "Nome da Disciplina")]
        public String Name { get; set; } = String.Empty;

        /// <summary>
        /// Ano curricular da disciplina
        /// </summary>
        [Display(Name = "Ano Curricular")]
        public int CurricularYear { get; set; }

        /// <summary>
        /// Semestre da disciplina
        /// </summary>
        [Display(Name = "Semestre")]
        public int Semester { get; set; }

        /* *******************************
         * Relacionamentos 1-N Regra 4
        ********************************** */
        /// <summary>
        /// FK para o curso a que a disciplina pertence
        /// </summary>
        [ForeignKey(nameof(Degree))]
        [Display(Name = "Curso")]
        public int DegreeFK { get; set; }

        /// <summary>
        /// FK para o curso a que a disciplina pertence
        /// </summary>
        [ValidateNever]
        [Display(Name = "Curso")]
        public Degree Degree { get; set; } = null!;

        /* *******************************
         * Relacionamentos N-M Regra 6
        ********************************** */
        /// <summary>
        /// Lista de inscrições dos alunos associados à disciplina 
        /// </summary>
        public ICollection<Registration> ListOfRegistrations { get; set; } = [];

        /// <summary>
        /// Lista de associações entre a disciplina e os professores que a lecionam
        /// </summary>
        public ICollection<CourseProfessor> CourseProfessors { get; set; } = [];

    }
}
