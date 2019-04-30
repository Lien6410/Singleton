using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    /// <summary>
    /// basic singleton for multi-thread
    /// </summary>
    public class ClassB
    {
        public int Num { get; set; }

        private static object Mutex = new object();
        private static ClassB instance;

        private ClassB() { }

        public static ClassB Instance
        {
            get
            {
                if (instance==null)
                {
                    lock (Mutex)
                    {
                        if (instance==null)
                        {
                            instance = new ClassB();
                        }
                    }

                }
                return instance;
            }
        }

        public void SingletonClassB()
        {

        }
    }
}
