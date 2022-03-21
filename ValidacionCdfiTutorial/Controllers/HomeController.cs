using SAT.Services.ConsultaCFDIService;
using SW.Services.Status;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ValidacionCdfiTutorial.Models;

namespace ValidacionCdfiTutorial.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public JsonResult ValidarFacturas()
        {
            RESPUESTA_JSON respuesta = new RESPUESTA_JSON();

            Status status = new Status("https://consultaqr.facturaelectronica.sat.gob.mx/ConsultaCFDIService.svc");
            Acuse response = status.GetStatusCFDI("LSO1306189R5", "XAXX010101000", "603.20", "a00585eb-4455-49ba-b239-44fb082fc41a");
            //Acuse response = status.GetStatusCFDI("RFC EMISOR", "RFC RECEPTOR", "TOTAL", "UUID O FOLIO FISCAL");

            respuesta.CODIGO_ESTATUS = response.CodigoEstatus;
            respuesta.ESTADO = response.Estado;
            respuesta.ES_CANCELABLE = response.EsCancelable;
            respuesta.ESTATUS_CANCELACION = response.EstatusCancelacion;

            return Json(respuesta);
        }
    }
}