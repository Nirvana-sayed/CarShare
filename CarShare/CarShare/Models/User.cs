﻿namespace CarShare.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; } // Admin, CarOwner, Renter
        public string FullName { get; set; }
        public string Email { get; set; }
    }

}
