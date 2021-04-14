using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Animal
    {
        public Animal()
        {

        }
        public string name { get; set; }
        public string SkinType { get; set; }
        public int NumOfLegs { get; set; }
        public bool EatsMeat { get; set; }
        public bool IsAquatic { get; set; }
        public bool IsNocturnal { get; set; }
    }
}
