using System;
using System.Collections.Generic;
using System.Text;

namespace JobToApp.Models
{
    public enum BrowserResultType
    {
        Success,
        HttpError,
        UserCancel,
        Timeout,
        UnknownError
    }
}
