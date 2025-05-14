//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _0512_CSharp
//{
//    //분할 클래스: 클래스의 구현이 길어질 경우 여러 파일로 나누어 구현 하기 위해서
//    partial class MyClass
//    {
//        public void Methoad_A()
//        {
//            Console.WriteLine("Method_A");
//        }
//        public void Methoad_B()
//        {
//            Console.WriteLine("Method_B");
//        }
//    }
//    partial class MyClass
//    {
//        public void Methoad_C()
//        {
//            Console.WriteLine("Method_C");
//        }
//        public void Methoad_D()
//        {
//            Console.WriteLine("Method_D");
//        }
//    }
//    internal class Partial
//    {
//        static void Main(string[] args)
//        {
//            MyClass myClass = new MyClass();
//            myClass.Methoad_A();
//            myClass.Methoad_B();
//            myClass.Methoad_C();
//            myClass.Methoad_D();
//            Console.WriteLine();
//        }
//    }
//}
