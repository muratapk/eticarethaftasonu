using eticarethaftasonu.Dto;
using eticarethaftasonu.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace eticarethaftasonu.Controllers
{
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(AppUserRegisterDto appUserRegisterDto)
        {
           Random random = new Random();
            int code = 0;
            code = random.Next(100000, 1000000);
            AppUser appUser = new AppUser()
            {
                FirstName=appUserRegisterDto.FirstName,
                LastName=appUserRegisterDto.LastName,
                UserName=appUserRegisterDto.UserName,

                Email=appUserRegisterDto.Email,
                City="İstanbul"

            };
            var result =await _userManager.CreateAsync(appUser, appUserRegisterDto.Password);
            if(result.Succeeded)
            {
                return RedirectToAction("ConfirmMail");
            }
            return View();

        }
    }
}
