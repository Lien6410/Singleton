using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    /// <summary>
    /// advance singleton for multi-thread, Lazy initialization, later style
    /// </summary>
    public class ClassE
    {
        public int Num { get; set; }

        private static readonly Lazy<ClassE> lazyInstance = new Lazy<ClassE>(() => new ClassE());

        private ClassE() { }

        public static ClassE Instance { get { return lazyInstance.Value; } }

        public void SingletonClassE()
        {

        }
    }
}
