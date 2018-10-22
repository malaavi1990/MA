using System.Data.Entity;
using MA.DAL.Interfaces;
using MA.DAL.UnitOfWork;
using MA.Domain;

namespace MA.DAL.Classes
{
    public class ProductDal : GenericDal<Product>, IProductDal
    {
        private readonly DataContext _context;
        private readonly DbSet<Product> _products;

        public ProductDal(DataContext context) : base(context)
        {
            _context = context;
            _products = context.Set<Product>();
        }
    }
}
