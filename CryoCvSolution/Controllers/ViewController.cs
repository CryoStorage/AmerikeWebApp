using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace CryoCv.Controllers;

public class ViewController : Controller
{
    //
    // GET: /HelloWorld/
    public string Index()
    {
        return ("Default Action");
    }
    
    //
    // GET: /HelloWorld/Welcome/
    public string Welcome()
    {
        return ("Welcome Action");
    }
}