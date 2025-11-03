using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDesignPatterns.AdapterPattern
{
    public abstract class RequestMapperAdapater<T, E>
    {
        public abstract T ToDTO(E v);
        public abstract E ToEntity(T v);

        public abstract void SendRequest(T dto);
    }
}
