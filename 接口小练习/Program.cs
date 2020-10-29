using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 接口小练习
{
    class Program
    {
        static void Main(string[] args) //真的鸭子会游泳，木头鸭子不会游泳，橡皮鸭子会游泳
        {
            ISwimable swimable = new 真鸭子();
            swimable.Swim();
            Console.ReadKey();
        }
    }
    public interface ISwimable  //声明会游泳接口
    {
        void Swim();  //方法
    }
}
