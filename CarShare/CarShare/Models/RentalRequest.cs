namespace CarShare.Models
{
    public class RentalRequest
    {
        public int Id { get; set; }

        public int RenterId { get; set; }     // foreign key to User
        public int CarId { get; set; }        // foreign key to Car

        public string LicenseDocument { get; set; } // Path or base64 or just filename
        public string ProposalText { get; set; }

        public string Status { get; set; } // Pending, Accepted, Rejected

        public DateTime RentalDate { get; set; }

        public User Renter { get; set; }
        public Car Car { get; set; }
    }

}
