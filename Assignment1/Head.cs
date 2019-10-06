using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Head : IBodyPart
    {
        private Eye LeftEye;
        private Eye RightEye;
        private string Serial;
        private static int HeadCount = 0;

        public Head(string LeftEyeColour, string RightEyeColour)
        {
            LeftEye = new Eye(LeftEyeColour);
            RightEye = new Eye(RightEyeColour);
            HeadCount++;
            GenerateSerial();
        }

        public void GenerateSerial()
        {
            if (HeadCount > 10000)
                Serial = "H" + HeadCount.ToString();
            else if (HeadCount > 1000)
                Serial = "H0" + HeadCount.ToString();
            else if (HeadCount > 100)
                Serial = "H00" + HeadCount.ToString();
            else if (HeadCount > 10)
                Serial = "H000" + HeadCount.ToString();
            else
                Serial = "H0000" + HeadCount.ToString();
        }

        public override string ToString()
        {
            return ("Head: " + GetType() + ": " + Serial + "\nLeft Eye: " + LeftEye.ToString() + "\nRight Eye: " + RightEye.ToString());
        }
    }
}
