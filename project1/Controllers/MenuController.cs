using Microsoft.AspNetCore.Mvc;
using project1.Models;
using project1.ViewModel;

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

            MenuIndexViewModel
        viewModel = new MenuIndexViewModel()
        {
            Staffs = _staffrepo.GetAll()
        };

            return View(viewModel);
        }
        public IActionResult Drinks()
        {
            return View();
        }
        public string Staff()
        {
            return _staffrepo.GetStaffById(3)?.firstName;
        }
        public ViewResult Details()
        {
            Staff staff = _staffrepo.GetStaffById(1);

            ViewData["staf"] = staff;
            ViewData["title"] = "Staff details";
            return View(staff);
                }



    }
}
