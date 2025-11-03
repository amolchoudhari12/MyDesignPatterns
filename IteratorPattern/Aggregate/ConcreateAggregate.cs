using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace MyDesignPatterns.IteratorPattern
{
    public class ConcreateAggregate : Aggregate
    {
        private ArrayList _collection = new ArrayList();

        public override Iterator CreateIterator()
        {
            return new ConcreateIterator(this);
        }

        public int Count { get { return _collection.Count; } }

        public object this[int index]
        {
            get
            {
                return _collection[index];
            }
            set
            {
                _collection.Add(value);
            }
        }
    }
}
