using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TODO.Models;

namespace TODO.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
    
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {

        //Through Viewdata
        ViewData["Task"] = "Learn Donet";
        ViewData["Description"] = "Getting started in Web Development";
        ViewData["Status"] = "Done";

        //Through ViewBag
        ViewBag.Task2 = "Project Start";
        ViewBag.Description2 = "Start TODO List Project";
        ViewBag.Status2 = "InProgess";

        // Through ViewListModel
        var taskList = new List<TaskListModel>
        {
            new TaskListModel { Title = "Learn Dotnet", Description = "Starting my journey in Web Development", Status = "In Progress" },
            new TaskListModel { Title = "Build a Project", Description = "Start a new TODO List Project", Status = "In Progress" },
            new TaskListModel { Title = "Push to GitHub", Description = "Push to GitHub to make it publicely available", Status = "Done" }
        };

        return View(taskList);
    }

    [HttpGet]
    //[HttpGPost]
        public IActionResult Contact()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
