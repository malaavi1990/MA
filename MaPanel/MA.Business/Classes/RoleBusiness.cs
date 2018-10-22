using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MA.Business.Interfaces;
using MA.DAL.UnitOfWork;
using MA.Domain;

namespace MA.Business.Classes
{
    public class RoleBusiness : IRoleBusiness
    {
        private readonly UnitOfWork _uow = new UnitOfWork();

        public IEnumerable<Role> Get()
        {
            try
            {
                return _uow.RoleDal.Get().ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
