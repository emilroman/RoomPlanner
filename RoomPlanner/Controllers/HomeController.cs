using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoomPlanner.Models;
using Services.Abstractions;

namespace RoomPlanner.Controllers
{
    public class HomeController :  Controller
    {
        private readonly IRoomService _roomService;

        public HomeController(IRoomService roomService)
        {
            _roomService = roomService;
        }

        public async Task<IActionResult> Index()
        {
            try
            {
                var rooms = await _roomService.GetRooms();
                return View(rooms);
            }
            catch (Exception ex)
            {
                return View("Error");
            }
        }

        [HttpPost]
        public async Task<IActionResult> ChangeStatus(ChangeStatusModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                await _roomService.SetStatus(model.RoomId, model.Status);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
