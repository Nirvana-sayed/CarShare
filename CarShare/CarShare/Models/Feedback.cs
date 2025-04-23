namespace CarShare.Models
{
    public class Feedback
    {
        public int Id { get; set; }

        public int RenterId { get; set; }
        public int CarId { get; set; }

        public int Rating { get; set; } // e.g., 1 to 5
        public string Comment { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public User Renter { get; set; }
        public Car Car { get; set; }
    }

}
