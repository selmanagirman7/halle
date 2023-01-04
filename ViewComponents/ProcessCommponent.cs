using Microsoft.AspNetCore.Mvc;

namespace KaradumanRafUI.ViewComponents
{
    public class ProcessCommponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
