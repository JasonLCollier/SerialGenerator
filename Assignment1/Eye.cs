using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Eye : IBodyPart
    {
        private string Serial;
        private static int EyeCount = 0;
        public string EyeColour { get; set; }

        public Eye(string EyeColour)
        {
            this.EyeColour = EyeColour;
            EyeCount++;
            GenerateSerial();
        }

        public void GenerateSerial()
        {
            if (EyeCount > 10000)
                Serial = "E" + EyeCount.ToString();
            else if (EyeCount > 1000)
                Serial = "E0" + EyeCount.ToString();
            else if (EyeCount > 100)
                Serial = "E00" + EyeCount.ToString();
            else if (EyeCount > 10)
                Serial = "E000" + EyeCount.ToString();
            else
                Serial = "E0000" + EyeCount.ToString();
        }

        public override string ToString()
        {
            return ("Eye: " + GetType() + ": " + Serial + ", " + EyeColour);
        }
    }
}
