using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 接口
{
    class Program
    {
        static void Main(string[] args) //麻雀会飞，鹦鹉会飞，鸵鸟不会飞，企鹅不会飞，直升机会飞 
                                        //用多态实现
                                        //虚方法、抽象类、接口
        {
            Console.WriteLine("请输入要选择的编号:");                                                                                                              
            Console.WriteLine("1-麻雀   2-鹦鹉   3-鸵鸟    4-直升机 ");

            int input = 0;
            bool b = false;
            while (b==false)
            {
                try
                {
                    input = Convert.ToInt16(Console.ReadLine());
                    if (input == 1 || input == 2 || input == 3 || input == 4)
                    {
                        switch (input)
                        {
                            case 1:
                                IFlyable flyable1 = new MaQue();
                                flyable1.Fly();
                                b = true;
                                break;
                            case 2:
                                IFlyable flyable2 = new YingWu();
                                flyable2.Fly();
                                b = true;
                                break;
                            case 3:
                                TuoNiao flyable3 = new TuoNiao();
                                flyable3.Fly();
                                b = true;
                                break;
                            case 4:
                                IFlyable flyable4 = new Plane();
                                flyable4.Fly();
                                b = true;
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("请输入正确的编号，1-4");
                    }
                    continue;

                }
                catch
                {
                    Console.WriteLine("请输入数字");
                }
            }
            Console.ReadKey();
        }
    }
    public interface IFlyable   //会飞接口
    {
        void Fly();
    }
    public class MaQue : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("麻雀会飞");
        }
    }
    public class YingWu : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("鹦鹉会飞");
        }
    }
    public class TuoNiao
    {
        public void Fly()
        {
            Console.WriteLine("鸵鸟不会飞");
        }
    }
    public class Plane : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("飞机会飞");
        }
    }

}
