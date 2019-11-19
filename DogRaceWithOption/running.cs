using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogRaceWithOption
{
    // running class is used for seeing that randomly which dog is winner
    public class running
    {
        //for Dog 1 :this work with auto genrated function of Visual Studio Random and this function goves the unique value each time 
        Random objct = new Random();
        public int dog1()
        {
            return objct.Next(1, 30);
        }
        //for Dog 2 :this work with auto genrated function of Visual Studio Random and this function goves the unique value each time 
        public int dog2()
        {
            return objct.Next(1, 30);
        }
        //for Dog 3 :this work with auto genrated function of Visual Studio Random and this function goves the unique value each time 
        public int dog3()
        {
            return objct.Next(1, 30);
        }
        //for Dog 4 :this work with auto genrated function of Visual Studio Random and this function goves the unique value each time 
        public int dog4()
        {
            return objct.Next(1, 30);
        }
    }
}
