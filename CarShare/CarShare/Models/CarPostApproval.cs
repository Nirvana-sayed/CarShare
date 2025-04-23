namespace CarShare.Models
{
    public class CarPostApproval
    {
        public int Id { get; set; }

        public int CarId { get; set; }
        public int AdminId { get; set; }

        public bool IsApproved { get; set; }
        public DateTime ApprovalDate { get; set; }

        public Car Car { get; set; }
        public User Admin { get; set; }
    }

}
