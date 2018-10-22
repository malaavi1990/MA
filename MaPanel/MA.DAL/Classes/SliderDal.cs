using System.Data.Entity;
using MA.DAL.Interfaces;
using MA.DAL.UnitOfWork;
using MA.Domain;

namespace MA.DAL.Classes
{
    public class SliderDal : GenericDal<Slider>, ISliderDal
    {
        private readonly DataContext _context;
        private readonly DbSet<Slider> _sliders;

        public SliderDal(DataContext context) : base(context)
        {
            _context = context;
            _sliders = context.Set<Slider>();
        }
    }
}
