using System;
using System.Web.Mvc;
using VeiculoWeb.Core;
using VeiculoWeb.Entities.Models;

namespace VeiculoWeb.MVC.Controllers
{
    public class ClienteController : Controller
    {
        private ClienteService clienteService = new ClienteService();

        public ActionResult Index()
        {
            return View();
        }
        
        public JsonResult GetById(string id)
        {
            var clienteId = Convert.ToInt32(id);
            var cliente = clienteService.GetById(clienteId);
            return Json(cliente, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetAll()
        {
            var clientes = clienteService.GetAll();
            return Json(clientes, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult Create(Cliente cliente)
        {
            try
            {
                clienteService.Create(cliente);
                return Json("",JsonRequestBehavior.AllowGet);
            }
            catch
            {
                return Json("", JsonRequestBehavior.DenyGet);
            }
        }
    }
}