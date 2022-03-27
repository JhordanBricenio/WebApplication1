using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class PersonaController : Controller
    {
        public List<User> Usuarios = new List<User>()
        {
            new User{name="Luis" , lastname="Perez"},
            new User{name="Carlos", lastname="Huaman" },
            new User{name="Luis" , lastname="Santoss"},
            new User{name="Pedro" , lastname="laiza"},
            new User{name="Dany" , lastname="Perez"},
            new User{name="Karla" , lastname="Rodrigeus "}
        };

        public IActionResult Index()
        {
            return View("Index",Usuarios);
        }
        public IActionResult form()
        {
            string name = "Luis";
            string lastname = "Perez";
            //Envio de datos hacia la vista
            //primera forma(ViewBag) ---int/string/object/list  ---varios
            ViewBag.Name = name;
            ViewBag.Lastname = lastname;

            //segunda Forma(ViewData)- Varios
            ViewData["Name"]=name;
            ViewData["Lastname"] = lastname;


            //Tercera Forma(Model-> Argumento) -un solo parametro





            return View();
        }
    }
}
