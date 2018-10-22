using System;
using MA.DAL.Classes;
using MA.DAL.Interfaces;

namespace MA.DAL.UnitOfWork
{
    public class UnitOfWork : IDisposable
    {
        private readonly DataContext _context = new DataContext();

        private ISiteSettingDal _siteSettingDal;
        public ISiteSettingDal SiteSettingDal
        {
            get
            {
                if (_siteSettingDal == null)
                {
                    _siteSettingDal = new SiteSettingDal(_context);
                }

                return _siteSettingDal;
            }
        }

        private ISiteSectionDal _siteSectionDal;
        public ISiteSectionDal SiteSectionDal
        {
            get
            {
                if (_siteSectionDal == null)
                {
                    _siteSectionDal = new SiteSectionDal(_context);
                }

                return _siteSectionDal;
            }
        }

        private IRoleDal _roleDal;
        public IRoleDal RoleDal
        {
            get
            {
                if (_roleDal == null)
                {
                    _roleDal = new RoleDal(_context);
                }

                return _roleDal;
            }
        }

        private IUserDal _userDal;
        public IUserDal UserDal
        {
            get
            {
                if (_userDal == null)
                {
                    _userDal = new UserDal(_context);
                }

                return _userDal;
            }
        }

        private ISliderDal _sliderDal;
        public ISliderDal SliderDal
        {
            get
            {
                if (_sliderDal == null)
                {
                    _sliderDal = new SliderDal(_context);
                }

                return _sliderDal;
            }
        }

        private IServiceDal _serviceDal;
        public IServiceDal ServiceDal
        {
            get
            {
                if (_serviceDal == null)
                {
                    _serviceDal = new ServiceDal(_context);
                }

                return _serviceDal;
            }
        }

        private IProductCategoryDal _productCategoryDal;
        public IProductCategoryDal ProductCategoryDal
        {
            get
            {
                if (_productCategoryDal == null)
                {
                    _productCategoryDal = new ProductCategoryDal(_context);
                }

                return _productCategoryDal;
            }
        }

        private IProductDal _productDal;
        public IProductDal ProductDal
        {
            get
            {
                if (_productDal == null)
                {
                    _productDal = new ProductDal(_context);
                }

                return _productDal;
            }
        }

        private ITeamDal _teamDal;
        public ITeamDal TeamDal
        {
            get
            {
                if (_teamDal == null)
                {
                    _teamDal = new TeamDal(_context);
                }

                return _teamDal;
            }
        }

        private INewsCategoryDal _newsCategoryDal;
        public INewsCategoryDal NewsCategoryDal
        {
            get
            {
                if (_newsCategoryDal == null)
                {
                    _newsCategoryDal = new NewsCategoryDal(_context);
                }

                return _newsCategoryDal;
            }
        }

        private INewsDal _newsDal;

        public INewsDal NewsDal
        {
            get
            {
                if (_newsDal == null)
                {
                    _newsDal = new NewsDal(_context);
                }

                return _newsDal;
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
