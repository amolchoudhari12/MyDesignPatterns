using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDesignPatterns.TemplatePattern
{
    public class MarathiConverter : LanguageConversion
    {
        public override void SelectRecords()
        {
            Console.WriteLine("Selecting the records from db by {0} ", this.GetType().Name);
        }

        public override void ProcessRecrods()
        {
            Console.WriteLine("Converting the records from {0} to marathi", base.SourceLanguage);
        }

        public override void UpdateRecords()
        {
            Console.WriteLine("Updating the records in DB by {0}", this.GetType().Name);
        }

        public override void UpdateFlags()
        {
            Console.WriteLine("Updating the flags records in DB by {0}", this.GetType().Name);
        }
    }
}
