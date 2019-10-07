using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogRaceWithOption
{
    public class running
    {
        Random objct = new Random();
        public int dog1()
        {
            return objct.Next(1, 30);
        }
        public int dog2()
        {
            return objct.Next(1, 30);
        }
        public int dog3()
        {
            return objct.Next(1, 30);
        }

        public int dog4()
        {
            return objct.Next(1, 30);
        }
    }
}
