using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class PersonaController : Controller
    {
        private static List<User> Usuarios = new List<User>()
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



        //En lugar de gurdar parametros individuales, encapsulamos
        public IActionResult Guardar(User user)
        {
            Usuarios.Add(user);
            //Guardar en la base de datos
            return RedirectToAction("Index");
        }

        //  persona/detalle?=name={$name}
        public IActionResult Detalle(string name)
        {
            var user= Usuarios.First(o =>o.name==name);
            return View(user);
        }
        public IActionResult Delete(string name)
        {
            var user = Usuarios.First(o => o.name == name);
            Usuarios.Remove(user);
            return RedirectToAction("Index");
        }

        public IActionResult Editar(string name)
        {
            var user = Usuarios.First(o => o.name == name);
            return View(user);

        }

        public IActionResult Actualizar(User user)
        {
            var model = Usuarios.First(o => o.name == user.name);
            model.email = user.email;
            model.lastname = user.lastname;
            return RedirectToAction("Index");

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
