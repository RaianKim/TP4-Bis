﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP4_Bis.Models;

namespace TP4_Bis.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        
        ViewBag.ListarPaises = Info.ListarPaises(); 
        return View("Index");
    }

    public IActionResult DetallePais(string pais)
    {
        ViewBag.paisBuscar = Info.DetallePais(pais);
        return View("detallePais");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
