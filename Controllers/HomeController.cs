using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using lab9.Models;

namespace lab9.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
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

    [HttpPost]
    public IActionResult Index(Grade grade)
    {
        ViewData["StudentName"] = grade.StudentName;
        ViewData["EnYear"] = grade.EnYear;
        ViewData["Grade1"] = grade.Grade1;
        ViewData["Grade2"] = grade.Grade2;
        ViewData["Grade3"] = grade.Grade3;
        grade.CalculateGPA();
        ViewData["gpa"] = grade.Gpa;
        ViewData["displayName"]=grade.StudentName;
        ViewData["displayYear"]=grade.EnYear;
        return View(grade);
    }
}
