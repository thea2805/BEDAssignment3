﻿using System.ComponentModel.DataAnnotations;

namespace Assignment3.Models
{
    public class Guest
    {
        [Key]
        public int GuestId { get; set; }
        public string Name { get; set; }
        public bool IsAdult { get; set; }

        public bool CheckedIn { get; set; }

        public int RoomId { get; set; }
        public Room? Room { get; set; }

    }
}
