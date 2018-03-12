using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sisben.WebApps.QAML.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using (var ctx = new Models.SISBEN_IVEntities())
            {
                ViewBag.Departamentos = ctx.sp__DAT_Departamentos__Get().ToArray();
            }
            return View();
        }

        public ActionResult Municipios(string cod_dpto)
        {
            var id = Convert.ToInt32(cod_dpto);
            using (var ctx = new Models.SISBEN_IVEntities())
            {
                ViewBag.Municipios = ctx.sp__Municipios__GetByDpto(cod_dpto).ToArray();
                ViewBag.Departamento = ctx.DEPARTAMENTOS.Where(x => x.cod_dpto == id).First();
            }
            return View();
        }

        public ActionResult Hogares(string cod_mpio)
        {
            var id = Convert.ToInt32(cod_mpio);
            cod_mpio = cod_mpio.PadLeft(5, '0');
            using (var ctx = new Models.SISBEN_IVEntities())
            {
                ViewBag.Municipio = ctx.MUNICIPIOS.Where(x => x.cod_mpio == id).First();
                ViewBag.Hogares = ctx.CNS_HOGARES.Where(x =>
                    x.Cod_mpio == cod_mpio &&
                    x.ML_Irregular.HasValue && x.ML_Irregular.Value).ToList();
            }
            return View();
        }

        public ActionResult Hogar(int num_ficha, byte ide_hogar)
        {
            using (var ctx = new Models.SISBEN_IVEntities())
            {
                ViewBag.Hogar = ctx.CNS_HOGARES.Where(x => x.Num_ficha == num_ficha && x.Ide_hogar == ide_hogar).First();
                ViewBag.Vivienda = ctx.CNS_VIVIENDAS.Where(x => x.Num_ficha == num_ficha).First();
                ViewBag.Personas = ctx.CNS_PERSONAS.Where(x => x.Num_ficha == num_ficha && x.Ide_hogar == ide_hogar).ToArray();
                ViewBag.ViviendaLog = ctx.CNS_VIVIENDAS_Logs.Where(x => x.Num_ficha == num_ficha && x.Ide_hogar == ide_hogar).First();
                ViewBag.HogarLog = ctx.CNS_HOGARES_Logs.Where(x => x.Num_ficha == num_ficha && x.Ide_hogar == ide_hogar).OrderByDescending(x => x.Fec_evaluado).First();
                ViewBag.PersonasLog = ctx.CNS_PERSONAS_Logs.Where(x => x.Num_ficha == num_ficha && x.Ide_hogar == ide_hogar).ToArray();
            }
            return View();
        }

        public ActionResult ProcesarProximoHogar()
        {
            using (var ctx = new Models.SISBEN_IVEntities())
            {
                ctx.sp__ClasificarProximoHogar();
            }
            return Redirect(Url.Action("Index", "Home"));
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
    }
}