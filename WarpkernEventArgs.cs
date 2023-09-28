using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warpkern
{
    internal class WarpkernEventArgs
    {
        public int PreviousTemperature { get; set; } = 0;
        public int CurrentTemperature { get; set; }
        public string CurrentTime { get; set; }
    }
}
