using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aulas.Data.Model
{
    [PrimaryKey(nameof(CourseFK), nameof(ProfessorFK))]
    public class CourseProfessor
    {
        /* *******************************
         * Relacionamentos N-M regra 6
         * Tabela de relacionamento N-M entre Course e Professor
        ********************************** */
        /// <summary>
        /// FK para disciplina associada ao professor
        /// </summary>
        [ForeignKey(nameof(Course))]
        [Display(Name = "Disciplina")]
        public int CourseFK { get; set; }

        /// <summary>
        /// FK para disciplina associada ao professor
        /// </summary>
        [ValidateNever]
        [Display(Name = "Disciplina")]
        public Course Course { get; set; } = null!;

        /// <summary>
        /// FK pra Professor associado à disciplina
        /// </summary>
        [ForeignKey(nameof(Professor))]
        [Display(Name = "Professor")]
        public int ProfessorFK { get; set; }

        /// <summary>
        /// FK pra Professor associado à disciplina
        /// </summary>
        [ValidateNever]
        [Display(Name = "Professor")]
        public Professor Professor { get; set; } = null!;
    }
}
