using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Warpkern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Warpkern warpkern = new Warpkern();
            warpkern.ShowTemperatureChange += warpkern.WarpkernConsole.OnTemperatureChange;
            warpkern.EmergencyShutdown += warpkern.WarpkernConsole.OnEmergencyShutdown;
            warpkern.SwitchStatus();
            while (warpkern.GetSwitchStatus())
            {
                warpkern.TemperaturAendern();
                Thread.Sleep(100);
            }
        }
    }
}
