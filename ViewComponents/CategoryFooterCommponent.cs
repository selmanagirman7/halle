using Business.Concrete;
using DataAccess.Concrete;
using KaradumanRafUI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace KaradumanRafUI.ViewComponents
{
    public class CategoryFooterCommponent:ViewComponent
    {
        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
        public IViewComponentResult Invoke()
        {
            var result = categoryManager.GetAll();
            return View(result);

        }
    }
}
