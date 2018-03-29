using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipsTricks.SampleClass
{
    class GenericSample<T> : IDisposable where T : IDisposable
    {
        private T _value;
        public GenericSample(T value)
        {
            this._value = value;
        }
        public bool Compare(T val)
        {
            return this._value.Equals(val);
        }
        public bool Compare(T val, T val2)
        {
            return val.Equals(val2);
        }

        public void Dispose()
        {
            this._value.Dispose();
        }
    }
}
