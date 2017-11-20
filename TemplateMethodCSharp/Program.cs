using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var jakub = new JakubParty();
            var michal = new MichalParty();
            var pawel = new PawelParty();

            Console.WriteLine("Jakub:");
            jakub.GoToParty();

            Console.WriteLine("Michal:");
            michal.GoToParty();

            Console.WriteLine("Pawel:");
            pawel.GoToParty();

            Console.Read();
        }
    }
}
