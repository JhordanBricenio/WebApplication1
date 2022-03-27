using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class PersonaController : Controller
    {
        public List<User> Usuarios = new List<User>()
        {
            new User{name="Luis" , lastname="Perez", email="lPerez@gmail.com"},
            new User{name="Carlos", lastname="Huaman" ,email="lPerez@gmail.com"},
            new User{name="Luis" , lastname="Santoss",email="lPerez@gmail.com"},
            new User{name="Pedro" , lastname="laiza",email="laiza@gmail.com"},
            new User{name="Dany" , lastname="Perez",email="lPerevargas@gmail.com"},
            new User{name="Karla" , lastname="Rodrigeus ",email="jperse233@gmail.com"}
        };
        public IActionResult Create()
        {
            return View();
        }



        public IActionResult Index()
        {
            return View("Index",Usuarios);
        }


        public string Guardar(string name, string lastname)
        {
            //Guardar en la base de datos
            return name +" "+ lastname+ "Persona Guardada";
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
