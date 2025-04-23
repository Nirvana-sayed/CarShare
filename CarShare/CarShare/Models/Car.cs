namespace CarShare.Models
{
    public class Car
    {
        public int Id { get; set; }
        public int OwnerId { get; set; } // foreign key to User
        public string Title { get; set; }
        public string Description { get; set; }
        public string CarType { get; set; } // e.g., SUV, Sedan, etc.
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Transmission { get; set; } // "Automatic" or "Manual"
        public string Location { get; set; }
        public string RentalStatus { get; set; } // "Available" or "Rented"
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal RentalPrice { get; set; }

        public User Owner { get; set; } // Navigation property
    }

}
