using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDesignPatterns.BridgePattern
{
    public interface IImageProcessor
    {
        IImageImplementer IImageImplementer { get; set; }

        OSType OSType { get; set; }

        void Show();

    }
}
