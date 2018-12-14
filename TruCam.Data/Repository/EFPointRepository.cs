using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TruCam.Data.DataModels;

namespace TruCam.Data.Repository
{
    public class EFPointRepository : IPointRepository
    {
        private TruCamDataModel _context;

        public EFPointRepository(TruCamDataModel context)
        {
            _context = context;
        }

        public int Add(Point point)
        {
            _context.Point.Add(point);

            return point.Id;
        }

        public void Delete(int id)
        {
            var point = GetDeteil(id);

            point.IsDeleted = true;
        }

        public List<Point> GetAll()
        {
            return _context.Point.Where(x => x.IsDeleted == false).ToList();
        }

        public Point GetDeteil(int id)
        {
            var point= _context.Point.FirstOrDefault(x => x.Id == id);

            if (point.IsDeleted == false) 
            {
                return point;
            }
            else
            {
                return null;
            }
        }

        public void Update(Point point)
        {
            var oldPoint = GetDeteil(point.Id);

            oldPoint.PointCoordinates = point.PointCoordinates;
            oldPoint.PointName = point.PointName;
            oldPoint.Current = point.Current;
            oldPoint.CreatorId = point.CreatorId;
            oldPoint.IsDeleted = point.IsDeleted;
        }
    }
}
