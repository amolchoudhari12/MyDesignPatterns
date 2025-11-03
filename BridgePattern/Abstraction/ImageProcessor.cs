using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDesignPatterns.BridgePattern
{
    public class ImageProcessor : IImageProcessor
    {
        private OSType osType;

        private IImageImplementer iImageImplementor;

        public OSType OSType
        {
            get
            {
                return osType;
            }
            set
            {
                osType = value;
            }
        }


        public ImageProcessor(OSType type)
        {
            this.OSType = type;
            SetImageImaplemetor();
        }

        public IImageImplementer IImageImplementer
        {
            get
            {
                return iImageImplementor;
            }
            set
            {
                iImageImplementor = value;
            }
        }

        private void SetImageImaplemetor()
        {
            switch (OSType)
            {
                case OSType.Windows:
                    iImageImplementor = new WindowsImageImplementor();
                    break;
                case OSType.MAC:
                    iImageImplementor = new MACImageImaplementor();
                    break;
                case OSType.Linux:
                    iImageImplementor = new LinuxImageImaplementor();
                    break;
                default:
                    break;
            }
        }

        public void Show()
        {
            Console.WriteLine("Showing of Images for {0} by {1}", OSType.ToString(), IImageImplementer.GetType().Name);
        }
    }
}
