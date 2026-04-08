using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;

namespace Aulas.Data.Model
{
    public class MyUser
    {
        [Key]
        public int Id { get; set; }
        public String Name { get; set; }

        public DateTime BirthDate { get; set; }
        // ...
    }
}
