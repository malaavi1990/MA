using System.Data.Entity;
using MA.DAL.Interfaces;
using MA.DAL.UnitOfWork;
using MA.Domain;

namespace MA.DAL.Classes
{
    public class NewsCategoryDal : GenericDal<NewsCategory>, INewsCategoryDal
    {
        private readonly DataContext _context;
        private readonly DbSet<NewsCategory> _newsCategories;

        public NewsCategoryDal(DataContext context) : base(context)
        {
            _context = context;
            _newsCategories = context.Set<NewsCategory>();
        }
    }
}
