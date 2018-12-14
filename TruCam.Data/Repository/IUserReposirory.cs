using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TruCam.Data.DataModels;

namespace TruCam.Data.Repository
{
    public interface IUserReposirory
    {
        int Add(User user);

        void Update(User user);

        void Delete(int id);

        User GetDeteil(int id);

        List<User> GetAll();
    }
}
