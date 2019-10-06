using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Arm : Limb
    {
        private double upperArm;
        private double foreArm;

        public double UpperArm
        {
            get
            {
                return upperArm;
            }
            set
            {
                if (value < 10 || value > 100)
                    upperArm = 50;
                else
                    upperArm = value;
            }
        }

        public double ForeArm
        {
            get
            {
                return foreArm;
            }
            set
            {
                if (value < 20 || value > 80)
                    foreArm = 50;
                else
                    foreArm = value;
            }
        }

        public Arm(string description, int uLength, int fLength) : base(description)
        {
            UpperArm = uLength;
            ForeArm = fLength;
            Serial = Serial + "A";
        }

        public override double CalculatePowerRequirements()
        {
            return (Math.Sqrt(UpperArm * ForeArm));
        }

        public override string ToString()
        {
            return (base.ToString() + ", " + UpperArm + ", " + ForeArm); 
        }
    }
}
