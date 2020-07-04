using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProverkaMail
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите email = ");
            string mail = string.Format(Console.ReadLine());
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(mail);
            if (match.Success)
                Console.Write(mail + " верный емаил");
            else
                Console.Write(mail + " неверный емеил");


            Console.ReadKey();
        }
    }
}