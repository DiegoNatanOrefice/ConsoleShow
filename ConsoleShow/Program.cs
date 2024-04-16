using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleShow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double faturamento = 0;
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine("Estudante?(S para sim | N para não): ");
                    string estudante = Console.ReadLine().ToLower();

                    if (estudante =="s" && i == 0)
                    {
                        faturamento = faturamento + 50;
                    }
                    else if (estudante =="s" && i == 0)
                    {

                    }
                }
            }
        }
    }
}
