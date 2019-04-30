using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    /// <summary>
    /// basic singleton for one thread
    /// </summary>
    public class ClassA
    {
        public int Num { get; set; }

        private static ClassA instance;

        private ClassA()
        {

        }

        public static ClassA Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ClassA();
                }
                return instance;
            }
        }

        public void SingletonClassA()
        {

        }
    }
}
