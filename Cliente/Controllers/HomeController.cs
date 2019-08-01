using Cliente.Sinai;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cliente.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Sinai.WebServiceSoapClient obj = new Sinai.WebServiceSoapClient();

            return View(obj.Lista().ToList());
        }
        public ActionResult Details(int IdRol)
        {
            Sinai.WebServiceSoapClient obj = new Sinai.WebServiceSoapClient();

            return View(obj.Details(IdRol));
        }
        [HttpGet]
        public ActionResult Edit(int IdRol)
        {
            Sinai.WebServiceSoapClient obj = new Sinai.WebServiceSoapClient();

            return View(obj.Details(IdRol));
        }
        [HttpPost]
        public ActionResult Edit(EntRol r)
        {
            Sinai.WebServiceSoapClient obj = new Sinai.WebServiceSoapClient();

            obj.Actualizar(r);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Create()
        {
           
            return View("Create");
        }
        [HttpPost]
        public ActionResult Create(EntRol r)
        {
            Sinai.WebServiceSoapClient obj = new Sinai.WebServiceSoapClient();

            obj.Agregar(r);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Delete(int IdRol)
        {

            Sinai.WebServiceSoapClient obj = new Sinai.WebServiceSoapClient();

            return View(obj.Details(IdRol));
        }
        [HttpPost]
        public ActionResult Delete(int IdRol,EntRol rol)
        {
            Sinai.WebServiceSoapClient obj = new Sinai.WebServiceSoapClient();

            obj.Eliminar(IdRol);

            return RedirectToAction("Index");
        }
    }
}