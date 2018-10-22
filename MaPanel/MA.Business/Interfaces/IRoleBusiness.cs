using System.Collections.Generic;
using MA.Domain;

namespace MA.Business.Interfaces
{
    public interface IRoleBusiness
    {
        IEnumerable<Role> Get();
    }
}
