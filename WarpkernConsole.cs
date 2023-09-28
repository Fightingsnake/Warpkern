using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Warpkern
{
    internal class WarpkernConsole
    {
        public void OnTemperatureChange(object sender, WarpkernEventArgs eventArgs)
        {
            Console.WriteLine("==============================================");
            Console.WriteLine("There was a change in temperature.");
            Console.WriteLine($"OLD TEMPERATURE : {eventArgs.PreviousTemperature}");
            Console.WriteLine($"NEW TEMPERATURE : {eventArgs.CurrentTemperature}");
            Console.WriteLine("==============================================");
        }
        public void OnEmergencyShutdown(object sender, WarpkernEventArgs eventArgs)
        {
            Console.WriteLine("==============================================");
            Console.WriteLine("THERE WAS A CRITICAL CHANGE IN TEMPERATURE!");
            Console.WriteLine($"OLD TEMPERATURE : {eventArgs.PreviousTemperature}");
            Console.WriteLine($"NEW TEMPERATURE : {eventArgs.CurrentTemperature}");
            Console.WriteLine($"CHANGE AT : {eventArgs.CurrentTime}");
            Console.WriteLine("THE WARPCORE SHUTS DOWN!");
            Console.WriteLine("==============================================");
            Thread.Sleep(eventArgs.CurrentTemperature * 10);
            Warpkern x = (Warpkern)sender;
            x.SwitchStatus();
        }
    }
}
