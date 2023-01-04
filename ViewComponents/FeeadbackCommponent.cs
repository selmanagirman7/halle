using Microsoft.AspNetCore.Mvc;

namespace KaradumanRafUI.ViewComponents
{
    public class FeadbackCommponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
