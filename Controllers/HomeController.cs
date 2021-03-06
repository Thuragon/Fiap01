﻿using Fiap01.Data;
using Fiap01.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiap01.Controllers
{
    public class HomeController : Controller
    {
        private PerguntasContext _context;

        public HomeController (PerguntasContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            



            //ViewBag.Nome = "Joao Roberto";
            //ViewData["MeuNome"] = $"É é meu nome mesmo {DateTime.Now}";

            //var pergunta = new Pergunta()
            //{
            //    Id = 1,
            //    Descricao = "Que hroas é a chamada?",
            //    Autor = "Zézinho"
            //};

            return View(_context.Perguntas.ToList());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Pergunta pergunta)
        {
            if (ModelState.IsValid)
            {
                _context.Perguntas.Add(pergunta);
                await _context.SaveChangesAsync();
                var salvarNoBanco = pergunta;
            }
            return View();
        }

        public IActionResult Ajuda()
        {
            return View();
        }
        public IActionResult Sobre()
        {
            return View();
        }

    }
}
