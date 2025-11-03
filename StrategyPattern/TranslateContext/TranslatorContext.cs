using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace MyDesignPatterns.StrategyPattern.TranslateContext
{
    public class TranslatorContext
    {
        Dictionary<string, string> inputStrig;
        private TranslateStrategy _translateStrategy;

        public TranslatorContext(TranslateStrategy translateStrategy)
        {
            inputStrig = new Dictionary<string, string>();
            this._translateStrategy = translateStrategy;
        }

        public void Add(string key, string value)
        {
            inputStrig.Add(key, value);
        }

        public Dictionary<string, string> Translate()
        {
            if (_translateStrategy != null)
            {
                return _translateStrategy.TranslateStrings(inputStrig);
            }
            return null;
        }
    }
}
