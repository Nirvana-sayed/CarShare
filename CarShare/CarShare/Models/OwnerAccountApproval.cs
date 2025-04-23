namespace CarShare.Models
{
    public class OwnerAccountApproval
    {
        public int Id { get; set; }

        public int OwnerId { get; set; }
        public int AdminId { get; set; }

        public bool IsApproved { get; set; }
        public DateTime ApprovalDate { get; set; }

        public User Owner { get; set; }
        public User Admin { get; set; }
    }

}
