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
        
        public int  stop(Timer timer,int position ) {
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
