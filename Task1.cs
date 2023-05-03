using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structura_dz
{
    public struct Vector3D
    {
        public double x, y, z;

        public Vector3D(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public static Vector3D operator *(Vector3D vector, double scalar)
        {
            return new Vector3D(vector.x * scalar, vector.y * scalar, vector.z * scalar);
        }

        public static Vector3D operator +(Vector3D vector1, Vector3D vector2)
        {
            return new Vector3D(vector1.x + vector2.x, vector1.y + vector2.y, vector1.z + vector2.z);
        }

        public static Vector3D operator -(Vector3D vector1, Vector3D vector2)
        {
            return new Vector3D(vector1.x - vector2.x, vector1.y - vector2.y, vector1.z - vector2.z);
        }
    }
    internal class Task1
    {
        public static void task1()
        {
            Vector3D v = new Vector3D(1, 2, 3);
            Vector3D result = v * 2;
          
            Console.WriteLine("Result 1 : \n"+$"x = {result.x}"); 
            Console.WriteLine($"y = {result.y}"); 
            Console.WriteLine($"z = {result.z}");

            Vector3D v1 = new Vector3D(1, 2, 3);
            Vector3D v2 = new Vector3D(4, 5, 6);
            result = v1 + v2;
            Console.WriteLine("Result 2 : \n" + $"x = {result.x}");
            Console.WriteLine($"y = {result.y}");
            Console.WriteLine($"z = {result.z}");

            v1 = new Vector3D(4, 5, 6);
            v2 = new Vector3D(1, 2, 3);
            result = v1 - v2;
            Console.WriteLine("Result 3 : \n" + $"x = {result.x}");
            Console.WriteLine($"y = {result.y}");
            Console.WriteLine($"z = {result.z}");

        }
    }
}
