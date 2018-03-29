using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipsTricks.SampleClass
{
    public class Customer : IDisposable
    {
        public string Name { get; set; }
        public int Age { get; set; }
        // override object.Equals
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            Customer custToComapre = obj as Customer;
            if (obj == null)
            {
                return false;
            }
            if (this.Name == custToComapre.Name && this.Age == custToComapre.Age)
            {
                return true;
            }

            return base.Equals(obj);
        }

        // override object.GetHashCode
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public void Dispose()
        {}
    }
}
