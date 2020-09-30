using JobToApp.Extensions;

namespace JobToApp.Models
{
    public class BrowserResult
    {
        public BrowserResultType ResultType { get; set; }
        public string Response { get; set; }
        public string Error { get; set; }
        public bool IsError => Error.IsPresent();
    }
}
