﻿using EMovieTicket.Data;
using EMovieTicket.Data.Services;
using EMovieTicket.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace EMovieTicket.Controllers
{
    public class ActorsController : Controller
    {
        public readonly IActorsService _actorsService;
        public ActorsController(IActorsService actorsService)
        {
            _actorsService= actorsService;
        }
        public async Task<IActionResult> Index()
        {
            var actorList = await _actorsService.GetAll();
            return View(actorList);
        }
        //Get: Actors/Create 
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("FullName,ProfilePictureURL,Bio")]Actor actor)
        {
            if (!ModelState.IsValid)
            {
                return View(actor);
            }
            _actorsService.Add(actor);
            return RedirectToAction(nameof(Index));
        }


        //Get: Actor/Details/1

        public IActionResult Details(int  id)
        {
            var actorDetails = _actorsService.GetByID(id);
            if (actorDetails!=null)
            {
                return View(actorDetails);
            }
            return View("No Data found");
        }

        public IActionResult Edit(int id)
        {
            var actorDetails = _actorsService.GetByID(id);
            if (actorDetails != null)
            {
                return View(actorDetails);
            }
            return View("No Data found");
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, Actor actor)
        {
            if (!ModelState.IsValid)
            {
                return View(actor);
            }
            _actorsService.Update(id, actor);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult DefaultEditDetails(int id)
        {
            var actorDetails = _actorsService.GetByID(id);
            if (actorDetails != null)
            {
                return View("~/Views/Actors/Edit.cshtml",actorDetails);
            }
            return View("No Data found");
        }

        public async Task<IActionResult> Delete(int id)
        {
            _actorsService.Delete(id);
            return RedirectToAction(nameof(Index));
        }

    }
}
