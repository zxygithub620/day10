using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace 序列化和反序列化
{
    class Program
    {
        static void Main(string[] args)   //将Person类对象p的三个属性转换为二进制写到指定路径下的txt文件里
        {
            Person p = new Person("张三", 23, '男'); //实例化person类对象 p
            using (FileStream fsWriter = new FileStream(@"123.txt", FileMode.OpenOrCreate, FileAccess.Write))  //写文件列
            {
                //生产序列化对象bf
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fsWriter, p);  //调用bf方法
            }
        }
    }
    [Serializable]   //放在类上方
    public class Person
    {
        public Person(string name, int age, char gender)
        {
            this._name = name;
            this._gender = gender;
            this._age = age;
        }
        private string _name;
        public string Name 
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        private int _age;
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
            }
        }
        private char _gender;
        public char Gender
        {
            get
            {
                return _gender;
            }
            set
            {
                _gender = value;
            }
        }
    }
}
