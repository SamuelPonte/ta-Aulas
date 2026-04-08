namespace Aulas.Data.Model
{
    public class Professor : MyUser
    {
        /* *******************************
         * Relacionamentos N-M
        ********************************** */
        /// <summary>
        /// Lista de disciplinas associadas ao professor, através da tabela de relacionamento N-M CourseProfessor
        /// </summary>
        public ICollection<CourseProfessor> CourseProfessors { get; set; } = new List<CourseProfessor>();
    }
}
