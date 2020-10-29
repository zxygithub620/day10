using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 接口小练习
{
    class 真鸭子:ISwimable
    {
        public void Swim()
        {
            Console.WriteLine("真鸭子会游泳");
        }
    }
}
