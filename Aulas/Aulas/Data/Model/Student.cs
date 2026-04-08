using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aulas.Data.Model
{
    /// <summary>
    /// classe que representa um estudante, 
    /// herda de MyUser, 
    /// que tem as propriedades Id, Name e BirthDate etc.
    /// </summary>
    public class Student : MyUser
    {
        /// <summary>
        /// Numero de estudante
        /// </summary>
        public int StudentNumber { get; set; }

        /// <summary>
        /// Propinas do aluno, com precisão de 8 dígitos e 2 casas decimais
        /// </summary>
        [Precision(8,2)]
        public decimal TuitionFee { get; set; }

        /// <summary>
        /// Data de inscrição do aluno
        /// </summary>
        public DateTime RegistrationDate { get; set; }

        /* *******************************
         * Relacionamentos 1-N Regra 4
        ********************************** */
        /// <summary>
        /// FK para curso a que o aluno pertence
        /// </summary>
        [ForeignKey(nameof(Degree))]
        [Display(Name = "Curso")]
        public int DegreeFK { get; set; }

        /// <summary>
        /// FK para curso a que o aluno pertence
        /// </summary>
        [ValidateNever]
        [Display(Name = "Curso")]
        public Degree Degree { get; set; } = null!;

        /* *******************************
         * Relacionamentos N-M
        ********************************** */
        /// <summary>
        /// Lista de inscrições as UCs associado ao aluno
        /// </summary>
        public ICollection<Registration> ListOfRegistrations { get; set; } = [];
    }
}
