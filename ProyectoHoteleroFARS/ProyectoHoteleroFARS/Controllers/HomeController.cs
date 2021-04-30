﻿using Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProyectoHoteleroFARS.Models;
using ReglasNegocio;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoHoteleroFARS.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult HomeCliente()
        {
            ViewBag.Layout = new LayoutController().getLayout(); //NO BORRAR, AGREGAR ESTA LINEA PARA CADA VISTA DEL CLIENTE******
            Hotel h = new HotelRN().getHotel();
            ViewBag.Nombre = h.TC_Nombre;
            ViewBag.Descripcion = h.TC_Descripcion;
            ViewBag.FotoPrincipal = h.TC_Foto_Principal;
            return View("HomeCliente");
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
