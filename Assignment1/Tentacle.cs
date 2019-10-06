using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Tentacle : Limb
    {
        private double TentacleLength;

        public Tentacle(string description, int tLength) : base(description)
        {
            TentacleLength = tLength;
            Serial = Serial + "T";
        }

        public override double CalculatePowerRequirements()
        {
            return (Math.Pow((TentacleLength / 4),2));
        }

        public override string ToString()
        {
            return (base.ToString() + ", " + TentacleLength);
        }
    }
}
