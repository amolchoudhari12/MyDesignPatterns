using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDesignPatterns.TemplatePattern
{
    public class HindiConverter : LanguageConversion
    {       

        public override void ProcessRecrods()
        {
            Console.WriteLine("Converting the records from {0} to Hindi", base.SourceLanguage);
        }

    }
}
