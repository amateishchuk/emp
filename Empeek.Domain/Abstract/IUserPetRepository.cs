using Empeek.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empeek.Domain.Abstract
{
    public interface IUserPetRepository
    {
        ICollection<User> Users { get; }
        ICollection<Pet> GetPetsByUserId(int userId);
    }
}
