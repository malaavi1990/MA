using MA.Domain;

namespace MA.DAL.Interfaces
{
    public interface IUserDal : IGenericDal<User>
    {
        User GetByEmail(string email);
        User GetByActiveCode(string id);
        string[] GetRoleByEmail(string email);
    }
}
