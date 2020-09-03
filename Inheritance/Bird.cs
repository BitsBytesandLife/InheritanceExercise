using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    // Create a class Bird - Done
    // give this class 4 members that are specific to Bird - Done
    // Set this class to inherit from your Animal Class Done
    public class Bird : Animal
    {
        public string FeatherColor { get; set; }
        public string Chirp { get; set; }
        public string Peck { get; set; }
        public bool isPerching { get; set; }


    }
}
