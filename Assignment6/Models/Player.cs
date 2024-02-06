using System;
using System.Collections.Generic;

namespace Assignment6.Models
{
    public partial class Player
    {
        public int PlayerId { get; set; }
        public string? PlayerName { get; set; }
        public int? JersyNo { get; set; }
        public string? Position { get; set; }
        public string? Team { get; set; }
    }
}
