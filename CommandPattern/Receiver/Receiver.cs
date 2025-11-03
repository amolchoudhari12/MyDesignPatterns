using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDesignPatterns.CommandPattern
{
    public abstract class Receiver
    {
        protected string FoodName;
        public abstract void CookFood();
    }
}
