using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDesignPatterns.TemplatePattern
{
    public abstract class LanguageConversion
    {
        public string SourceLanguage { get; set; }
        public string DestinationLanguage { get; set; }

        public virtual void SelectRecords()
        {
            Console.WriteLine("Selecting the records from db by {0} ", this.GetType().Name);
        }
        public abstract void ProcessRecrods();
        public virtual void UpdateRecords()
        {
            Console.WriteLine("Updating the records in DB by {0}", this.GetType().Name);
        }
        public virtual void UpdateFlags()
        {
            Console.WriteLine("Updating the flags records in DB by {0}", this.GetType().Name);
        }

        public void Run()
        {
            SelectRecords();
            ProcessRecrods();
            UpdateRecords();
            UpdateFlags();
        }
    }
}
