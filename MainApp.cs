using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0512_CSharp
{
    struct Point3D
    {
        public int x;
        public int y; 
        public int z;
        public Point3D(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public override string ToString()//다형성
        {
            return string.Format($"{x}, {y}, {z}");
        }
        public void Print()
        {
            Console.WriteLine($"Point3D : ({x},{y},{z})");
        }
    }
    internal class MainApp
    {
        static void Main(string[] args)
        {
            Point3D p3d1;
            p3d1.x = 10;
            p3d1.y = 20;
            p3d1.z = 30;
            Console.WriteLine(p3d1.ToString());
            Point3D p3d2 = new Point3D(10,20,30);
            Point3D p3d3 = p3d2;
            p3d3.z = 400;
            Console.WriteLine(p3d2.ToString());
            Console.WriteLine(p3d3.ToString());
        }
    }
}
