using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDesignPatterns.IteratorPattern
{
    public class ConcreateIterator : Iterator
    {
        public ConcreateAggregate _aggregate;
        private int _current = 0;

        public ConcreateIterator(ConcreateAggregate aggregate)
        {
            this._aggregate = aggregate;
        }
        public override object First()
        {
            return _aggregate[0];
        }

        public override object Next()
        {
            object returnValue = null;
            _current += 1;
            if (_current <= _aggregate.Count - 1)
            {
                returnValue = _aggregate[_current];
            }
            return returnValue;
        }

        public override object CurrentItem()
        {
            return _aggregate[_current];
        }

        public override bool IsDone()
        {
            return (_current >=_aggregate.Count+1);
        }
    }
}
