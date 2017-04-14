using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empeek.Domain.Entities
{
    [Table("tblUser")]
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Pet> Pets { get; set; }

        public User()
        {
            Pets = new List<Pet>();
        }
    }
}
