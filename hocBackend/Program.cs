using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hocBackend
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("xin chao");
            int thang;
            thang = 4;
            switch (thang)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine("31 ngay");
                        break;
                case 2:
                    Console.WriteLine("29 ngay");
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine("30 ngay");
                    break;
                default:
                    break;

            }
            Console.ReadLine();
        }
    }
}
