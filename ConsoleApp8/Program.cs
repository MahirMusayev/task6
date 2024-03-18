//a) Method Task:
//Min methodu yaradılır. Daxil olunan arrayın ən kiçik elementini tapır
//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine(Min());
//    }
//    static int Min()
//    {
//        int[] arr = { 6, 4, 7, 3, 2, 5, };
//        int MinNum = arr[0];
//        for (int i = 0; i < arr.Length; i++)
//        {
//            if (MinNum > arr[i])
//            {
//                MinNum = arr[i];
//            }
//        }
//        return MinNum;
//    }
//}







//b) Overload Tasks :
//Area deyə Method(lar) yaradılır.
//1. Çevrənin sahəsi - S = p*r² (p=3)
//2. Düzbucaqlının sahəsi - S = a*b
//3. Düzbucaqlı paralelpipedin tam səthinin sahəsi - S=2(a*b+a*c+b*c)
//4. Üçbucaqlının daxilinə çəkilmiş çevrənin sahəsi - S=p*r; p = (a + b + c) / 2


//namespace ConsoleApp8
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine(Area(5));  ///b de 1ci
//            Console.WriteLine(Area(4, 5)); //b de 2 ci
//            Console.WriteLine(Area(2, 6, 5));// b de 3 cu
//            Console.WriteLine(Area(4, 2, 3, 8)); //b de 4 cu
//        }
//        public static int Area(int r)
//        {
//            int p = 3;
//            return p * (r * r);
//        }
//        public static int Area(int a, int b)
//        {
//            return a * b;
//        }
//        public static int Area(int a, int b, int c)
//        {
//            return 2 * (a * b + a * c + b * c);
//        }
//        public static int Area(int a, int b, int c, int r)
//        {
//            int p = (a + b + c) / 2;
//            return p * r;
//        }
//    }
//}





////////////////////////////////////////
///ikinci usuk

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine(CircleArea());

//        RectangleArea();
//        Paralipipet();
//        TriangleArea();
//    }

//    static double CircleArea()
//    {
//        int p = 4;
//        int radius = 6;
//        double quvet = radius * radius;
//        double sahe = p * quvet;
//        return sahe;
//    }

//    static void RectangleArea()
//    {
//        int lon = 5;
//        int eni = 6;
//        int sahe = lon * eni;
//        Console.WriteLine(sahe);
//    }
//    static void Paralipipet()
//    {
//        int a = 5;
//        int b = 10;
//        int c = 20;
//        int sahe = 2 * (a * b + a * c + b * c);
//        Console.WriteLine(sahe);
//    }
//    static void TriangleArea()
//    {
//        int a = 4;
//        int b = 6;
//        int c = 3;
//        int raduis = 10;
//        int perimetr = (a + b + c) / 2;
//        int sahe = perimetr * raduis;
//        Console.WriteLine(sahe);
//    }
//}