using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Services.Abstractions;

namespace RoomPlanner.Models
{
    public class ChangeStatusModel
    {
        [Required]
        public int RoomId { get; set; }

        [Required]
        public Status Status { get; set; }
    }
}
