using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TruCam.Data.DataModels;

namespace TruCam.Data.Repository
{
    public class EFUserRepository : IUserReposirory
    {
        private TruCamDataModel _context;

        public EFUserRepository(TruCamDataModel context)
        {
            _context = context;
        }

        public int Add(User user)
        {
            _context.User.Add(user);
            return user.Id;
        }

        public void Delete(int id)
        {
            var user = GetDeteil(id);

            user.IsDeleted = true;
        }

        public List<User> GetAll()
        {
            return _context.User.Where(x => x.IsDeleted == false).ToList();
        }

        public User GetDeteil(int id)
        {
            var user = _context.User.FirstOrDefault(x => x.Id == id);

            if (user.IsDeleted == false)
            {
                return user;
            }
            else
            {
                return null;
            }
        }

        public void Update(User user)
        {
            var oldUser = GetDeteil(user.Id);

            oldUser.Id = user.Id;
            oldUser.FirstName = user.FirstName;
            oldUser.SecondName = user.SecondName;
            oldUser.City = user.City;
            oldUser.IsDeleted = user.IsDeleted;
        }
    }
}
