using System;
using System.Collections.Generic;
using System.Text;

namespace Api.Helpers
{
    public class CargoDetails
    {
        public double CurrentWeight { get; private set; }
        public double MaxWeight { get; private set; }
        public double CurrentVolume { get; private set; }
        public double MaxVolume { get; private set; }

        public CargoDetails(double currentWeight, double maxWeight, double currentVolume, double maxVolume)
        {
            CurrentWeight = currentWeight;
            MaxWeight = maxWeight;
            CurrentVolume = currentVolume;
            MaxVolume = maxVolume;
        }

        public bool IsOverloaded()
        {
            return CurrentWeight > MaxWeight || CurrentVolume > MaxVolume;
        }
    }
}
