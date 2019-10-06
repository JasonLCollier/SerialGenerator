using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    abstract class Limb : IBodyPart
    {
        protected string Serial;
        private static int LimbCount = 0;
        private string LimbDescription;

        public Limb(string LimbDescription)
        {
            this.LimbDescription = LimbDescription;
            LimbCount++;
            GenerateSerial();
        }

        public void GenerateSerial()
        {
            if (LimbCount > 10000)
                Serial = "L" + LimbCount.ToString();
            else if (LimbCount > 1000)
                Serial = "L0" + LimbCount.ToString();
            else if (LimbCount > 100)
                Serial = "L00" + LimbCount.ToString();
            else if (LimbCount > 10)
                Serial = "L000" + LimbCount.ToString();
            else
                Serial = "L0000" + LimbCount.ToString();
        }

        public abstract double CalculatePowerRequirements();

        public override string ToString()
        {
            return (LimbDescription + ": " + GetType() + ": " + Serial + ", " + CalculatePowerRequirements().ToString("F3"));
        }
    }
}
