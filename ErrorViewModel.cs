namespace ClaimsSystem.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
namespace ClaimsSystem.Models
{
    public enum ClaimStatus
    {
        Pending,
        Approved,
        Rejected
    }

    public class Claim
    {
        public int Id { get; set; }
        public string LecturerName { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public ClaimStatus Status { get; set; } = ClaimStatus.Pending;
        public string SupportingDocumentPath { get; set; }
        public DateTime DateSubmitted { get; set; } = DateTime.Now;
    }
}
