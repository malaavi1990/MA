using System;
using MA.Domain;
using System.Collections.Generic;

namespace MA.Business.Interfaces
{
    public interface IUserBusiness:IDisposable
    {
        IEnumerable<User> Get(int count);
        User GetById(string id);
        User GetByEmail(string email);
        User GetByActiveCode(string id);
        void Update(User user);
        void Insert(User user);
        string[] GetRoleByEmail(string email);
        void Delete(User user);
        void Save();
        void Dispose();
        bool CheckEmail(string email);
    }
}
