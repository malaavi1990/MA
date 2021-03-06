﻿using System.Data.Entity;
using MA.DAL.Interfaces;
using MA.DAL.UnitOfWork;
using MA.Domain;

namespace MA.DAL.Classes
{
    public class ProductCategoryDal : GenericDal<ProductCategory>, IProductCategoryDal
    {
        private readonly DataContext _context;
        private readonly DbSet<ProductCategory> _productCategories;

        public ProductCategoryDal(DataContext context) : base(context)
        {
            _context = context;
            _productCategories = context.Set<ProductCategory>();
        }
    }
}
