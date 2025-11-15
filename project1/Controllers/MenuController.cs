using Microsoft.AspNetCore.Mvc;
using project1.Models;

namespace project1.Controllers
{
    public class MenuController: Controller
    {
        private readonly IStaffInterface _staffrepo;

        public MenuController(IStaffInterface staffrepo)
        {
            _staffrepo = staffrepo;


        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Drinks()
        {
            return View();
        }
        public string Staff()
        {
            return _staffrepo.GetStaffById(3)?.firstName;
        }

    }
}
