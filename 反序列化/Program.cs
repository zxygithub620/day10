using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using 序列化和反序列化;

namespace 反序列化
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建读文件流
            using (FileStream fsReader = new FileStream(@"E:\vs2017\程序\第十天\序列化和反序列化\bin\Debug\123.txt", FileMode.OpenOrCreate, FileAccess.Read))
            {
                BinaryFormatter bf = new BinaryFormatter(); //创建反序列化对象
               Person p   =(Person) bf.Deserialize(fsReader);   //调用反序列化方法   ,返回object类,强转为person子类赋值给p对象
                Console.WriteLine("{0}\t{1}\t{2}\t",p.Age,p.Name,p.Gender);  //验证反序列化是否可行
                Console.ReadKey();
            }
        }
    }
}
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  