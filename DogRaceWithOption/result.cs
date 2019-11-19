using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogRaceWithOption
{
    abstract class tmr {
        public int stop() {
            return 0;
        }
    }
    public class result
    {
        //timer function used that is working with position of images
        public int  stop(Timer timer,int position ) {
            // if the dog reaches the 700 position timer will stop
            if (position > 700)
            {
                timer.Stop();
                return 1;
            }
            else {
                return 0;
            }
        }

    }
}
