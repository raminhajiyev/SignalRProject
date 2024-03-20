using Microsoft.AspNetCore.Mvc;

namespace SignalRWebUI.ViewComponents.AdminLayout
{
    public class _ASidebar:ViewComponent
    {
        public IViewComponentResult Invoke() 
        {  return View(); }
    }
}
