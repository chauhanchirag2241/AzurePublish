using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using azurewebapplication.Models;
using System.Data.SqlClient;


namespace azurewebapplication.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IConfiguration _configuration;

    public HomeController(ILogger<HomeController> logger,IConfiguration configuration)
    {
        _logger = logger;
        _configuration = configuration;
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
    // public void OnGet(){
    //     string connectionString = _configuration.GetConnectionString("AZURE_SQL_CONNECTONSTRING");
    //     var sqlConnection = new SqlConnection(connectionString);
    // }
}
