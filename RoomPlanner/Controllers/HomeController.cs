using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
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
            var rooms = await _roomService.GetRooms();

            return View(rooms);
        }
    }
}
