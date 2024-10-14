using MipequeniaTienda.Models.ViewModels;

namespace MipequeniaTienda.Models.ViewModels
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
