using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PC2ROJAS.Data;
using PC2ROJAS.Models;

namespace PC2ROJAS.Controllers
{
    [Route("[controller]")]
    public class ClienteController : Controller
    {
        private readonly ILogger<ClienteController> _logger;
        private readonly ApplicationDbContext _context;


        public ClienteController(ILogger<ClienteController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

           [HttpGet]
        public IActionResult IndexCliente()
        {
             return View(); 
        }


        [HttpPost]
         public IActionResult Crear(Cliente objcliente)
        {
            _logger.LogDebug("Ingreso a enviar mensaje");
             _context.Add(objcliente);
            _context.SaveChanges();

            ViewData["Message"]="Cuenta creada";

            return View("IndexCliente");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }

}