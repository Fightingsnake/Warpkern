using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warpkern
{
    internal class Warpkern
    {
        public WarpkernConsole WarpkernConsole { get; set; } = new WarpkernConsole();
        public event EventHandler<WarpkernEventArgs> ShowTemperatureChange;
        public event EventHandler<WarpkernEventArgs> EmergencyShutdown;
        private bool switchOffOn = false;
        private int temperature = 0;
        internal Random random = new Random();
        public void SwitchStatus()
        { this.switchOffOn = !this.switchOffOn; }
        public bool GetSwitchStatus()
        { return this.switchOffOn; }
        public void TemperaturAendern()
        {
            WarpkernEventArgs waea = new WarpkernEventArgs();
            waea.PreviousTemperature = this.temperature;
            this.temperature = random.Next(600);
            waea.CurrentTemperature = this.temperature;
            waea.CurrentTime = DateTime.Now.ToShortTimeString();
            if (this.temperature > 500)
                EmergencyShutdown(this, waea);
            else
                ShowTemperatureChange(this, waea);

        }
    }
}
