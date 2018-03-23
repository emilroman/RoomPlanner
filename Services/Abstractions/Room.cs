using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Abstractions
{
    public class Room
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Status Status { get; set; }
    }
}
