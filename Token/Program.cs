using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Token
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Token _token = new Token("AAA BBB  CD ");
            //Token _token = new Token("A");
            //Token _token = new Token("");
            //Token _token = new Token(null);

            while (true)
            {
                string _value = _token.GetToken(' ');
                //string _value = _token.GetToken('@');
                if (string.IsNullOrEmpty(_value)) break;

                Console.WriteLine($"[{_value}]");
            }

            Console.ReadLine();
        }
    }
}
