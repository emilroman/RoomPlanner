using System;
using System.Collections.Generic;
using System.Text;

namespace DbAccess.Abstractions
{
    public class RoomEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public StatusEntity Status { get; set; }
    }
}