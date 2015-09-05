using reCAPTCHA.MVC;
using reCAPTCHA.Web.Demo.Helpers;
using reCAPTCHA.Web.Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace reCAPTCHA.Web.Demo.Controllers
{
    [CompressFilter]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(new RegisterModel());
        }

        [HttpPost]
        [CaptchaValidator(
            PrivateKey = "6LcKYQwTAAAAACtpYk5RBqqxgm5G1xVDGq7RH4QK",
            ErrorMessage = "Invalid input captcha.",
            RequiredMessage = "The captcha field is required.")]
        public ActionResult Index(RegisterModel registerModel, bool captchaValid)
        {
            if (ModelState.IsValid)
            {
                registerModel.IsSuccess = true;
            }

            return View(registerModel);
        }

        [OutputCache(CacheProfile = "Level1")]
        public ActionResult Document()
        {
            return View();
        }

    }
}
