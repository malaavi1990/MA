using System.Data.Entity.ModelConfiguration;
using MA.Domain;

namespace MA.DAL.Configurations
{
    public class UserConfig : EntityTypeConfiguration<User>
    {
        public UserConfig()
        {

        }
    }
}
