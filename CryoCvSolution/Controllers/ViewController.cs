using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CryoCv.Models;

namespace CryoCv.Controllers
{
    public class ViewController : Controller
    {
        private readonly ILogger<ViewController> _logger;
        public ViewController(ILogger<ViewController> logger)
        {
            _logger = logger;
        }
        
        // GET: /HelloWorld/
        // public IActionResult Index()
        // {
        //     return HelloWorldView();
        // }
        
        //
        // GET: /HelloWorld/Welcome/
        public string Welcome()
        {
            return ("Welcome Action");
        }
    }
    
}

