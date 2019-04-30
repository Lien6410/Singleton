using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    /// <summary>
    /// advance singleton for multi-thread, Eager initialization
    /// </summary>
    public class ClassC
    {
        public int Num { get; set; }

        private static readonly ClassC instance = new ClassC();

        private ClassC() { }

        public static ClassC Instance { get { return instance; } }

        public void SingletonClassC()
        {

        }
    }
}
