using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Models;

namespace MyPortfolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly List<Portfolio> _portfolios = new List<Portfolio>
        {
            new Portfolio
            {
                Id = 1, Title = "KATANA", Image = "01.jpg", Description = "این اولین پروژه من بود!!!"
            },
            new Portfolio
            {
                Id = 2, Title = "پیام رسان", Image = "02.jpg", Description = "پیام رسان اختصاصی گروه برنامه نویسان"
            },
            new Portfolio
            {
                Id = 3, Title = "شبکه اجتماعی", Image = "03.jpg",
                Description = "شبکه اجتماعی ملی در راستای حمایت از تولید ملی"
            },
            new Portfolio
            {
                Id = 4, Title = "درخواست غذا", Image = "04.jpg",
                Description = "اپلیکیشن درخواست آنلاین غذای نیمه آماده و آماده طبخ"
            }
        };

        public IActionResult Index()
        {
            ViewData["headingTitle"] = "به سایت شخصی افسونگر تنها خوش آمدید";

            ViewBag.headingText =
                "این سایت به جهت معرفی من به مشتریان و کسانی که می خواهند از خدمات سایت بهره مند شوند طراحی و پیاده سازی شده است";
            //return View();
            return View(_portfolios);
            //return View("Index");
            //return View("Index", _portfolios);
        }

        public IActionResult Contact()
        {
            var contact = new Contact()
            {
                Email = "s.mostafa.2001.1380@gmail.com",
                Mobile = "09377857287",
                Github = "github.com/smostafa2001"
            };
            return View(contact);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}