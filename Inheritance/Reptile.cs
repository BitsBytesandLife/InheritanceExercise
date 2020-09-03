using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    // Create a class Reptile
    // give this class 4 members that are specific to Reptile
    // Set this class to inherit from your Animal Class
    public class Reptile : Animal
    {
        public string SkinColor { get; set; }
        public bool HaveFangs { get; set; }
        public bool DetachedTail { get; set; }

        public string Talk { get; set; }

    }
}
