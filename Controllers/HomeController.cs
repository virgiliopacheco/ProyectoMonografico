﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PlantillaInscripcion.Models;

namespace PlantillaInscripcion.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Inscripcion()

        [HttpPost]
        public IActionResult Inscripcion()
        {
            if (ModelState.IsValid) {

                using (MyContext db = new MyContext()){
                    var Tabla = new Inscripcion();
                    Tabla.Facultad = model.Facultad;
                    Tabla.Escuela = model.Escuela;
                    Tabla.Carrera = model.Carrera;
                    Tabla.Tipo = model.Tipo;
                    Tabla.PlanEstudio = model.PlanEstudio;
                    TempData["Message"] = "Registro guardado correctamente";
                }
            }
  /*           Inscripcion ins = new Inscripcion();
            ins.Facultad = Request.Form["Facultad"].ToString();
            ins.Escuela = Request.Form["Escuela"].ToString();
            ins.Carrera = Request.Form["Carrera"].ToString();
            ins.Tipo = Request.Form["Tipo"].ToString();
            ins.PlanEstudio = Request.Form["PlanEstudio"].ToString(); */

            return Redirect("~/Home/Index");
        }

        public ActionResult DatosPersonales() {
            if (ModelState.IsValid)
            {
                DatosPersonales conexion = new Models.DatosPersonales();
                var oper = new DatosPersonales
                {

                    PrimerNombre = opersonales.PrimerNombre,
                    SegundoNombre = opersonales.SegundoNombre,
                    PrimerApellido = opersonales.PrimerApellido,
                    SegundoApellido = opersonales.SegundoApellido,
                    TipoIdentificacion = opersonales.TipoIdentificacion,
                    NumIdentificacion = opersonales.NumIdentificacion,
                    Sexo = opersonales.Sexo,
                    MatriculaOCodigo = opersonales.MatriculaOCodigo,
                    FechaNacimiento = opersonales.FechaNacimiento,
                    Contacto = opersonales.Contacto,
                    Nacionalidad = opersonales.Nacionalidad,
                    Campus = opersonales.Campus
                };
            };
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}