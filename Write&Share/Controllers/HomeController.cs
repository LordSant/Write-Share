using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using System.Diagnostics;
using Write_Share.Models;

namespace Write_Share.Controllers
{
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

        [HttpPost]
        public JsonResult Login(string email, string password)
        {
            bool checkUser = false;
            Conexion_DB conexion_DB = new Conexion_DB();
            string query = "SELECT * FROM write&share.usuario WHERE correo= '" + email + "' AND contrasena= '" + password + "' ";

            MySqlCommand cmd = new MySqlCommand(query, conexion_DB.AbrirConexion());

            MySqlDataReader lector = cmd.ExecuteReader();
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    checkUser = true;
                }
            }

            string jsonResponse = "";
            if (checkUser == true)
            {
                jsonResponse = "{\"status\":200, \"data\":{\"user\":\"" + email + "\"}}";
            }
            else
            {
                jsonResponse = "{\"status\":500, \"data\":\"Error, el usuario no existe en la BD\"}";
            }
            return Json(jsonResponse);
        }
        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
