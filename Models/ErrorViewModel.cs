// Left this in as the website is still in development and errors could possibly occur

using System;

namespace NETDComm5.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
