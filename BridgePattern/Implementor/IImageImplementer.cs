using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDesignPatterns.BridgePattern
{
    public interface IImageImplementer
    {
        void Save();
        void Compress();
        void Draw();
        void Show();
    }
}
