using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    /// <summary>
    /// advance singleton for multi-thread, Lazy initialization, earlyer style
    /// </summary>
    public class ClassD
    {
        public int Num { get; set; }

        private static class SingletonHolder
        {
            internal static readonly ClassD instance = new ClassD();

            static SingletonHolder() { }
        }

        private ClassD() { }

        public static ClassD Instance { get { return SingletonHolder.instance; } }

        public void SingletonClassD()
        {

        }
    }
}
