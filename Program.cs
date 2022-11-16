using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
 Console.WriteLine("Введите первое число");
            string chislo1str = Console.ReadLine();
            int chislo1;
            chislo1 = Convert.ToInt32(chislo1str);

            Console.WriteLine("Введите знак");
            string znak1 = Console.ReadLine();
            char znak;
            znak = Convert.ToChar(znak1);

            Console.WriteLine("Введите второе число");
            string chislo2str = Console.ReadLine();
            int chislo2;
            chislo2 = Convert.ToInt32(chislo2str);

          

            if (znak == '+')
            {
                Console.WriteLine(chislo1 + chislo2);
            }
            else if (znak == '-')
            {
                Console.WriteLine(chislo1 - chislo2);
            }
            else if (znak == '/')
                    {
                if (chislo2 == 0)
                {
                    Console.WriteLine("На ноль делить нельзя");
                    
                }
                else 
                {

                    Console.WriteLine(chislo1 / chislo2);
                }
              
            }
            else if (znak == '*')
            {
                Console.WriteLine(chislo1 * chislo2);
            }
        }
    }
} 
    