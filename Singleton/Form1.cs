using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Singleton
{
    /// <summary>
    /// 讓一個類別只能有一個實例(Instance)的方法。
    /// 產生單一實例的方式：
    /// 懶漢方式(Lazy initialization)：第一次使用時，才產生實例。
    /// 餓漢方式(Eager initialization)：class 載入時就產生實例，不管後面會不會用到。
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    }
}
