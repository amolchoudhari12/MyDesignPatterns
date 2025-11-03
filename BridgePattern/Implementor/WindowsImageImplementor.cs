using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDesignPatterns.BridgePattern
{
    public class WindowsImageImplementor : IImageImplementer
    {
        public void Save()
        {
            Console.WriteLine("Saving of images for Widnows OS by {0}", this.GetType().Name);
        }

        public void Compress()
        {
            Console.WriteLine("Compressing of images for Widnows OS by {0}", this.GetType().Name);
        }

        public void Draw()
        {
            Console.WriteLine("Drawing of images for Widnows OS by {0}", this.GetType().Name);
        }

        public void Show()
        {
            Console.WriteLine("Showing of images for Widnows OS by {0}", this.GetType().Name);
        }
    }
}
