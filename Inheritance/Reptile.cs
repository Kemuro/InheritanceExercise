using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Reptile : Animal
    {
        public Reptile(string ScaleColor, bool LongTongue, bool HasLegs, bool CanCamouflage)
        {
            this.ScaleColor = ScaleColor;
            this.LongTongue = LongTongue;
            this.HasLegs = HasLegs;
            this.CanCamouflage = CanCamouflage;
            this.name = name;
        }
        public Reptile()
        {

        }
        public string ScaleColor { get; set; }
        public bool LongTongue { get; set; }
        public bool HasLegs { get; set; }
        public bool CanCamouflage { get; set; }

        public void ReptileSheet(string name)
        {
            Console.WriteLine();
            Console.WriteLine($"Name: {name} \n" +
                $"Skin Type: {SkinType} \n" +
                $"Scale Color: {ScaleColor} \n" +
                $"Can Camouflage?: {CanCamouflage} \n" +
                $"Has Legs?: {HasLegs}" +
                $"Number of Legs: {NumOfLegs} \n" +
                $"Has Long Tongue?: {LongTongue} \n" +
                $"Eats Meat?: {EatsMeat} \n" +
                $"Is it Aquatic?: {IsAquatic} \n" +
                $"Is it Nocturnal?: {IsNocturnal}");

        }
    }
}
