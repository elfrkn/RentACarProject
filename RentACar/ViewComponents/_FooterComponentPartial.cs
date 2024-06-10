using Microsoft.AspNetCore.Mvc;

namespace RentACar.ViewComponents
{
    public class _FooterComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}