using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodCSharp
{
    interface IParty
    {
        void GoToParty();
    };

    abstract class Party : IParty
    {
        private void GoToBeforeParty()
        {
            Console.WriteLine("I go to a house party!");
        }

        private void GoToAfterParty()
        {
            Console.WriteLine("I go drink to a park!");
        }

        protected abstract void DrinkInClub();

        public void GoToParty()
        {
            GoToBeforeParty();
            DrinkInClub();
            GoToAfterParty();
        }
    };
}
