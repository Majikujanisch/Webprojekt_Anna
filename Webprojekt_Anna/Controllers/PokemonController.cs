using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Webprojekt_Anna.Models;

namespace Webprojekt_Anna.Controllers
{
    public class PokemonController : Controller
    {
        public IActionResult Index()
        {
            return View(CreatePokemonList());
        }
        public IActionResult Bisasam()
        {
            return View(CreatePokemonList());
        }
        public IActionResult Bisaknosp()
        {
            return View(CreatePokemonList());
        }
        public IActionResult Bisaflor()
        {
            return View(CreatePokemonList());
        }

        private List<Pokemon> CreatePokemonList()
    {
        return new List<Pokemon>()
        {
            new Pokemon(1, "Bisasam", "Planze", "Gift", 0.7),
            new Pokemon(2, "Bisaknosp", "Planze", "Gift", 1.0),
            new Pokemon(3, "Bisaflor", "Planze", "Gift", 2.0),
        };
    }
    }


    
}
