using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDesignPatterns.StrategyPattern
{
    public class EnglishTranslator : TranslateStrategy
    {
        public override Dictionary<string, string> TranslateStrings(Dictionary<string, string> InputStrings)
        {
            Dictionary<string, string> outputStrings = new Dictionary<string, string>();

            foreach (var item in InputStrings)
            {
                //process item
                outputStrings.Add(item.Key, item.Value + " translated to english");
            }
            return outputStrings;
        }
    }
}
