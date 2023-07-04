using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Clases;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ProyectoUController : Controller
    {

        // GET: ProyectoUController
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Dashboard()
        {
            return View();
        }
        public ActionResult Gestion()
        {
            return View();
        }
        public ActionResult Productos()
        {
            return View();
        }
        public ActionResult Inventario()
        {
            return View();
        }
        public async Task<int> Validar(Login data)
        {
            DAO cn = new DAO();

            if (cn.ValidarUser(data) == 1)
            {

                return 1;

            }
            else
            {
                return 0;
            }

        }

        public async Task<int> ContarProductos( )
        {
            DAO cn = new DAO();
            return cn.ContarProductos();

        }
        public async Task<int> ContarProveedores()
        {
            DAO cn = new DAO();
            return cn.ContarProveedores();

        }

        
    }
}
