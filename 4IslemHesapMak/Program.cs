using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4IslemHesapMak
{
    class Program
    {
        public static int Topla(int a, int b)
        {
            return a + b;
        }
        public static int Cikart(int a, int b)
        {
            return a - b;
        }
        public static int Carp(int a, int b)
        {
            return a * b;
        }
        public static int Bol(int a, int b)
        {
            return a / b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("bir sayi giriniz");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ikinci sayiyi giriniz");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("1-'+'\n2-'-'\n3-'*'\n4-'/'");
            char secim = Convert.ToChar(Console.ReadLine());
            switch (secim)
            {
              
                case '-':

                    Console.WriteLine(Cikart(a, b));
                    

                    break;

                case '*':

                    Console.WriteLine(Carp(a, b));
                   

                    break;

                case '/':

                    Console.WriteLine(Bol(a, b));
                    

                    break;
                case '+':

                    Console.WriteLine(Topla(a, b));


                    break;
            }
            Console.ReadLine();
        }
    }
}
