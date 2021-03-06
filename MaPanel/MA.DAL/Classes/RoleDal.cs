﻿using System.Data.Entity;
using MA.DAL.Interfaces;
using MA.DAL.UnitOfWork;
using MA.Domain;

namespace MA.DAL.Classes
{
    public class RoleDal : GenericDal<Role>, IRoleDal
    {
        private readonly DataContext _context;
        private readonly DbSet<Role> _roles;
        public RoleDal(DataContext context) : base(context)
        {
            _context = context;
            _roles = context.Set<Role>();
        }

    }
}
