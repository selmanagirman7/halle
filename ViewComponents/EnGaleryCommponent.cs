using Business.Concrete;
using DataAccess.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace KaradumanRafUI.ViewComponents
{
    public class EnGaleryCommponent:ViewComponent
    {
        GaleryManager galeryManager = new GaleryManager(new EfGaleyDal());
        public IViewComponentResult Invoke()
        {
            var result = galeryManager.GetAll();
            return View(result);
        }
    }
}
