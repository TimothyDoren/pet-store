using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pet_store
{
    internal class Duck : IPet
    {
        public string Name { get; set; }
        public string Speak()
        {
            return "Quak!";
        }
        public void GetOutOfTheRoad()
        {

        }
        public void DontPoopOnYourOwner()
        {

        }
    }
}
