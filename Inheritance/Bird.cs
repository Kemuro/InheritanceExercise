using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Bird : Animal
    {
        public Bird(bool CanSing, bool CanFly, string BrakShape, int AvgChicksPerBatch)
        {
            this.CanSing = CanSing;
            this.CanFly = CanFly;
            this.BeakShape = BeakShape;
            this.AvgChicksPerBatch = AvgChicksPerBatch;
            this.name = name;
        }
        public Bird()
        {

        }
        public bool CanSing { get; set; }
        public bool CanFly { get; set; }
        public string BeakShape { get; set; }
        public int AvgChicksPerBatch { get; set; }

        public void BirdSheet(string name)
        {
            Console.WriteLine();
            Console.WriteLine($"Name: {name} \n" +
                $"Can Sing?: {CanSing} \n" +
                $"Can Fly?: {CanFly} \n" +
                $"Beak Shape: {BeakShape} \n" +
                $"Average Chicks: {AvgChicksPerBatch} \n" +
                $"Skin Type: {SkinType} \n" +
                $"Number of Legs: {NumOfLegs} \n" +
                $"Eats Meat?: {EatsMeat} \n" +
                $"Is it Aquatic?: {IsAquatic} \n" +
                $"Is it Nocturnal?: {IsNocturnal}");
            
        }
    }
}
