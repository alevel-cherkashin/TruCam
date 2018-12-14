using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TruCam.Data.DataModels;
using TruCam.Data.Repository;

namespace TruCam.Data
{
    public interface IUnitOfWork
    {
        void Seve();

        EFPointRepository EFPointRepository { get; }

        EFUserRepository EFUserRepository { get; }
    }

    public class UnitOfWork : IUnitOfWork
    {
        private bool disposed = false;

        private EFPointRepository _eFPointRepository;

        private EFUserRepository _eFUserRepository;

        private TruCamDataModel _context = new TruCamDataModel();

        public EFPointRepository EFPointRepository
        {
            get 
            {
                if (_eFPointRepository == null)
                {
                    _eFPointRepository = new EFPointRepository(_context);
                }
                return _eFPointRepository;
            }
        }

        public EFUserRepository EFUserRepository
        {
            get
            {
                if (_eFUserRepository == null)
                {
                    _eFUserRepository = new EFUserRepository(_context);
                }
                return _eFUserRepository;
            }
        }

        public void Seve()
        {
            _context.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
