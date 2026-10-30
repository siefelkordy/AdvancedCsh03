using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace advc_01
{
    internal class GenericClassExample<T> where T : IComparable<T> 
    {
            public GenericClassExample(T t1)
            {
                this.t1 = t1;
                
            }
            public T t1 { get; set; }

        public void Print_maximum(T t1, T t2)
        {
            T max = t1.CompareTo(t2) > 0 ? t1 : t2;
            Console.WriteLine($"Maximum is: {max}");
        }
    }
}
