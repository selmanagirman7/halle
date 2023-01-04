using Business.Concrete;
using DataAccess.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace KaradumanRafUI.ViewComponents
{
    public class EnContactFooterCommponent:ViewComponent
    {
        ContactManager contactManager = new ContactManager(new EfContactDal());  
        public IViewComponentResult Invoke()
        {
            var result = contactManager.GetAll();
            return View(result);

        }
    }
}
