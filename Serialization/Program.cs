using System;
using System.IO;

namespace Serialization
{
    class Program
    {
        static void Main(string[] args)
        {
            SerialTest st = new SerialTest();
            st.SerializeNow();
            st.DeSerializeNow();
        }
    }
}
