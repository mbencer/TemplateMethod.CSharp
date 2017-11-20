using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodCSharp
{
    class PawelParty : Party
    {
        protected override void DrinkInClub()
        {
            Console.WriteLine("I drink whiskey!");
        }
    };
}
