using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace es_vettori
{
    internal class Program
    {
        class Vettore
        {
            readonly double x;
            readonly double y; 
            public Vettore(double x, double y)
            {
                this.x = x;
                this.y = y;
            }
            public double X
            {
                get
                {
                    return x;
                }
            }
            public double Y => y;
            public double Angolo
            {
                get
                {
                    return Math.Atan2(y, x);
                }
            }
            public static Vettore operator +(Vettore v1, Vettore v2)
            {
                return new Vettore(v1.x + v2.x, v1.y + v2.y);
            }
            public static double operator *(Vettore v1, Vettore v2)
            {
                return (Math.Sqrt(v1.x * v1.x + v1.y * v1.y)) * (Math.Sqrt(v2.x * v2.x + v2.y * v2.y) * Math.Cos(AngoloVettore(v1, v2)));
            }
            public static Vettore operator *(Vettore v1, double scalare)
            {
                return new Vettore(v1.x * scalare, v1.y * scalare);
            }
            public static Vettore operator -(Vettore v1, Vettore v2)
            {
                return new Vettore(v1.x - v2.x, v1.y - v2.y);
            }

            public override string ToString()
            {
                return string.Format("({0}; {1})", x, y);
            }
        }
        static double AngoloVettore(Vettore v1, Vettore v2)
        {
            return v1.Angolo - v2.Angolo;
        }
        static void Main(string[] args)
        {
            Vettore v1 = new Vettore(2, 5);
            Vettore v2 = new Vettore(3, 4);
            Vettore v3 = v1 + v2;
            v3 = v1 - v2;
            Console.WriteLine(v3.ToString());
            Console.ReadLine();
        }
    }
}