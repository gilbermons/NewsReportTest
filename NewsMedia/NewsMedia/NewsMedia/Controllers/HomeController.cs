#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization; //to add authentication
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using NewsMedia.Data;
using NewsMedia.Services;
using NewsMedia.Models;
using System.Diagnostics;

namespace NewsMedia.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ReportsApiClient _reportsApiClient;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context, ReportsApiClient reportsApiClient)
        {
            _logger = logger;
            _context = context;
            _reportsApiClient = reportsApiClient;
        }

        public IActionResult Index()
        {

            ////var nr = new NewsReport();
            //// Busco todos los reports (tiene category ID)
            //var newsReports = _context.NewsReport.ToList();

            //// Creo lista de viewmodels que tendran los reportes con los category names
            //var viewModels = new List<NewsReportViewModel>();

            //foreach (var nr in newsReports)
            //{
            //    var temp = new NewsReportViewModel();

            //    temp.Id = nr.Id;
            //    temp.Title = nr.Title;
            //    temp.Body = nr.Body;
            //    temp.CreationDate = nr.CreationDate;
            //    //var test = (Category)_context.Category.Where(c => c.Id == Convert.ToInt32(nr.Category));
            //    temp.CategoryName = ((Category)_context.Category.FirstOrDefault(c => c.Id == nr.CategoryId)).Name;
            //    temp.CreationEmail = nr.CreationEmail;
            //    viewModels.Add(temp);
            //};

            //return View(viewModels);

            return View();


        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}