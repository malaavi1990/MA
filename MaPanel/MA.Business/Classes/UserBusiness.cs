using System;
using System.Collections.Generic;
using System.Linq;
using MA.Business.Interfaces;
using MA.DAL.UnitOfWork;
using MA.Domain;

namespace MA.Business.Classes
{
    public class UserBusiness : IUserBusiness, IDisposable
    {
        private readonly UnitOfWork _uow = new UnitOfWork();

        public IEnumerable<User> Get(int count)
        {
            try
            {
                if (count == 0)
                {
                    return _uow.UserDal.Get();
                }
                else
                {
                    return _uow.UserDal.Get().Take(count);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public User GetById(string id)
        {
            try
            {
                return _uow.UserDal.GetById(id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public User GetByEmail(string email)
        {
            try
            {
                return _uow.UserDal.GetByEmail(email);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public User GetByActiveCode(string id)
        {
            try
            {
                return _uow.UserDal.GetByActiveCode(id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public string[] GetRoleByEmail(string email)
        {
            try
            {
                return _uow.UserDal.GetRoleByEmail(email);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public void Update(User user)
        {
            try
            {
                _uow.UserDal.Update(user);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public void Delete(User user)
        {
            try
            {
                _uow.UserDal.Delete(user);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public void Insert(User user)
        {
            try
            {
                _uow.UserDal.Insert(user);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public bool CheckEmail(string email)
        {
            try
            {
                User user = _uow.UserDal.GetByEmail(email);
                if (user != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public void Save()
        {
            try
            {
                _uow.Save();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public void Dispose()
        {
            try
            {
                _uow.Dispose();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
