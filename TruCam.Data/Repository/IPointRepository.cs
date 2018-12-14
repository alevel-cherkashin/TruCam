using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TruCam.Data.DataModels;

namespace TruCam.Data.Repository
{
    public interface IPointRepository
    {
        int Add(Point point);

        void Update(Point point);

        void Delete(int id);

        Point GetDeteil(int id);

        List<Point> GetAll();
    }
}
