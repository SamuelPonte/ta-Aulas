using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;

namespace Aulas.Data.Model
{
    /// <summary>
    /// Representa um utilizador genérico, 
    /// com propriedades comuns a todos os tipos 
    /// de utilizadores (estudantes, professores, etc.)
    /// </summary>
    public class MyUser
    {
        /// <summary>
        /// PK
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Nome completo do utilizador
        /// </summary>
        [Display(Name = "Nome Completo")]
        [Required(ErrorMessage = "{0} é de preenchimento obrigatório")]
        [StringLength(50)]
        public String Name { get; set; } = String.Empty;

        /// <summary>
        /// Data de Nascimento do utilizador
        /// </summary>
        [Display(Name = "Data de Nascimento")]
        public DateTime BirthDate { get; set; }

        /// <summary>
        /// Telefone do utilizador
        /// </summary>
        [Display(Name = "Telefone")]
        [Required(ErrorMessage = "{0} é de preenchimento obrigatório")]
        [StringLength(17)]
        public String CellPhone { get; set; } = String.Empty;

        /// <summary>
        /// Id do utilizador
        /// </summary>
        [StringLength(50)]
        public String? UserID { get; set; }
    }
}
