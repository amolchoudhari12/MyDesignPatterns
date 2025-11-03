using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDesignPatterns.StrategyPattern
{
    public abstract class TranslateStrategy
    {
        public abstract Dictionary<string, string> TranslateStrings(Dictionary<string, string> InputStrings);
    }
}
