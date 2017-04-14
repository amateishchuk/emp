using Empeek.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empeek.Domain.Entities;

namespace Empeek.Domain.Concrete
{
    public class SQLiteUserPetRepository : IUserPetRepository
    {
        SQLiteDBContext db = new SQLiteDBContext();

        public ICollection<User> Users {
            get
            {
                return db.Users.ToList();
            }

        }

        public ICollection<Pet> GetPetsByUserId(int userId)
        {
            return db.Pets.Where(p => p.UserId == userId).ToList();
        }
    }
}
