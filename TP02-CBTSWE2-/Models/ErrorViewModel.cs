namespace GerenciadorBLContainer.Models
{
    // Bruno Souza (CB3025411)
    // Gabriela Wandenkolk (CB3026108)
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
