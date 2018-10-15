using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MA.DAL.Classes;
using MA.DAL.Interfaces;

namespace MA.DAL.UnitOfWork
{
    public class UnitOfWork : IDisposable
    {
        private readonly DataContext _context = new DataContext();

        private IRoleDal _roleDal;
        public IRoleDal RoleDal
        {
            get
            {
                if (_roleDal == null)
                {
                    _roleDal = new RoleDal(_context);
                }

                return _roleDal;
            }
        }

        private readonly IUserDal _userDal;
        public IUserDal UserDal
        {
            get
            {
                if (_userDal == null)
                {
                    _roleDal = new RoleDal(_context);
                }

                return _userDal;
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
