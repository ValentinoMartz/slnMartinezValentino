﻿using Microsoft.AspNetCore.Mvc;
using SistemaWebMisRecetas.Data;
using SistemaWebMisRecetas.Models;
using System.Collections.Generic;
using System.Linq;

namespace SistemaWebMisRecetas.Controllers
{
    public class RecetaController : Controller
    {

        private readonly DBRecetasContext context;

        public RecetaController(DBRecetasContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var recetas = context.Recetas.ToList();
            return View(recetas);
        }


        [HttpGet("{autor}")]
        public ActionResult<Receta> GetByAutor(string autor)
        {

            List<Receta> recetas = (from e in context.Recetas
                                    where e.Autor == autor
                                    select e).ToList();
            return View("GetByAutor", recetas);
        }

        [HttpGet("apellido/{apellido}")]
        public ActionResult<Receta> GetByApellido(string apellido)
        {

            List<Receta> recetas = (from e in context.Recetas
                                    where e.Apellido == apellido
                                    select e).ToList();
            return View("GetByApellido", recetas);
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            var receta = TraerUna(id);
            if (receta == null)
            {
                return NotFound();
            }
            else
            {
                return View("Details", receta);
            }
        }

        [HttpGet]
        public ActionResult Create()
        {
            Receta receta = new Receta();
            return View("Create", receta);
        }

        [HttpPost]
        public ActionResult Create(Receta receta)
        {
            if (ModelState.IsValid)
            {
                context.Recetas.Add(receta);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(receta);
        }




        private Receta TraerUna(int id)
        {
            return context.Recetas.Find(id);
        }




    }
}
