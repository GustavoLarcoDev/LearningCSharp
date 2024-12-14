namespace GameStore.Models
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }
        public string? errorMessage { get; set; }
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
