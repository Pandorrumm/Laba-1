using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Cи_Шарп_ЛР1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст");
            string str = Console.ReadLine();
            str = str.ToUpper();

            string pattern = @"^[а-яА-ЯёЁ]+$";
            Regex myReg = new Regex(pattern);
            Match match = myReg.Match(str);
            Console.WriteLine(myReg.IsMatch(str));
            Console.ReadKey();
        }
    }
}
