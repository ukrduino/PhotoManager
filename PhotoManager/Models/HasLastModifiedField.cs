using System;

namespace PhotoManager.Models
{
    interface HasLastModifiedField
    {
        DateTime? LastModified { get; set; }
    }
}
