using Business.Concrete;
using DataAccess.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace KaradumanRafUI.ViewComponents
{
    public class EnFeaturesCommponent:ViewComponent
    {
        HomeAboutManager homeAboutManager = new HomeAboutManager(new EfHomeAboutDal());
        public IViewComponentResult Invoke()
        {
            var result = homeAboutManager.GetAll();
            return View(result);
        }
    }
}
