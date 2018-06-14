using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Sisben.WebApps.QAML.Controllers
{
    /// <summary>
    /// Controlador principal que contiene las acciones de las vistas de la aplicación Web.
    /// </summary>
    public class HomeController : Controller
    {
        /// <summary>
        /// Esta acción muestra una vista con el listado de departamentos y los hogares
        /// procesados (e irregulares) para cada uno.
        /// </summary>
        /// <returns>Retorna un objeto ActionResult que contiene los departamentos con sus indicadores.</returns>
        public IActionResult Index()
        {
            using (var ctx = new Models.SISBEN_IVEntities())
            {
                ViewBag.Departamentos = ctx.sp__DAT_Departamentos__Get().ToArray();
            }
            return View();
        }

        /// <summary>
        /// Esta acción muestra una vista con el listado de municipios para el departamento
        /// especificado en el parámetro *cod_dpto*. Este listado muestra los hogares procesados
        /// y, de estos, los hogares clasificados como irregulares.
        /// </summary>
        /// <param name="cod_dpto">Código del departamento para el cual se desean listar los municipios.</param>
        /// <returns>
        /// Retorna un objeto ActionResult que contiene los municipios del departamento especificado
        /// en el parámetro *cod_dpto* y la información del departamento.
        /// </returns>
        public IActionResult Municipios(string cod_dpto)
        {
            var id = Convert.ToInt32(cod_dpto);
            using (var ctx = new Models.SISBEN_IVEntities())
            {
                ViewBag.Municipios = ctx.sp__Municipios__GetByDpto(cod_dpto).ToArray();
                ViewBag.Departamento = ctx.DEPARTAMENTOS.Where(x => x.cod_dpto == id).First();
            }
            return View();
        }

        /// <summary>
        /// Esta acción muestr una vista con el listado de hogares para el municipio especificado
        /// en el parámetro *cod_mpio*. Este listado muestra los hogares procesados y, de estos,
        /// los hogares clasificados como irregulares.
        /// </summary>
        /// <param name="cod_mpio">Código del municipio para el cual se desean listar los hogares.</param>
        /// <returns>
        /// Retorna un objeto ActionResult que contiene los hogares del municipio especificado en el
        /// parámetro *cod_mpio* y la información del municipio.
        /// </returns>
        public IActionResult Hogares(string cod_mpio)
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

        /// <summary>
        /// Esta acción muestra vista con el detalle de un hogar espeicficado en los parámetros
        /// *num_ficha* e *ide_hogar*. En esta vista se cargan los siguientes datos:
        /// 
        /// * Datos del hogar en cuestión
        /// * Datos de la vivienda a la que pertenece el hogar en cuestión
        /// * Datos de las personas integrantes del hogar en cuestión
        /// * Registro de puntajes de las variables del hogar
        /// * Registro de puntajes de las variables de la vivienda
        /// * Registro de puntajes de las variables de las personas
        /// </summary>
        /// <param name="num_ficha">Número de ficha a la que está asociado el hogar.</param>
        /// <param name="ide_hogar">Número de orden del hogar dentro de la ficha.</param>
        /// <returns>Retorna un objet ActionResult que contiene los datos mensionados en el resumen.</returns>
        public IActionResult Hogar(int num_ficha, byte ide_hogar)
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
    }
}