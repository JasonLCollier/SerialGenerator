using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {            
            IBodyPart[] BodyParts = new IBodyPart[5]; BodyParts[0] = new Eye("Brown");
            BodyParts[1] = new Head("Green", "Blue");
            BodyParts[2] = new Arm("Left arm", 40, 70);
            BodyParts[3] = new Arm("Right arm", 0, 200);
            BodyParts[4] = new Tentacle("A tentacle", 90);
            foreach (IBodyPart Current in BodyParts)
              Console.WriteLine(Current.ToString());
            Console.ReadLine();            
        }
    }
}
